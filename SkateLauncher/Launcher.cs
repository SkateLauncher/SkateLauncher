using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Windows;

using DiscordRPC;

namespace SkateLauncher
{
    public partial class Launcher : Form
    {
        public static DiscordRpcClient client;
        public static bool ClientInitialized = false;

        public static List<String> Servers = new List<String>();
        public static List<String> SavedServers = new List<String>();
        public static List<String> SkateOnlineServers = new List<String>();

        public static DateTime AppOpenedDateTime = DateTime.Now;
        public static long AppOpenedTimestamp = ((DateTimeOffset)AppOpenedDateTime).ToUnixTimeSeconds();

        public static void SetupClient()
        {
            if (!ClientInitialized)
            {
                ClientInitialized = true;

                client = new DiscordRpcClient("996612400491008141");
                client.Initialize();
            }
        }

        public Launcher()
        {
            InitializeComponent();

            LoadSettings();

            SetupClient();
            UpdatePresence("In the launcher", "");
        }

        public void LoadSettings()
        {
            GamePath.Text = Properties.launcher.Default.GamePath;
            Username.Text = Properties.launcher.Default.Username;
            AddLaunchArgs.Text = Properties.launcher.Default.LaunchArgs;

            Cosmetics.Checked = Properties.launcher.Default.Cosmetics;

            SavedServers = Properties.launcher.Default.Servers.Split(',').ToList();

            RenderingEngine.SelectedIndex = Properties.launcher.Default.RenderingEngine;

            SelectedServerList.SelectedIndex = 0;
        }

        public void OpenSettings(object sender, EventArgs e)
        {
            var settings = new Settings();
            settings.Show();
        }

        public void UpdatePresence(String Details, String State, bool InGame = false)
        {
            if (!Properties.settings.Default.Discord) return;

            if (InGame)
            {
                client.SetPresence(new RichPresence()
                {
                    Details = Details,
                    State = State,
                    Assets = new Assets()
                    {
                        LargeImageKey = "happyman",
                        LargeImageText = "Skate.",
                        SmallImageKey = "s",
                        SmallImageText = "SkateLauncher"
                    },
                    Timestamps = new Timestamps()
                    {
                        StartUnixMilliseconds = (ulong)AppOpenedTimestamp
                    }
                });
            }
            else
            {
                client.SetPresence(new RichPresence()
                {
                    Details = Details,
                    State = State,
                    Assets = new Assets()
                    {
                        LargeImageKey = "s",
                        LargeImageText = "SkateLauncher"
                    },
                    Timestamps = new Timestamps()
                    {
                        StartUnixMilliseconds = (ulong)AppOpenedTimestamp
                    }
                });
            }
        }

        private void ResetAllControlsBackColor(Control control)
        {
            control.BackColor = Color.FromArgb(15, 15, 15);
            control.ForeColor = Color.FromArgb(255, 255, 255);
            if (control.HasChildren)
            {
                // Recursively call this method for each child control.
                foreach (Control childControl in control.Controls)
                {
                    ResetAllControlsBackColor(childControl);
                }
            }
        }

        private void OpenBrowser(object sender, EventArgs e)
        {
            SelectGame.ShowDialog();

            GamePath.Text = SelectGame.FileName;
            Properties.launcher.Default.GamePath = GamePath.Text;
        }

        public static bool PingHost(string hostUri, int portNumber)
        {
            try
            {
                Ping pingSender = new Ping();
                PingReply reply = pingSender.Send(hostUri, 300);

                return true;
            }
            catch
            {
                return false;
            }
        }

        async private void RefreshServers(int listid)
        {
            try
            {
                if (listid == 0)
                {
                    var client = new HttpClient();
                    client.Timeout = TimeSpan.FromSeconds(1);
                    var req = client.GetAsync("https://skatelauncher.com/data/servers.json");
                    
                    String json = req.Result.Content.ReadAsStringAsync().Result;

                    JsonArray arr = JsonNode.Parse(json).AsArray();

                    SkateOnlineServers.Clear();
                    foreach (String e in arr.ToList())
                    {
                        SkateOnlineServers.Add(e);
                    }

                    Servers = SkateOnlineServers;
                }
                else if (listid == 1)
                {
                    Servers = SavedServers; 
                }

                OnlineServers.Items.Clear();
                foreach (String Server in Servers)
                {
                    Debug.WriteLine(Server);
                    var success = PingHost(Server, 25200);

                    if (success)
                    {
                        OnlineServers.Items.Add(Server);
                    }
                }
            }
            catch
            {
                return;
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshServers(SelectedServerList.SelectedIndex);
        }

        private void Launch(object sender, EventArgs e)
        {
            if (GamePath.Text.ToString() == "")
            {
                MessageBox.Show("You need to select a game path!");
                return;
            }
            else if (!SelectGame.CheckFileExists)
            {
                MessageBox.Show("That file does not exist!");
                return;
            }

            String LaunchArgs = "";

            if (Watermark.Checked)
            {
                LaunchArgs += "-DelMarUI.EnableWatermark false ";
            }

            if (RenderingEngine.SelectedIndex == 1)
            {
                LaunchArgs += "-thinclient 0 -Render.Rc2BridgeEnable 1 -Rc2Bridge. DeviceBackend Rc2BridgeBackend_Vulkan -RenderDevice. RenderCore2Enable 1 ";
            }
            else if (RenderingEngine.SelectedIndex == 2)
            {
                LaunchArgs += "-Render.ForceDx11 true ";

            }

            if (Cosmetics.Checked)
            {
                LaunchArgs += "-ItemManager.ForceOwnAll true ";
            }

            if (Online.Checked)
            {
                LaunchArgs += "-DelMarOnline.Enable false -DelMar.LocalPlayerDebugName \"" + Username.Text.ToString() + "\" ";

                String Host = Address.Text;

                if (!PingHost(Host, 25200))
                {
                    MessageBox.Show("That server is offline! Click Refresh to see online servers.");
                    return;
                }

                LaunchArgs += "-Online.ClientIsPresenceEnabled false -Client.ServerIp " + Host + ":25200";

                if (SkateOnlineServers.Contains(Host))
                {
                    UpdatePresence("Playing Online", "skate.online", true);
                }
                else
                {
                    if (Properties.settings.Default.ShowServer)
                    {
                        UpdatePresence("Playing Online", Host, true);
                    }
                    else
                    {
                        UpdatePresence("Playing Online", "", true);
                    }
                }
            }
            else
            {
                LaunchArgs += "-Online.ClientIsPresenceEnabled false -DelMarOnline.Enable false";
                UpdatePresence("Playing Offline", "", true);
            }

            LaunchArgs += " " + AddLaunchArgs.Text;

            LaunchButton.Text = "Game Running...";
            LaunchButton.Enabled = false;

            Process game = Process.Start(GamePath.Text.ToString(), LaunchArgs);
            game.Exited += new EventHandler(GameClosed);
        }

        private void GameClosed(object sender, System.EventArgs e)
        {
            LaunchButton.Text = "Launch Game";
            LaunchButton.Enabled = true;

            UpdatePresence("In the Launcher", "");
        }

        private void ServerClosed(object sender, System.EventArgs e)
        {
            LaunchServer.Text = "Launch Server";
            LaunchServer.Enabled = true;
        }

        private void Launch_Server(object sender, EventArgs e)
        {
            LaunchServer.Text = "Server Running...";
            LaunchServer.Enabled = false;

            Process server = Process.Start(GamePath.Text.ToString(), "-DelMarOnline.Enable false -server");
            server.Exited += new EventHandler(GameClosed);

            Debug.WriteLine(server);
        }

        private void Online_Changed(object sender, EventArgs e)
        {
            Address.Enabled = Online.Checked;
            Username.Enabled = Online.Checked;
        }

        private void SelectedServer_Changed(object sender, EventArgs e)
        {
            Address.Text = OnlineServers.SelectedItem.ToString();
        }

        private void Username_Changed(object sender, EventArgs e)
        {
            Properties.launcher.Default.Username = Username.Text.ToString();
        }

        private void UseVulkan_Changed(object sender, EventArgs e)
        {
            Properties.launcher.Default.RenderingEngine = RenderingEngine.SelectedIndex;
        }

        private void Launcher_Closing(object sender, FormClosingEventArgs e)
        {
            client.Dispose();

            Properties.launcher.Default.Servers = String.Join(',', SavedServers);
            Properties.launcher.Default.Save();
        }

        private void LaunchArgs_Changed(object sender, EventArgs e)
        {
            Properties.launcher.Default.LaunchArgs = AddLaunchArgs.Text.ToString();
        }

        private void SelectedServerList_Changed(object sender, EventArgs e)
        {
            RefreshServers(SelectedServerList.SelectedIndex);
        }

        private void Cosmetics_Changed(object sender, EventArgs e)
        {
            Properties.launcher.Default.Cosmetics = Cosmetics.Checked;
        }
    }
}
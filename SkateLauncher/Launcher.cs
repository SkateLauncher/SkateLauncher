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

using BlueDwarf.Net.Proxy.Client;

using DiscordRPC;

namespace SkateLauncher
{
    public partial class Launcher : Form
    {
        public static String CurrentVersion = "1.0.0-beta.2";

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
            CheckForUpdates();

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

            SavedServers = Properties.launcher.Default.Servers.Split(',').ToList();

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

        async private void CheckForUpdates()
        {
            try
            {
                var client = new HttpClient();
                client.Timeout = TimeSpan.FromSeconds(1);
                var req = client.GetAsync("https://skatelauncher.com/data/version.txt");

                String res = req.Result.Content.ReadAsStringAsync().Result;

                if (CurrentVersion != res)
                {
                    var updateWindow = MessageBox.Show("There is a new version of SkateLauncher available (" + res + ") Would you like to update?", "New Version", MessageBoxButtons.YesNo);
                    if (updateWindow == DialogResult.Yes)
                    {
                        string target = "https://skatelauncher.com/download";

                        var ps = new ProcessStartInfo(target)
                        {
                            UseShellExecute = true,
                            Verb = "open"
                        };
                        Process.Start(ps);

                        Environment.Exit(0);
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

            if (Properties.settings.Default.DisableWatermark) LaunchArgs += "-DelMarUI.EnableWatermark False ";

            if (Properties.settings.Default.UseVulkan) LaunchArgs += "-thinclient 0 -Render.Rc2BridgeEnable 1 -Rc2Bridge. DeviceBackend Rc2BridgeBackend_Vulkan -RenderDevice. RenderCore2Enable 1 ";

            if (Properties.settings.Default.ForceDirectX11) LaunchArgs += "-Render.ForceDx11 False ";

            if (Properties.settings.Default.DebugRender) LaunchArgs += "-DebugRender True ";

            if (Properties.settings.Default.Fullscreen) LaunchArgs += "-ProfileOptions.ForceDefaultFullscreenEnabled true ";

            if (Properties.settings.Default.Shirtless) LaunchArgs += "-ClothSystem.ClientClothWorldThreadCount 0 ";

            if (Properties.settings.Default.DisableTutorial) LaunchArgs += "-Onboarding.Enabled false ";

            if (Properties.settings.Default.CosmeticsBuildKit) LaunchArgs += "-ItemManager.ForceOwnAll True -Architect.ShowAllCategories ";

            LaunchArgs += "-aiSpawnSystem.NumAISkaters " + Properties.settings.Default.AiSkaters + " ";

            if (Online.Checked)
            {
                String Host = Address.Text;

                if (!PingHost(Host, 25200))
                {
                    MessageBox.Show("That server is offline! Click Refresh to see online servers.");
                    return;
                }

                LaunchArgs += "-DelMarOnline.Enable False -DelMar.LocalPlayerDebugName \"" + Username.Text.ToString() + "\" -Online.ClientIsPresenceEnabled False -Client.ServerIp " + Host + ":25200";

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
                LaunchArgs += "-Online.ClientIsPresenceEnabled False -DelMarOnline.Enable False";
                UpdatePresence("Playing Offline", "", true);
            }

            LaunchArgs += " " + AddLaunchArgs.Text;

            Process game = Process.Start(GamePath.Text.ToString(), LaunchArgs);
            game.WaitForExit();
            UpdatePresence("In the Launcher", "");
        }

        private void Launch_Server(object sender, EventArgs e)
        {
            Process server = Process.Start(GamePath.Text.ToString(), "-Online.ClientIsPresenceEnabled false -DelMarJobManager.Enable -server");

            if (Properties.settings.Default.UseProxy)
            {
                
            }
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
    }
}
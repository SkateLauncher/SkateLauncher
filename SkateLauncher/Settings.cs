using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkateLauncher
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();

            LoadSettings();
        }

        public void LoadSettings()
        {
            Discord.Checked = Properties.settings.Default.Discord;
            ShowServer.Checked = Properties.settings.Default.ShowServer;

            UseVulkan.Checked = Properties.settings.Default.UseVulkan;
            ForceDX11.Checked = Properties.settings.Default.ForceDirectX11;
            DebugRender.Checked = Properties.settings.Default.DebugRender;
            UseProxy.Checked = Properties.settings.Default.UseProxy;
            Fullscreen.Checked = Properties.settings.Default.Fullscreen;
            Shirtless.Checked = Properties.settings.Default.Shirtless;
            DisableTutorial.Checked = Properties.settings.Default.DisableTutorial;
            CosmeticsBuildKit.Checked = Properties.settings.Default.CosmeticsBuildKit;
            DisableWatermark.Checked = Properties.settings.Default.DisableWatermark;
            AiSkaters.Value = Properties.settings.Default.AiSkaters;
        }

        private void AddServer_Clicked(object sender, EventArgs e)
        {
            Launcher.SavedServers.Add(ServerHost.Text);
            ServerHost.Text = "";
        }

        private void ClearServers_Clicked(object sender, EventArgs e)
        {
            Launcher.SavedServers.Clear();
        }

        private void SaveSettings(object sender, FormClosingEventArgs e)
        {
            Properties.settings.Default.Discord = Discord.Checked;
            Properties.settings.Default.ShowServer = ShowServer.Checked;

            Properties.settings.Default.UseVulkan = UseVulkan.Checked;
            Properties.settings.Default.ForceDirectX11 = ForceDX11.Checked;
            Properties.settings.Default.DebugRender = DebugRender.Checked;
            Properties.settings.Default.UseProxy = UseProxy.Checked;
            Properties.settings.Default.Fullscreen = Fullscreen.Checked;
            Properties.settings.Default.Shirtless = Shirtless.Checked;
            Properties.settings.Default.DisableTutorial = DisableTutorial.Checked;
            Properties.settings.Default.CosmeticsBuildKit = CosmeticsBuildKit.Checked;
            Properties.settings.Default.DisableWatermark = DisableWatermark.Checked;
            Properties.settings.Default.AiSkaters = (int)AiSkaters.Value;

            Properties.settings.Default.Save();
        }
    }
}

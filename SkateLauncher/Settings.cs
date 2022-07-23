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
        }

        private void Discord_Changed(object sender, EventArgs e)
        {
            Properties.settings.Default.Discord = Discord.Checked;
        }

        private void ShowServer_Changed(object sender, EventArgs e)
        {
            Properties.settings.Default.ShowServer = ShowServer.Checked;
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
    }
}

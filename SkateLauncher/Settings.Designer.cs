namespace SkateLauncher
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.DiscordSettings = new System.Windows.Forms.GroupBox();
            this.Discord = new System.Windows.Forms.CheckBox();
            this.ShowServer = new System.Windows.Forms.CheckBox();
            this.ServerListSettings = new System.Windows.Forms.GroupBox();
            this.ServerHost = new System.Windows.Forms.TextBox();
            this.AddServer = new System.Windows.Forms.Button();
            this.ClearServers = new System.Windows.Forms.Button();
            this.DiscordSettings.SuspendLayout();
            this.ServerListSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // DiscordSettings
            // 
            this.DiscordSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DiscordSettings.AutoSize = true;
            this.DiscordSettings.Controls.Add(this.Discord);
            this.DiscordSettings.Controls.Add(this.ShowServer);
            this.DiscordSettings.Location = new System.Drawing.Point(12, 12);
            this.DiscordSettings.Name = "DiscordSettings";
            this.DiscordSettings.Size = new System.Drawing.Size(251, 88);
            this.DiscordSettings.TabIndex = 0;
            this.DiscordSettings.TabStop = false;
            this.DiscordSettings.Text = "Discord RPC";
            // 
            // Discord
            // 
            this.Discord.AutoSize = true;
            this.Discord.Location = new System.Drawing.Point(6, 22);
            this.Discord.Name = "Discord";
            this.Discord.Size = new System.Drawing.Size(68, 19);
            this.Discord.TabIndex = 1;
            this.Discord.Text = "Enabled";
            this.Discord.UseVisualStyleBackColor = true;
            this.Discord.CheckedChanged += new System.EventHandler(this.Discord_Changed);
            // 
            // ShowServer
            // 
            this.ShowServer.AutoSize = true;
            this.ShowServer.Location = new System.Drawing.Point(6, 47);
            this.ShowServer.Name = "ShowServer";
            this.ShowServer.Size = new System.Drawing.Size(103, 19);
            this.ShowServer.TabIndex = 1;
            this.ShowServer.Text = "Show Server IP";
            this.ShowServer.UseVisualStyleBackColor = true;
            this.ShowServer.CheckedChanged += new System.EventHandler(this.ShowServer_Changed);
            // 
            // ServerListSettings
            // 
            this.ServerListSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerListSettings.AutoSize = true;
            this.ServerListSettings.Controls.Add(this.ClearServers);
            this.ServerListSettings.Controls.Add(this.AddServer);
            this.ServerListSettings.Controls.Add(this.ServerHost);
            this.ServerListSettings.Location = new System.Drawing.Point(12, 106);
            this.ServerListSettings.Name = "ServerListSettings";
            this.ServerListSettings.Size = new System.Drawing.Size(251, 96);
            this.ServerListSettings.TabIndex = 1;
            this.ServerListSettings.TabStop = false;
            this.ServerListSettings.Text = "Servers";
            // 
            // ServerHost
            // 
            this.ServerHost.Location = new System.Drawing.Point(6, 22);
            this.ServerHost.Name = "ServerHost";
            this.ServerHost.PlaceholderText = "0.0.0.0";
            this.ServerHost.Size = new System.Drawing.Size(158, 23);
            this.ServerHost.TabIndex = 0;
            // 
            // AddServer
            // 
            this.AddServer.Location = new System.Drawing.Point(170, 21);
            this.AddServer.Name = "AddServer";
            this.AddServer.Size = new System.Drawing.Size(75, 23);
            this.AddServer.TabIndex = 1;
            this.AddServer.Text = "Add";
            this.AddServer.UseVisualStyleBackColor = true;
            this.AddServer.Click += new System.EventHandler(this.AddServer_Clicked);
            // 
            // ClearServers
            // 
            this.ClearServers.Location = new System.Drawing.Point(6, 51);
            this.ClearServers.Name = "ClearServers";
            this.ClearServers.Size = new System.Drawing.Size(123, 23);
            this.ClearServers.TabIndex = 2;
            this.ClearServers.Text = "Clear Saved Servers";
            this.ClearServers.UseVisualStyleBackColor = true;
            this.ClearServers.Click += new System.EventHandler(this.ClearServers_Clicked);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 308);
            this.Controls.Add(this.ServerListSettings);
            this.Controls.Add(this.DiscordSettings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.Text = "Settings";
            this.DiscordSettings.ResumeLayout(false);
            this.DiscordSettings.PerformLayout();
            this.ServerListSettings.ResumeLayout(false);
            this.ServerListSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox DiscordSettings;
        private CheckBox Discord;
        private CheckBox ShowServer;
        private GroupBox ServerListSettings;
        private Button AddServer;
        private TextBox ServerHost;
        private Button ClearServers;
    }
}
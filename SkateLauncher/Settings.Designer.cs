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
            this.ClearServers = new System.Windows.Forms.Button();
            this.AddServer = new System.Windows.Forms.Button();
            this.ServerHost = new System.Windows.Forms.TextBox();
            this.GameSettings = new System.Windows.Forms.GroupBox();
            this.UseProxy = new System.Windows.Forms.CheckBox();
            this.DebugRender = new System.Windows.Forms.CheckBox();
            this.ForceDX11 = new System.Windows.Forms.CheckBox();
            this.UseVulkan = new System.Windows.Forms.CheckBox();
            this.DiscordSettings.SuspendLayout();
            this.ServerListSettings.SuspendLayout();
            this.GameSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // DiscordSettings
            // 
            this.DiscordSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DiscordSettings.AutoSize = true;
            this.DiscordSettings.Controls.Add(this.Discord);
            this.DiscordSettings.Controls.Add(this.ShowServer);
            this.DiscordSettings.Location = new System.Drawing.Point(12, 261);
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
            // 
            // ServerListSettings
            // 
            this.ServerListSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerListSettings.AutoSize = true;
            this.ServerListSettings.Controls.Add(this.ClearServers);
            this.ServerListSettings.Controls.Add(this.AddServer);
            this.ServerListSettings.Controls.Add(this.ServerHost);
            this.ServerListSettings.Location = new System.Drawing.Point(12, 159);
            this.ServerListSettings.Name = "ServerListSettings";
            this.ServerListSettings.Size = new System.Drawing.Size(251, 96);
            this.ServerListSettings.TabIndex = 1;
            this.ServerListSettings.TabStop = false;
            this.ServerListSettings.Text = "Servers";
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
            // ServerHost
            // 
            this.ServerHost.Location = new System.Drawing.Point(6, 22);
            this.ServerHost.Name = "ServerHost";
            this.ServerHost.PlaceholderText = "0.0.0.0";
            this.ServerHost.Size = new System.Drawing.Size(158, 23);
            this.ServerHost.TabIndex = 0;
            // 
            // GameSettings
            // 
            this.GameSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GameSettings.AutoSize = true;
            this.GameSettings.Controls.Add(this.UseProxy);
            this.GameSettings.Controls.Add(this.DebugRender);
            this.GameSettings.Controls.Add(this.ForceDX11);
            this.GameSettings.Controls.Add(this.UseVulkan);
            this.GameSettings.Location = new System.Drawing.Point(12, 12);
            this.GameSettings.Name = "GameSettings";
            this.GameSettings.Size = new System.Drawing.Size(245, 141);
            this.GameSettings.TabIndex = 2;
            this.GameSettings.TabStop = false;
            this.GameSettings.Text = "Game";
            // 
            // UseProxy
            // 
            this.UseProxy.AutoSize = true;
            this.UseProxy.Location = new System.Drawing.Point(6, 97);
            this.UseProxy.Name = "UseProxy";
            this.UseProxy.Size = new System.Drawing.Size(168, 19);
            this.UseProxy.TabIndex = 3;
            this.UseProxy.Text = "Use Proxy for Server [BETA]";
            this.UseProxy.UseVisualStyleBackColor = true;
            this.UseProxy.Visible = false;
            // 
            // DebugRender
            // 
            this.DebugRender.AutoSize = true;
            this.DebugRender.Location = new System.Drawing.Point(6, 72);
            this.DebugRender.Name = "DebugRender";
            this.DebugRender.Size = new System.Drawing.Size(156, 19);
            this.DebugRender.TabIndex = 2;
            this.DebugRender.Text = "Enable Debug Rendering";
            this.DebugRender.UseVisualStyleBackColor = true;
            // 
            // ForceDX11
            // 
            this.ForceDX11.AutoSize = true;
            this.ForceDX11.Checked = true;
            this.ForceDX11.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ForceDX11.Location = new System.Drawing.Point(6, 47);
            this.ForceDX11.Name = "ForceDX11";
            this.ForceDX11.Size = new System.Drawing.Size(108, 19);
            this.ForceDX11.TabIndex = 1;
            this.ForceDX11.Text = "Force DirectX11";
            this.ForceDX11.UseVisualStyleBackColor = true;
            // 
            // UseVulkan
            // 
            this.UseVulkan.AutoSize = true;
            this.UseVulkan.Checked = true;
            this.UseVulkan.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UseVulkan.Location = new System.Drawing.Point(6, 22);
            this.UseVulkan.Name = "UseVulkan";
            this.UseVulkan.Size = new System.Drawing.Size(84, 19);
            this.UseVulkan.TabIndex = 0;
            this.UseVulkan.Text = "Use Vulkan";
            this.UseVulkan.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 361);
            this.Controls.Add(this.GameSettings);
            this.Controls.Add(this.ServerListSettings);
            this.Controls.Add(this.DiscordSettings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SaveSettings);
            this.DiscordSettings.ResumeLayout(false);
            this.DiscordSettings.PerformLayout();
            this.ServerListSettings.ResumeLayout(false);
            this.ServerListSettings.PerformLayout();
            this.GameSettings.ResumeLayout(false);
            this.GameSettings.PerformLayout();
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
        private GroupBox GameSettings;
        private CheckBox UseVulkan;
        private CheckBox DebugRender;
        private CheckBox ForceDX11;
        private CheckBox UseProxy;
    }
}
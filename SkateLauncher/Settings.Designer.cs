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
            this.UseProxy = new System.Windows.Forms.CheckBox();
            this.ClearServers = new System.Windows.Forms.Button();
            this.AddServer = new System.Windows.Forms.Button();
            this.ServerHost = new System.Windows.Forms.TextBox();
            this.GameSettings = new System.Windows.Forms.GroupBox();
            this.AiSkatersTooltip = new System.Windows.Forms.Label();
            this.AiSkaters = new System.Windows.Forms.NumericUpDown();
            this.DisableTutorial = new System.Windows.Forms.CheckBox();
            this.Shirtless = new System.Windows.Forms.CheckBox();
            this.Fullscreen = new System.Windows.Forms.CheckBox();
            this.DebugRender = new System.Windows.Forms.CheckBox();
            this.ForceDX11 = new System.Windows.Forms.CheckBox();
            this.UseVulkan = new System.Windows.Forms.CheckBox();
            this.CosmeticsBuildKit = new System.Windows.Forms.CheckBox();
            this.DisableWatermark = new System.Windows.Forms.CheckBox();
            this.DiscordSettings.SuspendLayout();
            this.ServerListSettings.SuspendLayout();
            this.GameSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AiSkaters)).BeginInit();
            this.SuspendLayout();
            // 
            // DiscordSettings
            // 
            this.DiscordSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DiscordSettings.AutoSize = true;
            this.DiscordSettings.Controls.Add(this.Discord);
            this.DiscordSettings.Controls.Add(this.ShowServer);
            this.DiscordSettings.Location = new System.Drawing.Point(12, 311);
            this.DiscordSettings.Name = "DiscordSettings";
            this.DiscordSettings.Size = new System.Drawing.Size(410, 88);
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
            this.ServerListSettings.Controls.Add(this.UseProxy);
            this.ServerListSettings.Controls.Add(this.ClearServers);
            this.ServerListSettings.Controls.Add(this.AddServer);
            this.ServerListSettings.Controls.Add(this.ServerHost);
            this.ServerListSettings.Location = new System.Drawing.Point(12, 184);
            this.ServerListSettings.Name = "ServerListSettings";
            this.ServerListSettings.Size = new System.Drawing.Size(410, 121);
            this.ServerListSettings.TabIndex = 1;
            this.ServerListSettings.TabStop = false;
            this.ServerListSettings.Text = "Servers";
            // 
            // UseProxy
            // 
            this.UseProxy.AutoSize = true;
            this.UseProxy.Location = new System.Drawing.Point(6, 80);
            this.UseProxy.Name = "UseProxy";
            this.UseProxy.Size = new System.Drawing.Size(168, 19);
            this.UseProxy.TabIndex = 3;
            this.UseProxy.Text = "Use Proxy for Server [BETA]";
            this.UseProxy.UseVisualStyleBackColor = true;
            this.UseProxy.Visible = false;
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
            this.GameSettings.Controls.Add(this.DisableWatermark);
            this.GameSettings.Controls.Add(this.CosmeticsBuildKit);
            this.GameSettings.Controls.Add(this.AiSkatersTooltip);
            this.GameSettings.Controls.Add(this.AiSkaters);
            this.GameSettings.Controls.Add(this.DisableTutorial);
            this.GameSettings.Controls.Add(this.Shirtless);
            this.GameSettings.Controls.Add(this.Fullscreen);
            this.GameSettings.Controls.Add(this.DebugRender);
            this.GameSettings.Controls.Add(this.ForceDX11);
            this.GameSettings.Controls.Add(this.UseVulkan);
            this.GameSettings.Location = new System.Drawing.Point(12, 12);
            this.GameSettings.Name = "GameSettings";
            this.GameSettings.Size = new System.Drawing.Size(404, 166);
            this.GameSettings.TabIndex = 2;
            this.GameSettings.TabStop = false;
            this.GameSettings.Text = "Game";
            // 
            // AiSkatersTooltip
            // 
            this.AiSkatersTooltip.AutoSize = true;
            this.AiSkatersTooltip.Location = new System.Drawing.Point(162, 73);
            this.AiSkatersTooltip.Name = "AiSkatersTooltip";
            this.AiSkatersTooltip.Size = new System.Drawing.Size(119, 15);
            this.AiSkatersTooltip.TabIndex = 8;
            this.AiSkatersTooltip.Text = "Number of AI Skaters";
            // 
            // AiSkaters
            // 
            this.AiSkaters.Location = new System.Drawing.Point(162, 91);
            this.AiSkaters.Name = "AiSkaters";
            this.AiSkaters.Size = new System.Drawing.Size(80, 23);
            this.AiSkaters.TabIndex = 7;
            // 
            // DisableTutorial
            // 
            this.DisableTutorial.AutoSize = true;
            this.DisableTutorial.Location = new System.Drawing.Point(162, 122);
            this.DisableTutorial.Name = "DisableTutorial";
            this.DisableTutorial.Size = new System.Drawing.Size(107, 19);
            this.DisableTutorial.TabIndex = 6;
            this.DisableTutorial.Text = "Disable Tutorial";
            this.DisableTutorial.UseVisualStyleBackColor = true;
            // 
            // Shirtless
            // 
            this.Shirtless.AutoSize = true;
            this.Shirtless.Location = new System.Drawing.Point(162, 47);
            this.Shirtless.Name = "Shirtless";
            this.Shirtless.Size = new System.Drawing.Size(69, 19);
            this.Shirtless.TabIndex = 5;
            this.Shirtless.Text = "Shirtless";
            this.Shirtless.UseVisualStyleBackColor = true;
            // 
            // Fullscreen
            // 
            this.Fullscreen.AutoSize = true;
            this.Fullscreen.Location = new System.Drawing.Point(6, 97);
            this.Fullscreen.Name = "Fullscreen";
            this.Fullscreen.Size = new System.Drawing.Size(79, 19);
            this.Fullscreen.TabIndex = 3;
            this.Fullscreen.Text = "Fullscreen";
            this.Fullscreen.UseVisualStyleBackColor = true;
            // 
            // DebugRender
            // 
            this.DebugRender.AutoSize = true;
            this.DebugRender.Location = new System.Drawing.Point(6, 72);
            this.DebugRender.Name = "DebugRender";
            this.DebugRender.Size = new System.Drawing.Size(99, 19);
            this.DebugRender.TabIndex = 2;
            this.DebugRender.Text = "Enable Debug";
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
            // CosmeticsBuildKit
            // 
            this.CosmeticsBuildKit.AutoSize = true;
            this.CosmeticsBuildKit.Checked = true;
            this.CosmeticsBuildKit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CosmeticsBuildKit.Location = new System.Drawing.Point(162, 22);
            this.CosmeticsBuildKit.Name = "CosmeticsBuildKit";
            this.CosmeticsBuildKit.Size = new System.Drawing.Size(177, 19);
            this.CosmeticsBuildKit.TabIndex = 9;
            this.CosmeticsBuildKit.Text = "Enable Cosmetics + Build Kit";
            this.CosmeticsBuildKit.UseVisualStyleBackColor = true;
            // 
            // DisableWatermark
            // 
            this.DisableWatermark.AutoSize = true;
            this.DisableWatermark.Checked = true;
            this.DisableWatermark.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DisableWatermark.Location = new System.Drawing.Point(6, 122);
            this.DisableWatermark.Name = "DisableWatermark";
            this.DisableWatermark.Size = new System.Drawing.Size(125, 19);
            this.DisableWatermark.TabIndex = 10;
            this.DisableWatermark.Text = "Disable Watermark";
            this.DisableWatermark.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 411);
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
            ((System.ComponentModel.ISupportInitialize)(this.AiSkaters)).EndInit();
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
        private CheckBox Fullscreen;
        private CheckBox Shirtless;
        private Label AiSkatersTooltip;
        private NumericUpDown AiSkaters;
        private CheckBox DisableTutorial;
        private CheckBox CosmeticsBuildKit;
        private CheckBox DisableWatermark;
    }
}
namespace SkateLauncher
{
    partial class Launcher
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launcher));
            this.OnlineServers = new System.Windows.Forms.ListBox();
            this.LaunchButton = new System.Windows.Forms.Button();
            this.Developers = new System.Windows.Forms.Label();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.Browse = new System.Windows.Forms.Button();
            this.Username = new System.Windows.Forms.TextBox();
            this.SelectGame = new System.Windows.Forms.OpenFileDialog();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.GamePath = new System.Windows.Forms.TextBox();
            this.AddLaunchArgs = new System.Windows.Forms.TextBox();
            this.Online = new System.Windows.Forms.CheckBox();
            this.SelectedServerList = new System.Windows.Forms.ComboBox();
            this.LaunchServer = new System.Windows.Forms.Button();
            this.OnlineOptionsGroup = new System.Windows.Forms.GroupBox();
            this.SettingsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.OnlineOptionsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // OnlineServers
            // 
            this.OnlineServers.BackColor = System.Drawing.SystemColors.Window;
            this.OnlineServers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OnlineServers.ForeColor = System.Drawing.SystemColors.WindowText;
            this.OnlineServers.FormattingEnabled = true;
            this.OnlineServers.ItemHeight = 25;
            this.OnlineServers.Location = new System.Drawing.Point(13, 53);
            this.OnlineServers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.OnlineServers.Name = "OnlineServers";
            this.OnlineServers.Size = new System.Drawing.Size(278, 454);
            this.OnlineServers.TabIndex = 0;
            this.OnlineServers.SelectedIndexChanged += new System.EventHandler(this.SelectedServer_Changed);
            // 
            // LaunchButton
            // 
            this.LaunchButton.BackColor = System.Drawing.SystemColors.Window;
            this.LaunchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LaunchButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LaunchButton.Location = new System.Drawing.Point(515, 394);
            this.LaunchButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LaunchButton.Name = "LaunchButton";
            this.LaunchButton.Size = new System.Drawing.Size(200, 53);
            this.LaunchButton.TabIndex = 1;
            this.LaunchButton.Text = "Launch Game";
            this.LaunchButton.UseVisualStyleBackColor = false;
            this.LaunchButton.Click += new System.EventHandler(this.Launch);
            // 
            // Developers
            // 
            this.Developers.AutoSize = true;
            this.Developers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Developers.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Developers.Location = new System.Drawing.Point(663, 494);
            this.Developers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Developers.Name = "Developers";
            this.Developers.Size = new System.Drawing.Size(257, 13);
            this.Developers.TabIndex = 4;
            this.Developers.Text = "Launcher by Xtract, Multiplayer by Crunnie and Crush";
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.SystemColors.Window;
            this.RefreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RefreshButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.RefreshButton.Location = new System.Drawing.Point(205, 14);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(88, 23);
            this.RefreshButton.TabIndex = 7;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // Browse
            // 
            this.Browse.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Browse.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Browse.Location = new System.Drawing.Point(533, 480);
            this.Browse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(98, 27);
            this.Browse.TabIndex = 9;
            this.Browse.Text = "Browse...";
            this.Browse.UseVisualStyleBackColor = false;
            this.Browse.Click += new System.EventHandler(this.OpenBrowser);
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.SystemColors.Window;
            this.Username.Enabled = false;
            this.Username.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Username.Location = new System.Drawing.Point(7, 47);
            this.Username.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Username.MaxLength = 16;
            this.Username.Name = "Username";
            this.Username.PlaceholderText = "Username";
            this.Username.Size = new System.Drawing.Size(91, 23);
            this.Username.TabIndex = 10;
            this.Username.TextChanged += new System.EventHandler(this.Username_Changed);
            // 
            // SelectGame
            // 
            this.SelectGame.Filter = "Executable Files|*.exe";
            // 
            // Logo
            // 
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(365, 39);
            this.Logo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(500, 175);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 14;
            this.Logo.TabStop = false;
            // 
            // Address
            // 
            this.Address.BackColor = System.Drawing.SystemColors.Window;
            this.Address.Enabled = false;
            this.Address.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Address.Location = new System.Drawing.Point(7, 76);
            this.Address.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Address.Name = "Address";
            this.Address.PlaceholderText = "Server Address";
            this.Address.Size = new System.Drawing.Size(91, 23);
            this.Address.TabIndex = 16;
            this.Address.Text = "127.0.0.1";
            // 
            // GamePath
            // 
            this.GamePath.BackColor = System.Drawing.SystemColors.Window;
            this.GamePath.Enabled = false;
            this.GamePath.ForeColor = System.Drawing.SystemColors.WindowText;
            this.GamePath.Location = new System.Drawing.Point(300, 483);
            this.GamePath.Name = "GamePath";
            this.GamePath.PlaceholderText = "Game Executable Path";
            this.GamePath.Size = new System.Drawing.Size(226, 23);
            this.GamePath.TabIndex = 18;
            // 
            // AddLaunchArgs
            // 
            this.AddLaunchArgs.Location = new System.Drawing.Point(515, 334);
            this.AddLaunchArgs.Name = "AddLaunchArgs";
            this.AddLaunchArgs.PlaceholderText = "Additional Launch Args";
            this.AddLaunchArgs.Size = new System.Drawing.Size(200, 23);
            this.AddLaunchArgs.TabIndex = 19;
            this.AddLaunchArgs.TextChanged += new System.EventHandler(this.LaunchArgs_Changed);
            // 
            // Online
            // 
            this.Online.AutoSize = true;
            this.Online.BackColor = System.Drawing.SystemColors.Menu;
            this.Online.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Online.Location = new System.Drawing.Point(7, 22);
            this.Online.Name = "Online";
            this.Online.Size = new System.Drawing.Size(86, 19);
            this.Online.TabIndex = 20;
            this.Online.Text = "Play Online";
            this.Online.UseVisualStyleBackColor = false;
            this.Online.CheckedChanged += new System.EventHandler(this.Online_Changed);
            // 
            // SelectedServerList
            // 
            this.SelectedServerList.FormattingEnabled = true;
            this.SelectedServerList.Items.AddRange(new object[] {
            "skate.online",
            "Saved"});
            this.SelectedServerList.Location = new System.Drawing.Point(15, 14);
            this.SelectedServerList.Name = "SelectedServerList";
            this.SelectedServerList.Size = new System.Drawing.Size(183, 23);
            this.SelectedServerList.TabIndex = 22;
            this.SelectedServerList.SelectedIndexChanged += new System.EventHandler(this.SelectedServerList_Changed);
            // 
            // LaunchServer
            // 
            this.LaunchServer.BackColor = System.Drawing.SystemColors.Window;
            this.LaunchServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LaunchServer.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LaunchServer.Location = new System.Drawing.Point(515, 363);
            this.LaunchServer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LaunchServer.Name = "LaunchServer";
            this.LaunchServer.Size = new System.Drawing.Size(200, 25);
            this.LaunchServer.TabIndex = 23;
            this.LaunchServer.Text = "Launch Server";
            this.LaunchServer.UseVisualStyleBackColor = false;
            this.LaunchServer.Click += new System.EventHandler(this.Launch_Server);
            // 
            // OnlineOptionsGroup
            // 
            this.OnlineOptionsGroup.Controls.Add(this.Address);
            this.OnlineOptionsGroup.Controls.Add(this.Online);
            this.OnlineOptionsGroup.Controls.Add(this.Username);
            this.OnlineOptionsGroup.Location = new System.Drawing.Point(563, 220);
            this.OnlineOptionsGroup.Name = "OnlineOptionsGroup";
            this.OnlineOptionsGroup.Size = new System.Drawing.Size(108, 108);
            this.OnlineOptionsGroup.TabIndex = 25;
            this.OnlineOptionsGroup.TabStop = false;
            this.OnlineOptionsGroup.Text = "Online Options";
            // 
            // SettingsButton
            // 
            this.SettingsButton.Location = new System.Drawing.Point(846, 12);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(75, 23);
            this.SettingsButton.TabIndex = 26;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.OpenSettings);
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.OnlineOptionsGroup);
            this.Controls.Add(this.LaunchServer);
            this.Controls.Add(this.SelectedServerList);
            this.Controls.Add(this.AddLaunchArgs);
            this.Controls.Add(this.GamePath);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.Developers);
            this.Controls.Add(this.LaunchButton);
            this.Controls.Add(this.OnlineServers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Launcher";
            this.Text = "Skate. Launcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Launcher_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.OnlineOptionsGroup.ResumeLayout(false);
            this.OnlineOptionsGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private System.Windows.Forms.ListBox OnlineServers;
        private System.Windows.Forms.Button LaunchButton;
        private System.Windows.Forms.Label Developers;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.OpenFileDialog SelectGame;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.TextBox Address;
        private TextBox GamePath;
        private TextBox AddLaunchArgs;
        private CheckBox Online;
        private ComboBox SelectedServerList;
        private Button LaunchServer;
        private GroupBox OnlineOptionsGroup;
        private Button SettingsButton;
    }
}
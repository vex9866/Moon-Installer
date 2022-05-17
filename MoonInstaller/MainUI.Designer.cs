namespace MoonInstaller
{
    partial class MainUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            this.ColorTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.InstallButton = new System.Windows.Forms.Button();
            this.ZIPButton = new System.Windows.Forms.Button();
            this.RepairButton = new System.Windows.Forms.Button();
            this.DiscordButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ColorTimer
            // 
            this.ColorTimer.Enabled = true;
            this.ColorTimer.Interval = 7;
            this.ColorTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.DiscordButton);
            this.panel1.Controls.Add(this.RepairButton);
            this.panel1.Controls.Add(this.ZIPButton);
            this.panel1.Controls.Add(this.InstallButton);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 440);
            this.panel1.TabIndex = 0;
            // 
            // InstallButton
            // 
            this.InstallButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InstallButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstallButton.ForeColor = System.Drawing.Color.BlueViolet;
            this.InstallButton.Location = new System.Drawing.Point(9, 373);
            this.InstallButton.Name = "InstallButton";
            this.InstallButton.Size = new System.Drawing.Size(207, 59);
            this.InstallButton.TabIndex = 0;
            this.InstallButton.Text = "INSTALL";
            this.InstallButton.UseVisualStyleBackColor = true;
            this.InstallButton.Click += new System.EventHandler(this.InstallButton_Click);
            // 
            // ZIPButton
            // 
            this.ZIPButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZIPButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZIPButton.ForeColor = System.Drawing.Color.BlueViolet;
            this.ZIPButton.Location = new System.Drawing.Point(222, 373);
            this.ZIPButton.Name = "ZIPButton";
            this.ZIPButton.Size = new System.Drawing.Size(207, 59);
            this.ZIPButton.TabIndex = 1;
            this.ZIPButton.Text = "ZIP";
            this.ZIPButton.UseVisualStyleBackColor = true;
            this.ZIPButton.Click += new System.EventHandler(this.ZIPButton_Click);
            // 
            // RepairButton
            // 
            this.RepairButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RepairButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepairButton.ForeColor = System.Drawing.Color.BlueViolet;
            this.RepairButton.Location = new System.Drawing.Point(435, 373);
            this.RepairButton.Name = "RepairButton";
            this.RepairButton.Size = new System.Drawing.Size(201, 59);
            this.RepairButton.TabIndex = 2;
            this.RepairButton.Text = "REPAIR / UNINSTALL";
            this.RepairButton.UseVisualStyleBackColor = true;
            this.RepairButton.Click += new System.EventHandler(this.RepairButton_Click);
            // 
            // DiscordButton
            // 
            this.DiscordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DiscordButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscordButton.ForeColor = System.Drawing.Color.BlueViolet;
            this.DiscordButton.Location = new System.Drawing.Point(642, 373);
            this.DiscordButton.Name = "DiscordButton";
            this.DiscordButton.Size = new System.Drawing.Size(140, 59);
            this.DiscordButton.TabIndex = 3;
            this.DiscordButton.Text = "DISCORD";
            this.DiscordButton.UseVisualStyleBackColor = true;
            this.DiscordButton.Click += new System.EventHandler(this.DiscordButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(9, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(773, 367);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(797, 448);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Moonlight Installer";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer ColorTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button InstallButton;
        private System.Windows.Forms.Button DiscordButton;
        private System.Windows.Forms.Button RepairButton;
        private System.Windows.Forms.Button ZIPButton;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}


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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.DiscordButton = new System.Windows.Forms.Button();
            this.RepairButton = new System.Windows.Forms.Button();
            this.ZIPButton = new System.Windows.Forms.Button();
            this.InstallButton = new System.Windows.Forms.Button();
            this.VRCDirLabel = new System.Windows.Forms.Label();
            this.DirectBox = new System.Windows.Forms.TextBox();
            this.LocationSelect = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.LocationSelect);
            this.panel1.Controls.Add(this.DirectBox);
            this.panel1.Controls.Add(this.VRCDirLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.DiscordButton);
            this.panel1.Controls.Add(this.RepairButton);
            this.panel1.Controls.Add(this.ZIPButton);
            this.panel1.Controls.Add(this.InstallButton);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 440);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainUI_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainUI_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.BlueViolet;
            this.label2.Location = new System.Drawing.Point(733, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "-";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.BlueViolet;
            this.label1.Location = new System.Drawing.Point(759, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainUI_MouseDown);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainUI_MouseMove);
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
            // VRCDirLabel
            // 
            this.VRCDirLabel.AutoSize = true;
            this.VRCDirLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VRCDirLabel.ForeColor = System.Drawing.Color.BlueViolet;
            this.VRCDirLabel.Location = new System.Drawing.Point(9, 340);
            this.VRCDirLabel.Name = "VRCDirLabel";
            this.VRCDirLabel.Size = new System.Drawing.Size(120, 30);
            this.VRCDirLabel.TabIndex = 8;
            this.VRCDirLabel.Text = "VRChat Dir:";
            this.VRCDirLabel.Click += new System.EventHandler(this.VRCDirLabel_Click);
            // 
            // DirectBox
            // 
            this.DirectBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.DirectBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DirectBox.ForeColor = System.Drawing.Color.BlueViolet;
            this.DirectBox.Location = new System.Drawing.Point(135, 347);
            this.DirectBox.Name = "DirectBox";
            this.DirectBox.Size = new System.Drawing.Size(338, 20);
            this.DirectBox.TabIndex = 9;
            this.DirectBox.Text = "Select Your game folder!";
            // 
            // LocationSelect
            // 
            this.LocationSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LocationSelect.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationSelect.ForeColor = System.Drawing.Color.BlueViolet;
            this.LocationSelect.Location = new System.Drawing.Point(479, 347);
            this.LocationSelect.Name = "LocationSelect";
            this.LocationSelect.Size = new System.Drawing.Size(43, 20);
            this.LocationSelect.TabIndex = 10;
            this.LocationSelect.Text = "...";
            this.LocationSelect.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LocationSelect.UseVisualStyleBackColor = true;
            this.LocationSelect.Click += new System.EventHandler(this.LocationSelect_Click);
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
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainUI_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainUI_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LocationSelect;
        private System.Windows.Forms.TextBox DirectBox;
        private System.Windows.Forms.Label VRCDirLabel;
    }
}


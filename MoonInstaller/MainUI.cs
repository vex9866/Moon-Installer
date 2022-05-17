using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace MoonInstaller
{
    public partial class MainUI : Form
    {
        public string moonurl = "https://moonlightapi.000webhostapp.com/update/Moonlight.dll";
        public string moonloaderurl = "https://cdn.discordapp.com/attachments/950477641088118784/975964809969426462/MoonLoader.dll";
        public string moonpatchurl = "https://moonlightapi.000webhostapp.com/update/MoonlightPatcher.dll";
        public string moonzipurl = "https://moonlightapi.000webhostapp.com/update/Client.zip";

        //Random R = new Random();
        Point lastPoint;

        public MainUI()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //This looks ugly lmao I'm never gonna use this
            //this.BackColor = Color.FromArgb(R.Next(0, 255), R.Next(0, 255), R.Next(0, 255));
            //this.BackColor = Color.FromArgb(R.Next(0, 255), 255, R.Next(0, 255));
        }

        private void InstallButton_Click(object sender, EventArgs e)
        {
            string folderlocation = DirectBox.Text;

            string message = "Do you want to Install the client?";
            string title = "MOON INSTALLER";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                if(folderlocation == "")
                {
                    MessageBox.Show("Please select your vrchat folder!", "MOON INSTALLER");
                }
                else
                {
                    if (!File.Exists($"{folderlocation}\\Mods\\Moonlight.dll"))
                    {
                        var wc = new WebClient();
                        var bytes = wc.DownloadData(moonurl);
                        File.Create($"{folderlocation}\\Mods\\Moonlight.dll").Close();
                        File.WriteAllBytes($"{folderlocation}\\Mods\\Moonlight.dll", bytes);
                    }
                    else
                    {
                        MessageBox.Show("Moonlight already exists!", "MOON INSTALLER");
                    }

                    if (!File.Exists($"{folderlocation}\\Plugins\\MoonlightPatcher.dll"))
                    {
                        var wc = new WebClient();
                        var bytes = wc.DownloadData(moonpatchurl);
                        File.Create($"{folderlocation}\\Plugins\\MoonlightPatcher.dll").Close();
                        File.WriteAllBytes($"{folderlocation}\\Plugins\\MoonlightPatcher.dll", bytes);
                    }
                    else
                    {
                        MessageBox.Show("Moonlight's patcher already exists!", "MOON INSTALLER");
                    }

                    if (!File.Exists($"{folderlocation}\\Plugins\\MoonLoader.dll"))
                    {
                        var wc = new WebClient();
                        var bytes = wc.DownloadData(moonloaderurl);
                        File.Create($"{folderlocation}\\Plugins\\MoonLoader.dll").Close();
                        File.WriteAllBytes($"{folderlocation}\\Plugins\\MoonLoader.dll", bytes);
                    }
                    else
                    {
                        MessageBox.Show("Moonlight's patcher already exists!", "MOON INSTALLER");
                    }
                }
            }
            else
            {
                //Just closes message box lol
            }
        }

        private void ZIPButton_Click(object sender, EventArgs e)
        {
            string message = "This is for manual Installation. Are you sure you want to install it on your own? (The .ZIP file will be loaded in the 'Dropper' folder)";
            string title = "MOON INSTALLER";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                var wc = new WebClient();
                var bytes = wc.DownloadData(moonzipurl);
                File.Create(@"\\Dropper\\Client.zip").Close();
                File.WriteAllBytes(@"\\Dropper\\Client.zip", bytes);
            }
            else
            {
                //Nothing
            }
        }

        private void RepairButton_Click(object sender, EventArgs e)
        {
            string folderlocation = DirectBox.Text;

            bool repair = false;
            string message = "This process will proceed to check if Moonlight's DLLs have been changed / altered in anyway and will try its best to fix it. Do you wish to continue?";
            string title = "MOON INSTALLER";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                if (folderlocation == "")
                {
                    MessageBox.Show("Please select your vrchat folder!", "MOON INSTALLER");
                }
                else
                {
                    if (repair == true)
                    {
                        //repair shit
                    }

                    if (File.Exists($"{folderlocation}\\Mods\\Moonlight.dll"))
                    {
                        File.Delete($"{folderlocation}\\Mods\\Moonlight.dll");
                    }

                    if (File.Exists($"{folderlocation}\\Plugins\\MoonlightPatcher.dll"))
                    {
                        File.Delete($"{folderlocation}\\Plugins\\MoonlightPatcher.dll");
                    }

                    if (File.Exists($"{folderlocation}\\Plugins\\MoonLoader.dll"))
                    {
                        File.Delete($"{folderlocation}\\Plugins\\MoonLoader.dll");
                    }

                    if (Directory.Exists($"{folderlocation}\\MoonlightClient"))
                    {
                        Directory.Delete($"{folderlocation}\\MoonlightClient");
                    }
                }
            }
            else
            {
                MessageBox.Show("Process has been cancelled");
            }
        }

        private void DiscordButton_Click(object sender, EventArgs e)
        {
            string message = "Do you want to be redirected to my website?";
            string title = "MOON INSTALLER";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Process.Start("https://scopes-stuff.ga/moonlight/discord.txt");
            }
            else
            {
                //Nothing
            }
        }

        private void MainUI_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void MainUI_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void VRCDirLabel_Click(object sender, EventArgs e)
        {

        }

        private void LocationSelect_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dlg = new CommonOpenFileDialog();
            dlg.IsFolderPicker = true;
            if (dlg.ShowDialog() == CommonFileDialogResult.Ok)
            {
                DirectBox.Text = dlg.FileName;
            }
        }
    }
}

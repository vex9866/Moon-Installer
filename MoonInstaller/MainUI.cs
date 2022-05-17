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
using MelonLoader;
using System.Diagnostics;

namespace MoonInstaller
{
    public partial class MainUI : Form
    {
        //Random R = new Random();

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
            string message = "Do you want to Install the client?";
            string title = "MOON INSTALLER";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                if (!File.Exists($"{MelonUtils.GameDirectory}\\Mods\\Moonlight.dll"))
                {
                    var wc = new WebClient();
                    wc.DownloadFile("https://moonlightapi.000webhostapp.com/update/Moonlight.dll", $"{MelonUtils.GameDirectory}\\Mods\\Moonlight.dll");
                }
                else
                {
                    MessageBox.Show("Moonlight already exists!","MOON INSTALLER");
                }

                if (!File.Exists($"{MelonUtils.GameDirectory}\\Plugins\\MoonlightPatcher.dll"))
                {
                    var wc = new WebClient();
                    wc.DownloadFile("https://moonlightapi.000webhostapp.com/update/MoonlightPatcher.dll", $"{MelonUtils.GameDirectory}\\Mods\\Moonlight.dll");
                }
                else
                {
                    MessageBox.Show("Moonlight's patcher already exists!", "MOON INSTALLER");
                }

                if (!File.Exists($"{MelonUtils.GameDirectory}\\Plugins\\MoonLoader.dll"))
                {
                    var wc = new WebClient();
                    wc.DownloadFile("https://cdn.discordapp.com/attachments/950477641088118784/975964809969426462/MoonLoader.dll", $"{MelonUtils.GameDirectory}\\Mods\\Moonlight.dll");
                }
                else
                {
                    MessageBox.Show("Moonlight's patcher already exists!", "MOON INSTALLER");
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
                wc.DownloadFile("https://moonlightapi.000webhostapp.com/update/Client.zip", $"Dropper\\Client.zip");
            }
            else
            {
                //Nothing
            }
        }

        private void RepairButton_Click(object sender, EventArgs e)
        {
            bool repair = false;
            string message = "This process will proceed to check if Moonlight's DLLs have been changed / altered in anyway and will try its best to fix it. Do you wish to continue?";
            string title = "MOON INSTALLER";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                if(repair == true)
                {
                    //repair shit
                }

                if (File.Exists($"{MelonUtils.GameDirectory}\\Mods\\Moonlight.dll"))
                {
                    File.Delete($"{MelonUtils.GameDirectory}\\Plugins\\Moonlight.dll");
                }

                if (File.Exists($"{MelonUtils.GameDirectory}\\Plugins\\MoonlightPatcher.dll"))
                {
                    File.Delete($"{MelonUtils.GameDirectory}\\Plugins\\MoonlightPatcher.dll");
                }

                if (File.Exists($"{MelonUtils.GameDirectory}\\Plugins\\MoonLoader.dll"))
                {
                    File.Delete($"{MelonUtils.GameDirectory}\\Plugins\\MoonLoader.dll");
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
    }
}

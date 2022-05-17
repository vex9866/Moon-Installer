using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            //this.BackColor = Color.FromArgb(R.Next(0, 255), R.Next(0, 255), R.Next(0, 255));
            //this.BackColor = Color.FromArgb(R.Next(0, 255), 255, R.Next(0, 255));
        }
    }
}

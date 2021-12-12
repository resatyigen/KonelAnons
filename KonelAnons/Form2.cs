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

namespace KonelAnons
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process[] processList = Process.GetProcesses();
            var list = processList.Where(x => x.ProcessName == "Spotify");

            foreach (var th in list)
            {
                //var vol = AudioManager.GetApplicationVolume(th.Id);
                AudioManager.SetApplicationMute(th.Id, true);
            }


            
        }
    }
}

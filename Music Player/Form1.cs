using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnPlay.Text = "4";
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (btnPlay.Text == "4") // playing
            {
                MediaPlayer.Ctlcontrols.play();
                btnPlay.Text = ";";
            }
            else if (btnPlay.Text == ";") // paused
            {
                MediaPlayer.Ctlcontrols.pause();
                btnPlay.Text = "4";
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            MediaPlayer.Ctlcontrols.stop();

        }

        private void chkbReplay_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbReplay.Checked == true)
            {
                MediaPlayer.settings.setMode("loop", true);
            }
            else if (chkbReplay.Checked == false)
            {
                MediaPlayer.settings.setMode("loop", false);
            }

            if (MediaPlayer.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                MediaPlayer.Ctlcontrols.play();
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtbLocation.Text = openFileDialog1.FileName;
            }

            MediaPlayer.URL = txtbLocation.Text;

            btnPlay.Text = ";";
        }
    }
}

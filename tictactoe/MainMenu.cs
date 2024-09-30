using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace tictactoe
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private static WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();

        public static WMPLib.WindowsMediaPlayer getplayer
        {
            get { return player; }
            set { player = value; } 
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            player.URL = @"C:\Users\LENOVO\Desktop\tictactoe\tictactoe\Resources\ticresources\BG Music\Background.mp3";
            player.controls.play();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
            this.Hide();
        }

        int timer = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer > 0)
            {
                timer = timer - 1;
            }
            else
            {
                timer1.Stop();
                pictureBox1.Visible = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quit Game?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                player.controls.stop();

                GIF2 g = new GIF2();
                g.Show();
                this.Hide();
            }
        }
    }
}

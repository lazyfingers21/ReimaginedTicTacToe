using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class Mode : Form
    {
        public Mode()
        {
            InitializeComponent();
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            if (Array.increment2 == 0)
            {
                MessageBox.Show("Play Easy Mode first to unlock Average Mode!", "Average");
            }
            else if (Array.increment2 != 0)
            {
                Form1 frm1 = new Form1();
                frm1.Show();
                this.Hide();
            }
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            if (Array.increment3 == 0)
            {
                MessageBox.Show("Play Average Mode first to unlock Hard Mode!", "Hard");
            }
            else if (Array.increment3 != 0)
            {
                Form3 frm3 = new Form3();
                frm3.Show();
                this.Hide();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenu m = new MainMenu();
            m.Show();
            this.Hide();
        }

        private void Mode_Load(object sender, EventArgs e)
        {
            MainMenu.getplayer.controls.play();
            Form1.getplayer.controls.stop();
            Form2.getplayer.controls.stop();
            Form3.getplayer.controls.stop();

            if (Array.increment2 == 0)
            {
                btnAverage.BackColor = Color.SaddleBrown;
            }
            if (Array.increment3 == 0)
            {
                btnHard.BackColor = Color.SaddleBrown;
            }

        }

        private void btnLeaderBoard_Click(object sender, EventArgs e)
        {
            Leaderboard l = new Leaderboard();
            l.Show();
            this.Hide();
        }

        private void btnCredits_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This game is developed by: \n\n-Jexter Jay A. Abrantes\n-Crissha P. Bayhonan\n\nBSInfoTech(Programming) 2-F\n\nCopyright ©2019", "Credits");
        }

    }
}

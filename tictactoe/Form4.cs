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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxPlayer1.Text == "" && textBoxPlayer2.Text == "")
                {
                    MessageBox.Show("Please enter name of players!", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (textBoxPlayer1.Text == textBoxPlayer2.Text)
                {
                    MessageBox.Show("Name of players should not be the same!", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Array.getname[Array.increment] = textBoxPlayer1.Text;
                    Array.increment++;
                    Array.getname[Array.increment] = textBoxPlayer2.Text;
                    Array.increment++;  


                    Mode m = new Mode();
                    m.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            MainMenu.getplayer.controls.play();
            Form1.getplayer.controls.stop();
            Form2.getplayer.controls.stop();
            Form3.getplayer.controls.stop();
        }


    }
}

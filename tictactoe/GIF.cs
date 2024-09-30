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
    public partial class GIF : Form
    {
        public GIF()
        {
            InitializeComponent();
        }

        private void GIF_Load(object sender, EventArgs e)
        {
            rectangleShape2.Width = 10;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (rectangleShape2.Width < 440)
            {
                
                rectangleShape2.Width = rectangleShape2.Width + 10;
            }
            
            else
            {
                timer1.Stop();
                MainMenu m = new MainMenu();
                m.Show();
                this.Hide(); 
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (lblLoading.Text == "Loading...")
            {
                lblLoading.Text = "Loading.";
            }
            else if (lblLoading.Text == "Loading.")
            {
                lblLoading.Text = "Loading..";
            }
            else if (lblLoading.Text == "Loading..")
            {
                lblLoading.Text = "Loading...";
            }

        }
    }
}

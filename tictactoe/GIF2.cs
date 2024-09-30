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
    public partial class GIF2 : Form
    {
        public GIF2()
        {
            InitializeComponent();
        }

        int timer = 2;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer > 0)
            {
                timer = timer - 1;
            }
            else
            {
                timer1.Stop();
                Application.Exit();
            }
        }
    }
}

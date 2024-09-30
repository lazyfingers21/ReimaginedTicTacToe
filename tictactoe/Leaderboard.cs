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
    public partial class Leaderboard : Form
    {
        public Leaderboard()
        {
            InitializeComponent();
        }

        private void Leaderboard_Load(object sender, EventArgs e)
        {
            MainMenu.getplayer.controls.play();
            Form1.getplayer.controls.stop();
            Form2.getplayer.controls.stop();
            Form3.getplayer.controls.stop();

            //if (Array.getname[0] != "" && Array.getscore[0] != "")
            //{
            //    if (Array.getwin1 > Array.getwin2)
            //    {
            //        lbl1st.Text = Array.getname[0] + " - " + Array.getscore[0];
            //        lbl2nd.Text = Array.getname[1] + " - " + Array.getscore[1];
            //    }
            //    else if (Array.getwin2 > Array.getwin1)
            //    {
            //        lbl2nd.Text = Array.getname[1] + " - " + Array.getscore[1];
            //        lbl1st.Text = Array.getname[0] + " - " + Array.getscore[0];
            //    }

            //}
            //if (Array.getname[2] != "" && Array.getscore[2] != "")
            //{
            //    if (Array.getwin1 > Array.getwin2)
            //    {
            //        lbl3rd.Text = Array.getname[2] + " - " + Array.getscore[2];
            //        lbl4th.Text = Array.getname[3] + " - " + Array.getscore[3];
            //    }
            //    else if (Array.getwin2 > Array.getwin1)
            //    {
            //        lbl3rd.Text = Array.getname[2] + " - " + Array.getscore[2];
            //        lbl4th.Text = Array.getname[3] + " - " + Array.getscore[3];
            //    }
            //}


            //Array.getwin1 = 0; Array.getwin2 = 0;
            arrange();
        }

        private void arrange()
        {
            if ((Array.getname[0] != null && Array.getscore[0] != null) && (Array.getname[1] != null && Array.getscore[1] != null) &&
                    (Array.getname[2] == null && Array.getscore[2] == null) && (Array.getname[3] == null && Array.getscore[3] == null))
            {
                if (int.Parse(Array.getscore[0]) >= int.Parse(Array.getscore[1]))
                {
                    lbl1st.Text = Array.getname[0] + " - " + Array.getscore[0];
                    lbl2nd.Text = Array.getname[1] + " - " + Array.getscore[1];
                }
                else if (int.Parse(Array.getscore[1]) >= int.Parse(Array.getscore[0]))
                {
                    lbl1st.Text = Array.getname[1] + " - " + Array.getscore[1];
                    lbl2nd.Text = Array.getname[0] + " - " + Array.getscore[0];
                }
            }

            else if ((Array.getname[0] != null && Array.getscore[0] != null) && (Array.getname[1] != null && Array.getscore[1] != null) &&
                    (Array.getname[2] != null && Array.getscore[2] != null) && (Array.getname[3] != null && Array.getscore[3] != null))
            {
                if ((int.Parse(Array.getscore[0]) >= int.Parse(Array.getscore[2])) && (int.Parse(Array.getscore[2]) >= int.Parse(Array.getscore[1])) && (int.Parse(Array.getscore[1]) >= int.Parse(Array.getscore[3])))
                {
                    lbl1st.Text = Array.getname[0] + " - " + Array.getscore[0];
                    lbl2nd.Text = Array.getname[2] + " - " + Array.getscore[2];
                    lbl3rd.Text = Array.getname[1] + " - " + Array.getscore[1];
                    lbl4th.Text = Array.getname[3] + " - " + Array.getscore[3];
                }
                else if ((int.Parse(Array.getscore[0]) >= int.Parse(Array.getscore[3])) && (int.Parse(Array.getscore[3]) >= int.Parse(Array.getscore[1])) && (int.Parse(Array.getscore[1]) >= int.Parse(Array.getscore[2])))
                {
                    lbl1st.Text = Array.getname[0] + " - " + Array.getscore[0];
                    lbl2nd.Text = Array.getname[3] + " - " + Array.getscore[3];
                    lbl3rd.Text = Array.getname[1] + " - " + Array.getscore[1];
                    lbl4th.Text = Array.getname[2] + " - " + Array.getscore[2];
                }
                else if ((int.Parse(Array.getscore[1]) >= int.Parse(Array.getscore[3])) && (int.Parse(Array.getscore[3]) >= int.Parse(Array.getscore[0])) && (int.Parse(Array.getscore[0]) >= int.Parse(Array.getscore[2])))
                {
                    lbl1st.Text = Array.getname[1] + " - " + Array.getscore[1];
                    lbl2nd.Text = Array.getname[3] + " - " + Array.getscore[3];
                    lbl3rd.Text = Array.getname[0] + " - " + Array.getscore[0];
                    lbl4th.Text = Array.getname[2] + " - " + Array.getscore[2];
                }
                else if ((int.Parse(Array.getscore[1]) >= int.Parse(Array.getscore[2])) && (int.Parse(Array.getscore[2]) >= int.Parse(Array.getscore[0])) && (int.Parse(Array.getscore[0]) >= int.Parse(Array.getscore[3])))
                {
                    lbl1st.Text = Array.getname[1] + " - " + Array.getscore[1];
                    lbl2nd.Text = Array.getname[2] + " - " + Array.getscore[2];
                    lbl3rd.Text = Array.getname[0] + " - " + Array.getscore[0];
                    lbl4th.Text = Array.getname[3] + " - " + Array.getscore[3];
                }
                
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Mode m = new Mode();
            m.Show();
            this.Hide();
        }



    }
}

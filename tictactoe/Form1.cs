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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool turn = true;
        int turn_count = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\tThe game consists of two players. Player 1 takes the 'X' and Player 2 takes 'O'. The goal is to form 3 straight 'X' or 'O', either horizontal, vertical or diagonal.\n\n\tThe player with more points wins the game.\n\n[Installation: Copy 'tictactoe.exe' file and paste into your computer or laptop]", "How To Play");
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTheme_Click(object sender, EventArgs e)
        {

        }

        
        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X"; b.BackColor = Color.Blue;
            }
            else
            {
                b.Text = "O"; b.BackColor = Color.Red;
            }

            turn = !turn;
            b.Enabled = false;
            turn_count++;
            checkForScore();
        }

        bool one_point = false;
        bool check1 = true, check2 = true, check3 = true, check4 = true, check5 = true, check6 = true, check7 = true, check8 = true,
            check9 = true, check10 = true, check11 = true, check12 = true, check13 = true, check14 = true, check15 = true, check16 = true,
            check17 = true, check18 = true, check19 = true, check20 = true, check21 = true, check22 = true, check23 = true, check24 = true,
            check25 = true, check26 = true, check27 = true, check28 = true, check29 = true, check30 = true, check31 = true, check32 = true;
        int score1 = 0, score2 = 0;

        private void checkForScore()
        {
            
            checkPattern();

            if (one_point)
            {
                player2.URL = @"C:\Users\LENOVO\Desktop\tictactoe\tictactoe\Resources\ticresources\BG Music\score.mp3";
                player2.controls.fastForward();

                string scorer = "";

                if (turn)
                {
                    score2 += 1;
                    scorer = "O";
                    lblScore2.Text = score2.ToString();
                }
                else
                {
                    score1 += 1;
                    scorer = "X";
                    lblScore1.Text = score1.ToString();
                }

                one_point = false;
               
            }

            if (turn_count == 36)
            {
                disableButtons();

                if (score2 > score1)
                {
                    MessageBox.Show("Player 2 (O) Win!", "Game Over!"); Array.getwin2++;
                    player2.URL = @"C:\Users\LENOVO\Desktop\tictactoe\tictactoe\Resources\ticresources\BG Music\score.mp3";
                    player2.controls.fastForward();
                }
                else if (score1 > score2)
                {
                    MessageBox.Show("Player 1 (X) Win!", "Game Over!"); Array.getwin1++;
                    player2.URL = @"C:\Users\LENOVO\Desktop\tictactoe\tictactoe\Resources\ticresources\BG Music\score.mp3";
                    player2.controls.fastForward();
                }
                else if (score1 == score2)
                {
                    MessageBox.Show("It's a Draw!", "Game Over!");
                    player2.URL = @"C:\Users\LENOVO\Desktop\tictactoe\tictactoe\Resources\ticresources\BG Music\score.mp3";
                    player2.controls.fastForward();
                }

                Array.getscore[0] = Array.getwin1.ToString();
                //Array.increment2++;
                Array.getscore[1] = Array.getwin2.ToString();
                //Array.increment2++;

                Array.increment3 = 1;
            }
            
        }

            private void checkPattern()
        {
           
            if (check1 == true)
                pattern1();
            if (check2 == true)
                pattern2();
            if (check3 == true)
                pattern3();
            if (check4 == true)
                pattern4();
            if (check5 == true)
                pattern5();
            if (check6 == true)
                pattern6();
            if (check7 == true)
                pattern7();
            if (check8 == true)
                pattern8();
            if (check9 == true)
                pattern9();
            if (check10 == true)
                pattern10();
            if (check11 == true)
                pattern11();
            if (check12 == true)
                pattern12();
            if (check13 == true)
                pattern13();
            if (check14 == true)
                pattern14();
            if (check15 == true)
                pattern15();
            if (check16 == true)
                pattern16();
            if (check17 == true)
                pattern17();
            if (check18 == true)
                pattern18();
            if (check19 == true)
                pattern19();
            if (check20 == true)
                pattern20();
            if (check21 == true)
                pattern21();
            if (check22 == true)
                pattern22();
            if (check23 == true)
                pattern23();
            if (check24 == true)
                pattern24();
            if (check25 == true)
                pattern25();
            if (check26 == true)
                pattern26();
            if (check27 == true)
                pattern27();
            if (check28 == true)
                pattern28();
            if (check29 == true)
                pattern29();
            if (check30 == true)
                pattern30();
            if (check31 == true)
                pattern31();
            if (check32 == true)
                pattern32();
        }

        //horizontal
        void pattern1()
        {
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled)) 
            {
                one_point = true; check1 = false;
            }
        }
        void pattern2()
        {
            if ((A4.Text == A5.Text) && (A5.Text == A6.Text) && (!A4.Enabled))
            {
                one_point = true; check2 = false;
            }
        }
        void pattern3()
        {
            if ((A7.Text == A8.Text) && (A8.Text == A9.Text) && (!A7.Enabled))
            {
                one_point = true; check3 = false;
            }
        }
        void pattern4()
        {
            if ((A10.Text == A11.Text) && (A11.Text == A12.Text) && (!A10.Enabled))
            {
                one_point = true; check4 = false;
            }
        }
        void pattern5()
        {
            if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
            {
                one_point = true; check5 = false;
            }
        }
        void pattern6()
        {
            if ((B4.Text == B5.Text) && (B5.Text == B6.Text) && (!B4.Enabled))
            {
                one_point = true; check6 = false;
            }
        }
        void pattern7()
        {
            if ((B7.Text == B8.Text) && (B8.Text == B9.Text) && (!B7.Enabled))
            {
                one_point = true; check7 = false;
            }
        }
        void pattern8()
        {
            if ((B10.Text == B11.Text) && (B11.Text == B12.Text) && (!B10.Enabled))
            {
                one_point = true; check8 = false;
            }
        }
        void pattern9()
        {
            if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
            {
                one_point = true; check9 = false;
            }
        }
        void pattern10()
        {
            if ((C4.Text == C5.Text) && (C5.Text == C6.Text) && (!C4.Enabled))
            {
                one_point = true; check10 = false;
            }
        }
        void pattern11()
        {
            if ((C7.Text == C8.Text) && (C8.Text == C9.Text) && (!C7.Enabled))
            {
                one_point = true; check11 = false;
            }
        }
        void pattern12()
        {
            if ((C10.Text == C11.Text) && (C11.Text == C12.Text) && (!C10.Enabled))
            {
                one_point = true; check12 = false;
            }
        }
        //vertical
        void pattern13()
        {
            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
            {
                one_point = true; check13 = false;
            }
        }
        void pattern14()
        {

            if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
            {
                one_point = true; check14 = false;
            }
        }
        void pattern15()
        {
            if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
            {
                one_point = true; check15 = false;
            }
        }

        void pattern16()
        {
            if ((A4.Text == B4.Text) && (B4.Text == C4.Text) && (!A4.Enabled))
            {
                one_point = true; check16 = false;
            }
        }
        void pattern17()
        {
            if ((A5.Text == B5.Text) && (B5.Text == C5.Text) && (!A5.Enabled))
            {
                one_point = true; check17 = false;
            }
        }
        void pattern18()
        {
            if ((A6.Text == B6.Text) && (B6.Text == C6.Text) && (!A6.Enabled))
            {
                one_point = true; check18 = false;
            }
        }
        void pattern19()
        {
            if ((A7.Text == B7.Text) && (B7.Text == C7.Text) && (!A7.Enabled))
            {
                one_point = true; check19 = false;
            }
        }
        void pattern20()
        {
            if ((A8.Text == B8.Text) && (B8.Text == C8.Text) && (!A8.Enabled))
            {
                one_point = true; check20 = false;
            }
        }
        void pattern21()
        {
            if ((A9.Text == B9.Text) && (B9.Text == C9.Text) && (!A9.Enabled))

            {
                one_point = true; check21 = false;
            }
        }
        void pattern22()
        {
            if ((A10.Text == B10.Text) && (B10.Text == C10.Text) && (!A10.Enabled))
            {
                one_point = true; check22 = false;
            }
        }
        void pattern23()
        {
            if ((A11.Text == B11.Text) && (B11.Text == C11.Text) && (!A11.Enabled))
            {
                one_point = true; check23 = false;
            }
        }
        void pattern24()
        {
            if ((A12.Text == B12.Text) && (B12.Text == C12.Text) && (!A12.Enabled))
            {
                one_point = true; check24 = false;
            }
        }
        //diagonal
        void pattern25()
        {
            if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
            {
                one_point = true; check25 = false;
            }
        }
        void pattern26()
        {
            if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!A3.Enabled))
            {
                one_point = true; check26 = false;
            }
        }
        void pattern27()
        {
            if ((A4.Text == B5.Text) && (B5.Text == C6.Text) && (!A4.Enabled))
            {
                one_point = true; check27 = false;
            }
        }
        void pattern28()
        {
            if ((A6.Text == B5.Text) && (B5.Text == C4.Text) && (!A6.Enabled))
            {
                one_point = true; check28 = false;
            }
        }
        void pattern29()
        {
            if ((A7.Text == B8.Text) && (B8.Text == C9.Text) && (!A7.Enabled))
            {
                one_point = true; check29 = false;
            }
        }
        void pattern30()
        {
            if ((A9.Text == B8.Text) && (B8.Text == C7.Text) && (!A9.Enabled))
            {
                one_point = true; check30 = false;
            }
        }
        void pattern31()
        {
            if ((A10.Text == B11.Text) && (B11.Text == C12.Text) && (!A10.Enabled))
            {
                one_point = true; check31 = false;
            }
        }
        void pattern32()
        {
            if ((A12.Text == B11.Text) && (B11.Text == C10.Text) && (!A12.Enabled))
            {
                one_point = true; check32 = false;
            }
        }

       



        private void disableButtons()
        {
            try
            {
                foreach (Button c in panelBoard.Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                    
                }
                foreach (Button c in panelBoard2.Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                    
                }
                foreach (Button c in panelBoard3.Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                    
                }
                foreach (Button c in panelBoard4.Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                    
                }
            }
            catch { }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            player.URL = @"C:\Users\LENOVO\Desktop\tictactoe\tictactoe\Resources\ticresources\BG Music\mouse_cliock.mp3";
            player.controls.play();

            Mode m = new Mode();
            m.Show();
            this.Hide();
        }

        private void btnLeaderBoard_Click(object sender, EventArgs e)
        {
            Leaderboard l = new Leaderboard();
            l.Show();
            this.Hide();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            btnLeaderBoard.Show(); btnSounds.Show(); btnHelp.Show(); btnSounds2.Show(); btnSettings.Enabled = false;
            btnCredits.Show();
        }
        private void btnSounds_Click(object sender, EventArgs e)
        {
            if (btnSounds.Visible == true)
            {
                btnSounds2.Show(); btnSounds.Hide();
            }

            player.controls.pause();
        }

        private void btnSounds2_Click(object sender, EventArgs e)
        {
            if (btnSounds2.Visible == true)
            {
                btnSounds.Show(); btnSounds2.Hide();
            }

            player.controls.play();
        }

        private static WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer player2 = new WMPLib.WindowsMediaPlayer();

        public static WMPLib.WindowsMediaPlayer getplayer
        {
            get { return player; }
            set { player = value; }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            MainMenu.getplayer.controls.stop();
            Form3.getplayer.controls.stop();
            Form2.getplayer.controls.stop();

            player.URL = @"C:\Users\LENOVO\Desktop\tictactoe\tictactoe\Resources\ticresources\BG Music\Average.mp3";
            player.controls.play();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
           
            
            if (MessageBox.Show("Are you sure to start a new game?", "New Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                turn = true;
                turn_count = 0;
                one_point = false;
                check1 = true; check2 = true; check3 = true; check4 = true; check5 = true; check6 = true; check7 = true; check8 = true;
                check9 = true; check10 = true; check11 = true; check12 = true; check13 = true; check14 = true; check15 = true; check16 = true;
                check17 = true; check18 = true; check19 = true; check20 = true; check21 = true; check22 = true; check23 = true; check24 = true;
                check25 = true; check26 = true; check27 = true; check28 = true; check29 = true; check30 = true; check31 = true; check32 = true;
                score1 = 0; score2 = 0;


                foreach (Button c in panelBoard.Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                    b.BackColor = Color.WhiteSmoke;
                    lblScore1.Text = "0"; lblScore2.Text = "0";
                }
                foreach (Button c in panelBoard2.Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                    b.BackColor = Color.WhiteSmoke;
                    lblScore1.Text = "0"; lblScore2.Text = "0";
                }
                foreach (Button c in panelBoard3.Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                    b.BackColor = Color.WhiteSmoke;
                    lblScore1.Text = "0"; lblScore2.Text = "0";
                }
                foreach (Button c in panelBoard4.Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                    b.BackColor = Color.WhiteSmoke;
                    lblScore1.Text = "0"; lblScore2.Text = "0";
                }
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quit Game?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                player.URL = @"C:\Users\LENOVO\Desktop\tictactoe\tictactoe\Resources\ticresources\BG Music\Average.mp3";
                player.controls.stop();   

                GIF2 g = new GIF2();
                g.Show();
                this.Hide();
            }
        }

        private void btnCredits_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This game is developed by: \n\n-Jexter Jay A. Abrantes\n-Crissha P. Bayhonan\n\nBSInfoTech(Programming) 2-F\n\nCopyright ©2019", "Credits");
        }

















    }
}

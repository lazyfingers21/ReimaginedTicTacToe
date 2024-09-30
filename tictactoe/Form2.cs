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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private static WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer player2 = new WMPLib.WindowsMediaPlayer();

        public static WMPLib.WindowsMediaPlayer getplayer
        {
            get { return player; }
            set { player = value; }
        }


        bool turn = true;
        int turn_count = 0;


        private void Form2_Load(object sender, EventArgs e)
        {
            MainMenu.getplayer.controls.stop();
            Form1.getplayer.controls.stop();
            Form2.getplayer.controls.stop();

            player.URL = @"C:\Users\LENOVO\Desktop\tictactoe\tictactoe\Resources\ticresources\BG Music\Easy.mp3";
            player.controls.play();        
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\tThe game consists of two players. Player 1 takes the 'X' and Player 2 takes 'O'. The goal is to form 3 straight 'X' or 'O', either horizontal, vertical or diagonal.\n\n\tThe player with more points wins the game.\n\n[Installation: Copy 'tictactoe.exe' file and paste into your computer or laptop]", "How To Play");
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLeaderBoard_Click(object sender, EventArgs e)
        {
            Leaderboard l = new Leaderboard();
            l.Show();
            this.Hide();
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
            check25 = true, check26 = true, check27 = true, check28 = true, check29 = true, check30 = true, check31 = true, check32 = true,
            check33 = true, check34 = true, check35 = true, check36 = true, check37 = true, check38 = true, check39 = true, check40 = true,
            check41 = true, check42 = true, check43 = true, check44 = true, check45 = true, check46 = true, check47 = true, check48 = true;
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

            if (turn_count == 25)
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

                Array.increment2++;
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
            if (check33 == true)
                pattern33();
            if (check34 == true)
                pattern34();
            if (check35 == true)
                pattern35();
            if (check36 == true)
                pattern36();
            if (check37 == true)
                pattern37();
            if (check38 == true)
                pattern38();
            if (check39 == true)
                pattern39();
            if (check40 == true)
                pattern40();
            if (check41 == true)
                pattern41();
            if (check42 == true)
                pattern42();
            if (check43 == true)
                pattern43();
            if (check44 == true)
                pattern44();
            if (check45 == true)
                pattern45();
            if (check46 == true)
                pattern46();
            if (check47 == true)
                pattern47();
            if (check48 == true)
                pattern48();

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
            if ((A2.Text == A3.Text) && (A3.Text == A4.Text) && (!A2.Enabled))
            {
                one_point = true; check2 = false;
            }
        }
        void pattern3()
        {
            if ((A3.Text == A4.Text) && (A4.Text == A5.Text) && (!A3.Enabled))
            {
                one_point = true; check3 = false;
            }
        }
        void pattern4()
        {
            if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
            {
                one_point = true; check4 = false;
            }
        }
        void pattern5()
        {
            if ((B2.Text == B3.Text) && (B3.Text == B4.Text) && (!B2.Enabled))
            {
                one_point = true; check5 = false;
            }
        }
        void pattern6()
        {
            if ((B3.Text == B4.Text) && (B4.Text == B5.Text) && (!B3.Enabled))
            {
                one_point = true; check6 = false;
            }
        }
        void pattern7()
        {
            if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
            {
                one_point = true; check7 = false;
            }
        }
        void pattern8()
        {
            if ((C2.Text == C3.Text) && (C3.Text == C4.Text) && (!C2.Enabled))
            {
                one_point = true; check8 = false;
            }
        }
        void pattern9()
        {
            if ((C3.Text == C4.Text) && (C4.Text == C5.Text) && (!C3.Enabled))
            {
                one_point = true; check9 = false;
            }
        }
        void pattern10()
        {
            if ((D1.Text == D2.Text) && (D2.Text == D3.Text) && (!D1.Enabled))
            {
                one_point = true; check10 = false;
            }
        }
        void pattern11()
        {
            if ((D2.Text == D3.Text) && (D3.Text == D4.Text) && (!D2.Enabled))
            {
                one_point = true; check11 = false;
            }
        }
        void pattern12()
        {
            if ((D3.Text == D4.Text) && (D4.Text == D5.Text) && (!D3.Enabled))
            {
                one_point = true; check12 = false;
            }
        }
        void pattern13()
        {
            if ((E1.Text == E2.Text) && (E2.Text == E3.Text) && (!E1.Enabled))
            {
                one_point = true; check13 = false;
            }
        }
        void pattern14()
        {

            if ((E2.Text == E3.Text) && (E3.Text == E4.Text) && (!E2.Enabled))
            {
                one_point = true; check14 = false;
            }
        }
        void pattern15()
        {
            if ((E3.Text == E4.Text) && (E4.Text == E5.Text) && (!E3.Enabled))
            {
                one_point = true; check15 = false;
            }
        }

        //vertical
        void pattern16()
        {
            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
            {
                one_point = true; check16 = false;
            }
        }
        void pattern17()
        {
            if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
            {
                one_point = true; check17 = false;
            }
        }
        void pattern18()
        {
            if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
            {
                one_point = true; check18 = false;
            }
        }
        void pattern19()
        {
            if ((A4.Text == B4.Text) && (B4.Text == C4.Text) && (!A4.Enabled))
            {
                one_point = true; check19 = false;
            }
        }
        void pattern20()
        {
            if ((A5.Text == B5.Text) && (B5.Text == C5.Text) && (!A5.Enabled))
            {
                one_point = true; check20 = false;
            }
        }
        void pattern21()
        {
            if ((B1.Text == C1.Text) && (C1.Text == D1.Text) && (!B1.Enabled))
            {
                one_point = true; check21 = false;
            }
        }
        void pattern22()
        {
            if ((B2.Text == C2.Text) && (C2.Text == D2.Text) && (!B2.Enabled))
            {
                one_point = true; check22 = false;
            }
        }
        void pattern23()
        {
            if ((B3.Text == C3.Text) && (C3.Text == D3.Text) && (!B3.Enabled))
            {
                one_point = true; check23 = false;
            }
        }
        void pattern24()
        {
            if ((B4.Text == C4.Text) && (C4.Text == D4.Text) && (!B4.Enabled))
            {
                one_point = true; check24 = false;
            }
        }
        void pattern25()
        {
            if ((B5.Text == C5.Text) && (C5.Text == D5.Text) && (!B5.Enabled))
            {
                one_point = true; check25 = false;
            }
        }
        void pattern26()
        {
            if ((C1.Text == D1.Text) && (D1.Text == E1.Text) && (!C1.Enabled))
            {
                one_point = true; check26 = false;
            }
        }
        void pattern27()
        {
            if ((C2.Text == D2.Text) && (D2.Text == E2.Text) && (!C2.Enabled))
            {
                one_point = true; check27 = false;
            }
        }
        void pattern28()
        {
            if ((C3.Text == D3.Text) && (D3.Text == E3.Text) && (!C3.Enabled))
            {
                one_point = true; check28 = false;
            }
        }
        void pattern29()
        {
            if ((C4.Text == D4.Text) && (D4.Text == E4.Text) && (!C4.Enabled))
            {
                one_point = true; check29 = false;
            }
        }
        void pattern30()
        {
            if ((C5.Text == D5.Text) && (D5.Text == E5.Text) && (!C5.Enabled))
            {
                one_point = true; check30 = false;
            }
        }

        //diagonal
        void pattern31()
        {
            if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
            {
                one_point = true; check31 = false;
            }
        }
        void pattern32()
        {
            if ((A2.Text == B3.Text) && (B3.Text == C4.Text) && (!A2.Enabled))
            {
                one_point = true; check32 = false;
            }
        }
        void pattern33()
        {
            if ((A3.Text == B4.Text) && (B4.Text == C5.Text) && (!A3.Enabled))
            {
                one_point = true; check33 = false;
            }
        }
        void pattern34()
        {
            if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!A3.Enabled))
            {
                one_point = true; check34 = false;
            }
        }
        void pattern35()
        {
            if ((A4.Text == B3.Text) && (B3.Text == C2.Text) && (!A4.Enabled))
            {
                one_point = true; check35 = false;
            }
        }
        void pattern36()
        {
            if ((A5.Text == B4.Text) && (B4.Text == C3.Text) && (!A5.Enabled))
            {
                one_point = true; check36 = false;
            }
        }
        void pattern37()
        {
            if ((B1.Text == C2.Text) && (C2.Text == D3.Text) && (!B1.Enabled))
            {
                one_point = true; check37 = false;
            }
        }
        void pattern38()
        {
            if ((B2.Text == C3.Text) && (C3.Text == D4.Text) && (!B2.Enabled))
            {
                one_point = true; check38 = false;
            }
        }
        void pattern39()
        {
            if ((B3.Text == C4.Text) && (C4.Text == D5.Text) && (!B3.Enabled))
            {
                one_point = true; check39 = false;
            }
        }
        void pattern40()
        {
            if ((B3.Text == C2.Text) && (C2.Text == D1.Text) && (!B3.Enabled))
            {
                one_point = true; check40 = false;
            }
        }
        void pattern41()
        {
            if ((B4.Text == C3.Text) && (C3.Text == D2.Text) && (!B4.Enabled))
            {
                one_point = true; check41 = false;
            }
        }
        void pattern42()
        {
            if ((B5.Text == C4.Text) && (C4.Text == D3.Text) && (!B5.Enabled))
            {
                one_point = true; check42 = false;
            }
        }
        void pattern43()
        {
            if ((C1.Text == D2.Text) && (D2.Text == E3.Text) && (!C1.Enabled))
            {
                one_point = true; check43 = false;
            }
        }
        void pattern44()
        {
            if ((C2.Text == D3.Text) && (D3.Text == E4.Text) && (!C2.Enabled))
            {
                one_point = true; check44 = false;
            }
        }
        void pattern45()
        {
            if ((C3.Text == D4.Text) && (D4.Text == E5.Text) && (!C3.Enabled))
            {
                one_point = true; check45 = false;
            }
        }
        void pattern46()
        {
            if ((C3.Text == D2.Text) && (D2.Text == E1.Text) && (!C3.Enabled))
            {
                one_point = true; check46 = false;
            }
        }
        void pattern47()
        {
            if ((C4.Text == D3.Text) && (D3.Text == E2.Text) && (!C4.Enabled))
            {
                one_point = true; check47 = false;
            }
        }
        void pattern48()
        {
            if ((C5.Text == D4.Text) && (D4.Text == E3.Text) && (!C5.Enabled))
            {
                one_point = true; check48 = false;
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

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu m = new MainMenu();
            m.Show();
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
                check33 = true; check34 = true; check35 = true; check36 = true; check37 = true; check38 = true; check39 = true; check40 = true;
                check41 = true; check42 = true; check43 = true; check44 = true; check45 = true; check46 = true; check47 = true; check48 = true;
                score1 = 0; score2 = 0;


                foreach (Button c in panelBoard.Controls)
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
                GIF2 g = new GIF2();
                g.Show();
                this.Hide();

                player.URL = @"C:\Users\LENOVO\Desktop\tictactoe\tictactoe\Resources\ticresources\BG Music\Easy.mp3";
                player.controls.stop();   
            }
        }

        private void btnCredits_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This game is developed by: \n\n-Jexter Jay A. Abrantes\n-Crissha P. Bayhonan\n\nBSInfoTech(Programming) 2-F\n\nCopyright ©2019", "Credits");
        }









    }
}
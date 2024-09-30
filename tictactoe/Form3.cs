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
    public partial class Form3 : Form
    {
        public Form3()
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
        int turn_count = 0, textbox_count = 0;

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
            check25 = true, check26 = true, check27 = true, check28 = true, check29 = true, check30 = true, check31 = true, check32 = true,
            check33 = true, check34 = true, check35 = true, check36 = true, check37 = true, check38 = true, check39 = true, check40 = true,               check41 = true, check42 = true, check43 = true, check44 = true, check45 = true, check46 = true, check47 = true, check48 = true,               check49 = true, check50 = true, check51 = true, check52 = true, check53 = true, check54 = true, check55 = true, check56 = true,               check57 = true, check58 = true, check59 = true, check60 = true, check61 = true, check62 = true, check63 = true, check64 = true,               check65 = true, check66 = true, check67 = true, check68 = true, check69 = true, check70 = true, check71 = true, check72 = true,
            check73 = true, check74 = true, check75 = true, check76 = true, check77 = true, check78 = true, check79 = true, check80 = true;
        int score1 = 0, score2 = 0;

        private void checkForScore()
        {

            checkPattern();

            if (one_point)
            {
                player2.URL = @"C:\Users\LENOVO\Desktop\tictactoe\tictactoe\Resources\ticresources\BG Music\score.mp3";
                player2.controls.fastForward();

                disableButtons();

                String winner = "";
                if (turn)
                {
                    winner = "Player 2 (O)"; Array.getwin2++;
                }
                else
                {
                    winner = "Player 1 (X)"; Array.getwin1++;
                }

                one_point = false; textbox_count = 0;
                MessageBox.Show(winner + " Win!", "Game Over!");

            }

            else if (textbox_count == 9)
                {
                    MessageBox.Show("It's a Draw!", "Game Over!"); disableButtons();
                }

            else if (turn_count == 81)
            {
                MessageBox.Show("It's a Draw!", "Game Over!"); disableButtons();
            }


                Array.getscore[0] = Array.getwin1.ToString();
                //Array.increment2++;
                Array.getscore[1] = Array.getwin2.ToString();
                //Array.increment2++;
        

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
            if (check49 == true)
                pattern49();
            if (check50 == true)
                pattern50();
            if (check51 == true)
                pattern51();
            if (check52 == true)
                pattern52();
            if (check53 == true)
                pattern53();
            if (check54 == true)
                pattern54();
            if (check55 == true)
                pattern55();
            if (check56 == true)
                pattern56();
            if (check57 == true)
                pattern57();
            if (check58 == true)
                pattern58();
            if (check59 == true)
                pattern59();
            if (check60 == true)
                pattern60();
            if (check61 == true)
                pattern61();
            if (check62 == true)
                pattern62();
            if (check63 == true)
                pattern63();
            if (check64 == true)
                pattern64();
            if (check65 == true)
                pattern65();
            if (check66 == true)
                pattern66();
            if (check67 == true)
                pattern67();
            if (check68 == true)
                pattern68();
            if (check69 == true)
                pattern69();
            if (check70 == true)
                pattern70();
            if (check71 == true)
                pattern71();
            if (check72 == true)
                pattern72();
            if (check73 == true)
                pattern73();
            if (check74 == true)
                pattern74();
            if (check75 == true)
                pattern75();
            if (check76 == true)
                pattern76();
            if (check77 == true)
                pattern77();
            if (check78 == true)
                pattern78();
            if (check79 == true)
                pattern79();
            if (check80 == true)
                pattern80();


        }

        //horizontal
        void pattern1()
        {
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
            {
                check1 = false; textBox1.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox1.Text = "X"; textBox1.BackColor = Color.Blue; textBox1.Enabled = false;
                }
                else
                {
                    textBox1.Text = "O"; textBox1.BackColor = Color.Red; textBox1.Enabled = false;
                }
            }
        }
        void pattern2()
        {
            if ((A4.Text == A5.Text) && (A5.Text == A6.Text) && (!A4.Enabled))
            {
                check2 = false; textBox2.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox2.Text = "X"; textBox2.BackColor = Color.Blue; textBox2.Enabled = false;
                }
                else
                {
                    textBox2.Text = "O"; textBox2.BackColor = Color.Red; textBox2.Enabled = false;
                }
            }
        }
        void pattern3()
        {
            if ((A7.Text == A8.Text) && (A8.Text == A9.Text) && (!A7.Enabled))
            {
                check3 = false; textBox3.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox3.Text = "X"; textBox3.BackColor = Color.Blue; textBox3.Enabled = false;
                }
                else
                {
                    textBox3.Text = "O"; textBox3.BackColor = Color.Red; textBox3.Enabled = false;
                }
            }
        }
        void pattern4()
        {
            if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
            {
                check4 = false; textBox1.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox1.Text = "X"; textBox1.BackColor = Color.Blue; textBox1.Enabled = false;
                }
                else
                {
                    textBox1.Text = "O"; textBox1.BackColor = Color.Red; textBox1.Enabled = false;
                }
            }
        }
        void pattern5()
        {
            if ((B4.Text == B5.Text) && (B5.Text == B6.Text) && (!B4.Enabled))
            {
                check5 = false; textBox2.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox2.Text = "X"; textBox2.BackColor = Color.Blue; textBox2.Enabled = false;
                }
                else
                {
                    textBox2.Text = "O"; textBox2.BackColor = Color.Red; textBox2.Enabled = false;
                }
            }
        }
        void pattern6()
        {
            if ((B7.Text == B8.Text) && (B8.Text == B9.Text) && (!B7.Enabled))
            {
                check6 = false; textBox3.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox3.Text = "X"; textBox3.BackColor = Color.Blue; textBox3.Enabled = false;
                }
                else
                {
                    textBox3.Text = "O"; textBox3.BackColor = Color.Red; textBox3.Enabled = false;
                }
            }
        }
        void pattern7()
        {
            if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
            {
                check7 = false; textBox1.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox1.Text = "X"; textBox1.BackColor = Color.Blue; textBox1.Enabled = false;
                }
                else
                {
                    textBox1.Text = "O"; textBox1.BackColor = Color.Red; textBox1.Enabled = false;
                }
            }
        }
        void pattern8()
        {
            if ((C4.Text == C5.Text) && (C5.Text == C6.Text) && (!C4.Enabled))
            {
                check8 = false; textBox2.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox2.Text = "X"; textBox2.BackColor = Color.Blue; textBox2.Enabled = false;
                }
                else
                {
                    textBox2.Text = "O"; textBox2.BackColor = Color.Red; textBox2.Enabled = false;
                }
            }
        }
        void pattern9()
        {
            if ((C7.Text == C8.Text) && (C8.Text == C9.Text) && (!C7.Enabled))
            {
                check9 = false; textBox3.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox3.Text = "X"; textBox3.BackColor = Color.Blue; textBox3.Enabled = false;
                }
                else
                {
                    textBox3.Text = "O"; textBox3.BackColor = Color.Red; textBox3.Enabled = false;
                }
            }
        }
        void pattern10()
        {
            if ((D1.Text == D2.Text) && (D2.Text == D3.Text) && (!D1.Enabled))
            {
                check10 = false; textBox4.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox4.Text = "X"; textBox4.BackColor = Color.Blue; textBox4.Enabled = false;
                }
                else
                {
                    textBox4.Text = "O"; textBox4.BackColor = Color.Red; textBox4.Enabled = false;
                }
            }
        }
        void pattern11()
        {
            if ((D4.Text == D5.Text) && (D5.Text == D6.Text) && (!D4.Enabled))
            {
                check11 = false; textBox5.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox5.Text = "X"; textBox5.BackColor = Color.Blue; textBox5.Enabled = false;
                }
                else
                {
                    textBox5.Text = "O"; textBox5.BackColor = Color.Red; textBox5.Enabled = false;
                }
            }
        }
        void pattern12()
        {
            if ((D7.Text == D8.Text) && (D8.Text == D9.Text) && (!D7.Enabled))
            {
                check12 = false; textBox6.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox6.Text = "X"; textBox6.BackColor = Color.Blue; textBox6.Enabled = false;
                }
                else
                {
                    textBox6.Text = "O"; textBox6.BackColor = Color.Red; textBox6.Enabled = false;
                }
            }
        }
        void pattern13()
        {
            if ((E1.Text == E2.Text) && (E2.Text == E3.Text) && (!E1.Enabled))
            {
                check13 = false; textBox4.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox4.Text = "X"; textBox4.BackColor = Color.Blue; textBox4.Enabled = false;
                }
                else
                {
                    textBox4.Text = "O"; textBox4.BackColor = Color.Red; textBox4.Enabled = false;
                }
            }
        }
        void pattern14()
        {
            if ((E4.Text == E5.Text) && (E5.Text == E6.Text) && (!E4.Enabled))
            {
                check14 = false; textBox5.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox5.Text = "X"; textBox5.BackColor = Color.Blue; textBox5.Enabled = false;
                }
                else
                {
                    textBox5.Text = "O"; textBox5.BackColor = Color.Red; textBox5.Enabled = false;
                }
            }
        }
        void pattern15()
        {
            if ((E7.Text == E8.Text) && (E8.Text == E9.Text) && (!E7.Enabled))
            {
                check15 = false; textBox6.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox6.Text = "X"; textBox6.BackColor = Color.Blue; textBox6.Enabled = false;
                }
                else
                {
                    textBox6.Text = "O"; textBox6.BackColor = Color.Red; textBox6.Enabled = false;
                }
            }
        }
        void pattern16()
        {
            if ((F1.Text == F2.Text) && (F2.Text == F3.Text) && (!F1.Enabled))
            {
                check16 = false; textBox4.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox4.Text = "X"; textBox4.BackColor = Color.Blue; textBox4.Enabled = false;
                }
                else
                {
                    textBox4.Text = "O"; textBox4.BackColor = Color.Red; textBox4.Enabled = false;
                }
            }
        }
        void pattern17()
        {
            if ((F4.Text == F5.Text) && (F5.Text == F6.Text) && (!F4.Enabled))
            {
                check17 = false; textBox5.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox5.Text = "X"; textBox5.BackColor = Color.Blue; textBox5.Enabled = false;
                }
                else
                {
                    textBox5.Text = "O"; textBox5.BackColor = Color.Red; textBox5.Enabled = false;
                }
            }
        }
        void pattern18()
        {
            if ((F7.Text == F8.Text) && (F8.Text == F9.Text) && (!F7.Enabled))
            {
                check18 = false; textBox6.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox6.Text = "X"; textBox6.BackColor = Color.Blue; textBox6.Enabled = false;
                }
                else
                {
                    textBox6.Text = "O"; textBox6.BackColor = Color.Red; textBox6.Enabled = false;
                }
            }
        }
        void pattern19()
        {
            if ((G1.Text == G2.Text) && (G2.Text == G3.Text) && (!G1.Enabled))
            {
                check19 = false; textBox7.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox7.Text = "X"; textBox7.BackColor = Color.Blue; textBox7.Enabled = false;
                }
                else
                {
                    textBox7.Text = "O"; textBox7.BackColor = Color.Red; textBox7.Enabled = false;
                }
            }
        }
        void pattern20()
        {
            if ((G4.Text == G5.Text) && (G5.Text == G6.Text) && (!G4.Enabled))
            {
                check20 = false; textBox8.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox8.Text = "X"; textBox8.BackColor = Color.Blue; textBox8.Enabled = false;
                }
                else
                {
                    textBox8.Text = "O"; textBox8.BackColor = Color.Red; textBox8.Enabled = false;
                }
            }
        }
        void pattern21()
        {
            if ((G7.Text == G8.Text) && (G8.Text == G9.Text) && (!G7.Enabled))
            {
                check21 = false; textBox9.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox9.Text = "X"; textBox9.BackColor = Color.Blue; textBox9.Enabled = false;
                }
                else
                {
                    textBox9.Text = "O"; textBox9.BackColor = Color.Red; textBox9.Enabled = false;
                }
            }
        }
        void pattern22()
        {
            if ((H1.Text == H2.Text) && (H2.Text == H3.Text) && (!H1.Enabled))
            {
                check22 = false; textBox7.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox7.Text = "X"; textBox7.BackColor = Color.Blue; textBox7.Enabled = false;
                }
                else
                {
                    textBox7.Text = "O"; textBox7.BackColor = Color.Red; textBox7.Enabled = false;
                }
            }
        }
        void pattern23()
        {
            if ((H4.Text == H5.Text) && (H5.Text == H6.Text) && (!H4.Enabled))
            {
                check23 = false; textBox8.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox8.Text = "X"; textBox8.BackColor = Color.Blue; textBox8.Enabled = false;
                }
                else
                {
                    textBox8.Text = "O"; textBox8.BackColor = Color.Red; textBox8.Enabled = false;
                }
            }
        }
        void pattern24()
        {
            if ((H7.Text == H8.Text) && (H8.Text == H9.Text) && (!H7.Enabled))
            {
                check24 = false; textBox9.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox9.Text = "X"; textBox9.BackColor = Color.Blue; textBox9.Enabled = false;
                }
                else
                {
                    textBox9.Text = "O"; textBox9.BackColor = Color.Red; textBox9.Enabled = false;
                }
            }
        }
        void pattern25()
        {
            if ((I1.Text == I2.Text) && (I2.Text == I3.Text) && (!I1.Enabled))
            {
                check25 = false; textBox7.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox7.Text = "X"; textBox7.BackColor = Color.Blue; textBox7.Enabled = false;
                }
                else
                {
                    textBox7.Text = "O"; textBox7.BackColor = Color.Red; textBox7.Enabled = false;
                }
            }
        }
        void pattern26()
        {
            if ((I4.Text == I5.Text) && (I5.Text == I6.Text) && (!I4.Enabled))
            {
                check26 = false; textBox8.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox8.Text = "X"; textBox8.BackColor = Color.Blue; textBox8.Enabled = false;
                }
                else
                {
                    textBox8.Text = "O"; textBox8.BackColor = Color.Red; textBox8.Enabled = false;
                }
            }
        }
        void pattern27()
        {
            if ((I7.Text == I8.Text) && (I8.Text == I9.Text) && (!I7.Enabled))
            {
                check27 = false; textBox9.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox9.Text = "X"; textBox9.BackColor = Color.Blue; textBox9.Enabled = false;
                }
                else
                {
                    textBox9.Text = "O"; textBox9.BackColor = Color.Red; textBox9.Enabled = false;
                }
            }
        }

        //vertical
        void pattern28()
        {
            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
            {
                check28 = false; textBox1.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox1.Text = "X"; textBox1.BackColor = Color.Blue; textBox1.Enabled = false;
                }
                else
                {
                    textBox1.Text = "O"; textBox1.BackColor = Color.Red; textBox1.Enabled = false;
                }
            }
        }
        void pattern29()
        {

            if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
            {
                check29 = false; textBox1.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox1.Text = "X"; textBox1.BackColor = Color.Blue; textBox1.Enabled = false;
                }
                else
                {
                    textBox1.Text = "O"; textBox1.BackColor = Color.Red; textBox1.Enabled = false;
                }
            }
        }
        void pattern30()
        {
            if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
            {
                check30 = false; textBox1.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox1.Text = "X"; textBox1.BackColor = Color.Blue; textBox1.Enabled = false;
                }
                else
                {
                    textBox1.Text = "O"; textBox1.BackColor = Color.Red; textBox1.Enabled = false;
                }
            }
        }
        void pattern31()
        {
            if ((A4.Text == B4.Text) && (B4.Text == C4.Text) && (!A4.Enabled))
            {
                check31 = false; textBox2.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox2.Text = "X"; textBox2.BackColor = Color.Blue; textBox2.Enabled = false;
                }
                else
                {
                    textBox2.Text = "O"; textBox2.BackColor = Color.Red; textBox2.Enabled = false;
                }
            }
        }
        void pattern32()
        {
            if ((A5.Text == B5.Text) && (B5.Text == C5.Text) && (!A5.Enabled))
            {
                check32 = false; textBox2.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox2.Text = "X"; textBox2.BackColor = Color.Blue; textBox2.Enabled = false;
                }
                else
                {
                    textBox2.Text = "O"; textBox2.BackColor = Color.Red; textBox2.Enabled = false;
                }
            }
        }
        void pattern33()
        {
            if ((A6.Text == B6.Text) && (B6.Text == C6.Text) && (!A6.Enabled))
            {
                check33 = false; textBox2.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox2.Text = "X"; textBox2.BackColor = Color.Blue; textBox2.Enabled = false;
                }
                else
                {
                    textBox2.Text = "O"; textBox2.BackColor = Color.Red; textBox2.Enabled = false;
                }
            }
        }
        void pattern34()
        {
            if ((A7.Text == B7.Text) && (B7.Text == C7.Text) && (!A7.Enabled))
            {
                check34 = false; textBox3.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox3.Text = "X"; textBox3.BackColor = Color.Blue; textBox3.Enabled = false;
                }
                else
                {
                    textBox3.Text = "O"; textBox3.BackColor = Color.Red; textBox3.Enabled = false;
                }
            }
        }
        void pattern35()
        {
            if ((A8.Text == B8.Text) && (B8.Text == C8.Text) && (!A8.Enabled))
            {
                check35 = false; textBox3.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox3.Text = "X"; textBox3.BackColor = Color.Blue; textBox3.Enabled = false;
                }
                else
                {
                    textBox3.Text = "O"; textBox3.BackColor = Color.Red; textBox3.Enabled = false;
                }
            }
        }
        void pattern36()
        {
            if ((A9.Text == B9.Text) && (B9.Text == C9.Text) && (!A9.Enabled))
            {
                check36 = false; textBox3.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox3.Text = "X"; textBox3.BackColor = Color.Blue; textBox3.Enabled = false;
                }
                else
                {
                    textBox3.Text = "O"; textBox3.BackColor = Color.Red; textBox3.Enabled = false;
                }
            }
        }
        void pattern37()
        {
            if ((D1.Text == E1.Text) && (E1.Text == F1.Text) && (!D1.Enabled))
            {
                check37 = false; textBox4.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox4.Text = "X"; textBox4.BackColor = Color.Blue; textBox4.Enabled = false;
                }
                else
                {
                    textBox4.Text = "O"; textBox4.BackColor = Color.Red; textBox4.Enabled = false;
                }
            }
        }
        void pattern38()
        {
            if ((D2.Text == E2.Text) && (E2.Text == F2.Text) && (!D2.Enabled))
            {
                check38 = false; textBox4.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox4.Text = "X"; textBox4.BackColor = Color.Blue; textBox4.Enabled = false;
                }
                else
                {
                    textBox4.Text = "O"; textBox4.BackColor = Color.Red; textBox4.Enabled = false;
                }
            }
        }
        void pattern39()
        {
            if ((D3.Text == E3.Text) && (E3.Text == F3.Text) && (!D3.Enabled))
            {
                check39 = false; textBox4.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox4.Text = "X"; textBox4.BackColor = Color.Blue; textBox4.Enabled = false;
                }
                else
                {
                    textBox4.Text = "O"; textBox4.BackColor = Color.Red; textBox4.Enabled = false;
                }
            }
        }
        void pattern40()
        {
            if ((D4.Text == E4.Text) && (E4.Text == F4.Text) && (!D4.Enabled))
            {
                check40 = false; textBox5.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox5.Text = "X"; textBox5.BackColor = Color.Blue; textBox5.Enabled = false;
                }
                else
                {
                    textBox5.Text = "O"; textBox5.BackColor = Color.Red; textBox5.Enabled = false;
                }
            }
        }
        void pattern41()
        {
            if ((D5.Text == E5.Text) && (E5.Text == F5.Text) && (!D5.Enabled))
            {
                check41 = false; textBox5.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox5.Text = "X"; textBox5.BackColor = Color.Blue; textBox5.Enabled = false;
                }
                else
                {
                    textBox5.Text = "O"; textBox5.BackColor = Color.Red; textBox5.Enabled = false;
                }
            }
        }
        void pattern42()
        {
            if ((D6.Text == E6.Text) && (E6.Text == F6.Text) && (!D6.Enabled))
            {
                check42 = false; textBox5.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox5.Text = "X"; textBox5.BackColor = Color.Blue; textBox5.Enabled = false;
                }
                else
                {
                    textBox5.Text = "O"; textBox5.BackColor = Color.Red; textBox5.Enabled = false;
                }
            }
        }
        void pattern43()
        {
            if ((D7.Text == E7.Text) && (E7.Text == F7.Text) && (!D7.Enabled))
            {
                check43 = false; textBox6.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox6.Text = "X"; textBox6.BackColor = Color.Blue; textBox6.Enabled = false;
                }
                else
                {
                    textBox6.Text = "O"; textBox6.BackColor = Color.Red; textBox6.Enabled = false;
                }
            }
        }
        void pattern44()
        {
            if ((D8.Text == E8.Text) && (E8.Text == F8.Text) && (!D8.Enabled))
            {
                check44 = false; textBox6.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox6.Text = "X"; textBox6.BackColor = Color.Blue; textBox6.Enabled = false;
                }
                else
                {
                    textBox6.Text = "O"; textBox6.BackColor = Color.Red; textBox6.Enabled = false;
                }
            }
        }
        void pattern45()
        {
            if ((D9.Text == E9.Text) && (E9.Text == F9.Text) && (!D9.Enabled))
            {
                check45 = false; textBox6.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox6.Text = "X"; textBox6.BackColor = Color.Blue; textBox6.Enabled = false;
                }
                else
                {
                    textBox6.Text = "O"; textBox6.BackColor = Color.Red; textBox6.Enabled = false;
                }
            }
        }
        void pattern46()
        {
            if ((G1.Text == H1.Text) && (H1.Text == I1.Text) && (!G1.Enabled))
            {
                check46 = false; textBox7.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox7.Text = "X"; textBox7.BackColor = Color.Blue; textBox7.Enabled = false;
                }
                else
                {
                    textBox7.Text = "O"; textBox7.BackColor = Color.Red; textBox7.Enabled = false;
                }
            }
        }
        void pattern47()
        {
            if ((G2.Text == H2.Text) && (H2.Text == I2.Text) && (!G2.Enabled))
            {
                check47 = false; textBox7.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox7.Text = "X"; textBox7.BackColor = Color.Blue; textBox7.Enabled = false;
                }
                else
                {
                    textBox7.Text = "O"; textBox7.BackColor = Color.Red; textBox7.Enabled = false;
                }
            }
        }
        void pattern48()
        {
            if ((G3.Text == H3.Text) && (H3.Text == I3.Text) && (!G3.Enabled))
            {
                check48 = false; textBox7.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox7.Text = "X"; textBox7.BackColor = Color.Blue; textBox7.Enabled = false;
                }
                else
                {
                    textBox7.Text = "O"; textBox7.BackColor = Color.Red; textBox7.Enabled = false;
                }
            }
        }
        void pattern49()
        {
            if ((G4.Text == H4.Text) && (H4.Text == I4.Text) && (!G4.Enabled))
            {
                check49 = false; textBox8.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox8.Text = "X"; textBox8.BackColor = Color.Blue; textBox8.Enabled = false;
                }
                else
                {
                    textBox8.Text = "O"; textBox8.BackColor = Color.Red; textBox8.Enabled = false;
                }
            }
        }
        void pattern50()
        {
            if ((G5.Text == H5.Text) && (H5.Text == I5.Text) && (!G5.Enabled))
            {
                check50 = false; textBox8.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox8.Text = "X"; textBox8.BackColor = Color.Blue; textBox8.Enabled = false;
                }
                else
                {
                    textBox8.Text = "O"; textBox8.BackColor = Color.Red; textBox8.Enabled = false;
                }
            }
        }
        void pattern51()
        {
            if ((G6.Text == H6.Text) && (H6.Text == I6.Text) && (!G6.Enabled))
            {
                check51 = false; textBox8.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox8.Text = "X"; textBox8.BackColor = Color.Blue; textBox8.Enabled = false;
                }
                else
                {
                    textBox8.Text = "O"; textBox8.BackColor = Color.Red; textBox8.Enabled = false;
                }
            }
        }
        void pattern52()
        {
            if ((G7.Text == H7.Text) && (H7.Text == I7.Text) && (!G7.Enabled))
            {
                check52 = false; textBox9.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox9.Text = "X"; textBox9.BackColor = Color.Blue; textBox9.Enabled = false;
                }
                else
                {
                    textBox9.Text = "O"; textBox9.BackColor = Color.Red; textBox9.Enabled = false;
                }
            }
        }
        void pattern53()
        {
            if ((G8.Text == H8.Text) && (H8.Text == I8.Text) && (!G8.Enabled))
            {
                check53 = false; textBox9.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox9.Text = "X"; textBox9.BackColor = Color.Blue; textBox9.Enabled = false;
                }
                else
                {
                    textBox9.Text = "O"; textBox9.BackColor = Color.Red; textBox9.Enabled = false;
                }
            }
        }
        void pattern54()
        {
            if ((G9.Text == H9.Text) && (H9.Text == I9.Text) && (!G9.Enabled))
            {
                check54 = false; textBox9.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox9.Text = "X"; textBox9.BackColor = Color.Blue; textBox9.Enabled = false;
                }
                else
                {
                    textBox9.Text = "O"; textBox9.BackColor = Color.Red; textBox9.Enabled = false;
                }
            }
        }

        //diagonal
        void pattern55()
        {
            if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
            {
                check55 = false; textBox1.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox1.Text = "X"; textBox1.BackColor = Color.Blue; textBox1.Enabled = false;
                }
                else
                {
                    textBox1.Text = "O"; textBox1.BackColor = Color.Red; textBox1.Enabled = false;
                }
            }
        }
        void pattern56()
        {
            if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!A3.Enabled))
            {
                check56 = false; textBox1.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox1.Text = "X"; textBox1.BackColor = Color.Blue; textBox1.Enabled = false;
                }
                else
                {
                    textBox1.Text = "O"; textBox1.BackColor = Color.Red; textBox1.Enabled = false;
                }
            }
        }
        void pattern57()
        {
            if ((A4.Text == B5.Text) && (B5.Text == C6.Text) && (!A4.Enabled))
            {
                check57 = false; textBox2.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox2.Text = "X"; textBox2.BackColor = Color.Blue; textBox2.Enabled = false;
                }
                else
                {
                    textBox2.Text = "O"; textBox2.BackColor = Color.Red; textBox2.Enabled = false;
                }
            }
        }
        void pattern58()
        {
            if ((A6.Text == B5.Text) && (B5.Text == C4.Text) && (!A6.Enabled))
            {
                check58 = false; textBox2.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox2.Text = "X"; textBox2.BackColor = Color.Blue; textBox2.Enabled = false;
                }
                else
                {
                    textBox2.Text = "O"; textBox2.BackColor = Color.Red; textBox2.Enabled = false;
                }
            }
        }
        void pattern59()
        {
            if ((A7.Text == B8.Text) && (B8.Text == C9.Text) && (!A7.Enabled))
            {
                check59 = false; textBox3.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox3.Text = "X"; textBox3.BackColor = Color.Blue; textBox3.Enabled = false;
                }
                else
                {
                    textBox3.Text = "O"; textBox3.BackColor = Color.Red; textBox3.Enabled = false;
                }
            }
        }
        void pattern60()
        {
            if ((A9.Text == B8.Text) && (B8.Text == C7.Text) && (!A9.Enabled))
            {
                check60 = false; textBox3.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox3.Text = "X"; textBox3.BackColor = Color.Blue; textBox3.Enabled = false;
                }
                else
                {
                    textBox3.Text = "O"; textBox3.BackColor = Color.Red; textBox3.Enabled = false;
                }
            }
        }
        void pattern61()
        {
            if ((D1.Text == E2.Text) && (E2.Text == F3.Text) && (!D1.Enabled))
            {
                check61 = false; textBox4.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox4.Text = "X"; textBox4.BackColor = Color.Blue; textBox4.Enabled = false;
                }
                else
                {
                    textBox4.Text = "O"; textBox4.BackColor = Color.Red; textBox4.Enabled = false;
                }
            }
        }
        void pattern62()
        {
            if ((D3.Text == E2.Text) && (E2.Text == F1.Text) && (!D3.Enabled))
            {
                check62 = false; textBox4.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox4.Text = "X"; textBox4.BackColor = Color.Blue; textBox4.Enabled = false;
                }
                else
                {
                    textBox4.Text = "O"; textBox4.BackColor = Color.Red; textBox4.Enabled = false;
                }
            }
        }
        void pattern63()
        {
            if ((D4.Text == E5.Text) && (E5.Text == F6.Text) && (!D4.Enabled))
            {
                check63 = false; textBox5.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox5.Text = "X"; textBox5.BackColor = Color.Blue; textBox5.Enabled = false;
                }
                else
                {
                    textBox5.Text = "O"; textBox5.BackColor = Color.Red; textBox5.Enabled = false;
                }
            }
        }
        void pattern64()
        {
            if ((D6.Text == E5.Text) && (E5.Text == F4.Text) && (!D6.Enabled))
            {
                check64 = false; textBox5.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox5.Text = "X"; textBox5.BackColor = Color.Blue; textBox5.Enabled = false;
                }
                else
                {
                    textBox5.Text = "O"; textBox5.BackColor = Color.Red; textBox5.Enabled = false;
                }
            }
        }
        void pattern65()
        {
            if ((D7.Text == E8.Text) && (E8.Text == F9.Text) && (!D7.Enabled))
            {
                check65 = false; textBox6.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox6.Text = "X"; textBox6.BackColor = Color.Blue; textBox6.Enabled = false;
                }
                else
                {
                    textBox6.Text = "O"; textBox6.BackColor = Color.Red; textBox6.Enabled = false;
                }
            }
        }
        void pattern66()
        {
            if ((D9.Text == E8.Text) && (E8.Text == F7.Text) && (!D9.Enabled))
            {
                check66 = false; textBox6.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox6.Text = "X"; textBox6.BackColor = Color.Blue; textBox6.Enabled = false;
                }
                else
                {
                    textBox6.Text = "O"; textBox6.BackColor = Color.Red; textBox6.Enabled = false;
                }
            }
        }
        void pattern67()
        {
            if ((G1.Text == H2.Text) && (H2.Text == I3.Text) && (!G1.Enabled))
            {
                check67 = false; textBox7.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox7.Text = "X"; textBox7.BackColor = Color.Blue; textBox7.Enabled = false;
                }
                else
                {
                    textBox7.Text = "O"; textBox7.BackColor = Color.Red; textBox7.Enabled = false;
                }
            }
        }
        void pattern68()
        {
            if ((G3.Text == H2.Text) && (H2.Text == I1.Text) && (!G3.Enabled))
            {
                check68 = false; textBox7.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox7.Text = "X"; textBox7.BackColor = Color.Blue; textBox7.Enabled = false;
                }
                else
                {
                    textBox7.Text = "O"; textBox7.BackColor = Color.Red; textBox7.Enabled = false;
                }
            }
        }
        void pattern69()
        {
            if ((G4.Text == H5.Text) && (H5.Text == I6.Text) && (!G4.Enabled))
            {
                check69 = false; textBox8.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox8.Text = "X"; textBox8.BackColor = Color.Blue; textBox8.Enabled = false;
                }
                else
                {
                    textBox8.Text = "O"; textBox8.BackColor = Color.Red; textBox8.Enabled = false;
                }
            }
        }
        void pattern70()
        {
            if ((G6.Text == H5.Text) && (H5.Text == I4.Text) && (!G6.Enabled))
            {
                check70 = false; textBox8.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox8.Text = "X"; textBox8.BackColor = Color.Blue; textBox8.Enabled = false;
                }
                else
                {
                    textBox8.Text = "O"; textBox8.BackColor = Color.Red; textBox8.Enabled = false;
                }
            }
        }
        void pattern71()
        {
            if ((G7.Text == H8.Text) && (H8.Text == I9.Text) && (!G7.Enabled))
            {
                check71 = false; textBox9.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox9.Text = "X"; textBox9.BackColor = Color.Blue; textBox9.Enabled = false;
                }
                else
                {
                    textBox9.Text = "O"; textBox9.BackColor = Color.Red; textBox9.Enabled = false;
                }
            }
        }
        void pattern72()
        {
            if ((G9.Text == H8.Text) && (H8.Text == I7.Text) && (!G9.Enabled))
            {
                check72 = false; textBox9.Visible = true; textbox_count++;
                if (!turn)
                {
                    textBox9.Text = "X"; textBox9.BackColor = Color.Blue; textBox9.Enabled = false;
                }
                else
                {
                    textBox9.Text = "O"; textBox9.BackColor = Color.Red; textBox9.Enabled = false;
                }
            }
        }


        /// ////

        void pattern73()
        {
            if ((textBox1.Text == textBox2.Text) && (textBox2.Text == textBox3.Text) && textBox1.Visible == true)
            {
                one_point = true;
            }
        }
        void pattern74()
        {
            if ((textBox4.Text == textBox5.Text) && (textBox5.Text == textBox6.Text) && textBox4.Visible == true)
            {
                one_point = true;
            }
        }
        void pattern75()
        {
            if ((textBox7.Text == textBox8.Text) && (textBox8.Text == textBox9.Text) && textBox7.Visible == true)
            {
                one_point = true;
            }
        }
        void pattern76()
        {
            if ((textBox1.Text == textBox4.Text) && (textBox4.Text == textBox7.Text) && textBox1.Visible == true)
            {
                one_point = true;
            }
        }
        void pattern77()
        {
            if ((textBox2.Text == textBox5.Text) && (textBox5.Text == textBox8.Text) && textBox2.Visible == true)
            {
                one_point = true;
            }
        }
        void pattern78()
        {
            if ((textBox3.Text == textBox6.Text) && (textBox6.Text == textBox9.Text) && textBox3.Visible == true)
            {
                one_point = true;
            }
        }
        void pattern79()
        {
            if ((textBox1.Text == textBox5.Text) && (textBox5.Text == textBox9.Text) && textBox1.Visible == true)
            {
                one_point = true;
            }
        }
        void pattern80()
        {
            if ((textBox3.Text == textBox5.Text) && (textBox5.Text == textBox7.Text) && textBox3.Visible == true)
            {
                one_point = true;
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
                foreach (Button c in panelBoard5.Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                    
                }
                foreach (Button c in panelBoard6.Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                    
                }
                foreach (Button c in panelBoard7.Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                    
                }
                foreach (Button c in panelBoard8.Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                    
                }
                foreach (Button c in panelBoard9.Controls)
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

        private void btnSettings_Click(object sender, EventArgs e)
        {
            btnLeaderBoard.Show(); btnSounds.Show(); btnHelp.Show(); btnSounds2.Show(); btnSettings.Enabled = false;
            btnCredits.Show();
        }

        private void btnLeaderBoard_Click(object sender, EventArgs e)
        {
            Leaderboard l = new Leaderboard();
            l.Show();
            this.Hide();
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

        private void Form3_Load(object sender, EventArgs e)
        {
            MainMenu.getplayer.controls.stop();
            Form1.getplayer.controls.stop();
            Form2.getplayer.controls.stop();

            player.URL = @"C:\Users\LENOVO\Desktop\tictactoe\tictactoe\Resources\ticresources\BG Music\Hard.mp3";
            player.controls.play();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure to start a new game?", "New Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                turn = true;
                turn_count = 0; textbox_count = 0;

                one_point = false;
                check1 = true; check2 = true; check3 = true; check4 = true; check5 = true; check6 = true; check7 = true; check8 = true;
                check9 = true; check10 = true; check11 = true; check12 = true; check13 = true; check14 = true; check15 = true; check16 = true;
                check17 = true; check18 = true; check19 = true; check20 = true; check21 = true; check22 = true; check23 = true; check24 = true;
                check25 = true; check26 = true; check27 = true; check28 = true; check29 = true; check30 = true; check31 = true; check32 = true;
                check33 = true; check34 = true; check35 = true; check36 = true; check37 = true; check38 = true; check39 = true; check40 = true;
                check41 = true; check42 = true; check43 = true; check44 = true; check45 = true; check46 = true; check47 = true; check48 = true;
                check49 = true; check50 = true; check51 = true; check52 = true; check53 = true; check54 = true; check55 = true; check56 = true; check57 = true; check58 = true; check59 = true; check60 = true; check61 = true; check62 = true; check63 = true; check64 = true; check65 = true; check66 = true; check67 = true; check68 = true; check69 = true; check70 = true; check71 = true; check72 = true;
                check73 = true; check74 = true; check75 = true; check76 = true; check77 = true; check78 = true; check79 = true; check80 = true;
                score1 = 0; score2 = 0;

                foreach (Button c in panelBoard.Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                    b.BackColor = Color.WhiteSmoke;
                }
                foreach (Button c in panelBoard2.Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                    b.BackColor = Color.WhiteSmoke;
                }
                foreach (Button c in panelBoard3.Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                    b.BackColor = Color.WhiteSmoke;
                }
                foreach (Button c in panelBoard4.Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                    b.BackColor = Color.WhiteSmoke;
                }
                foreach (Button c in panelBoard5.Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                    b.BackColor = Color.WhiteSmoke;
                }
                foreach (Button c in panelBoard6.Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                    b.BackColor = Color.WhiteSmoke;
                }
                foreach (Button c in panelBoard7.Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                    b.BackColor = Color.WhiteSmoke;
                }
                foreach (Button c in panelBoard8.Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                    b.BackColor = Color.WhiteSmoke;
                }
                foreach (Button c in panelBoard9.Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                    b.BackColor = Color.WhiteSmoke;
                }

                textBox1.Enabled = true; textBox2.Enabled = true; textBox3.Enabled = true; textBox4.Enabled = true; textBox5.Enabled = true;
                textBox6.Enabled = true; textBox7.Enabled = true; textBox8.Enabled = true; textBox9.Enabled = true;
                textBox1.Visible = false; textBox2.Visible = false; textBox3.Visible = false; textBox4.Visible = false; textBox5.Visible = false;
                textBox6.Visible = false; textBox7.Visible = false; textBox8.Visible = false; textBox9.Visible = false;
                textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = ""; textBox4.Text = ""; textBox5.Text = ""; textBox6.Text = "";
                textBox7.Text = ""; textBox8.Text = ""; textBox9.Text = "";
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quit Game?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                player.URL = @"C:\Users\LENOVO\Desktop\tictactoe\tictactoe\Resources\ticresources\BG Music\Hard.mp3";
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

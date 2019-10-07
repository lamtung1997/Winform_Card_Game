using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Card_Match
{
    public partial class Frm_Level_4 : Form
    {
        #region Declare Variables
        Label[] Card = new Label[Play.Number_Of_Card];

        Bitmap[] Pic = new Bitmap[Play.Number_Of_Card];
        Bitmap[] Pic_Card = new Bitmap[Play.Number_Of_Card];

        Bitmap Pic_Default = new Bitmap(Directory.GetCurrentDirectory() + "\\Resources\\Images\\" + Play.Back_Side);

        int First_Card_ID = -1, Second_Card_ID = -1;
        int First_Pic_ID, Second_Pic_ID;

        int Click_Card_ID = -1;

        int[] Pic_Card_ID = new int[Play.Number_Of_Card];

        int Count = 0;
        int Correct_Count = 0;

        string Str_Break_Record = "";
        int Score;
        int Minus_Score = 0;
        int Help_First, Help_Second;

        String Str_Time_Play;
        int Time_Second = 0;
        int Time_Minute = 0;
        #endregion

        public Frm_Level_4()
        {
            BackgroundImage = new Bitmap(Directory.GetCurrentDirectory() + "\\Resources\\Images\\" + Play.Back_Ground);
            InitializeComponent();
        }
        
        private void Frm_Level_1_Load(object sender, EventArgs e)
        {
            # region Load Image To Buttons

            btn_Add_10.BackgroundImage = Play.Button_Image;
            btn_Add_20.BackgroundImage = Play.Button_Image;
            btn_Add_25.BackgroundImage = Play.Button_Image;
            btn_Continue.BackgroundImage = Play.Button_Image;
            btn_Done.BackgroundImage = Play.Button_Image;
            btn_Give_Up.BackgroundImage = Play.Button_Image;
            btn_Help.BackgroundImage = Play.Button_Image;
            btn_Next.BackgroundImage = Play.Button_Image;
            btn_Pause.BackgroundImage = Play.Button_Image;
            btn_Restart.BackgroundImage = Play.Button_Image;
            btn_Slow_Time.BackgroundImage = Play.Button_Image;
            lbl_Time.Image = Play.Button_Image;

            #endregion

            if (Play.Gold > 200)
            {
                btn_Add_10.Enabled = true;
            }
            if (Play.Gold > 500)
            {
                btn_Add_20.Enabled = true;
            }
            if (Play.Gold > 1000)
            {
                btn_Add_25.Enabled = true;
            }
            if (Play.Gold > 1500)
            {
                btn_Slow_Time.Enabled = true;
            }

            Play.Item_Increase_Point = 5000;
            Timer.Interval = 1000;

            // icon cho form
            Icon = Play.Play_Icon;

            // ##
            #region Add Labels To Array

            Card[0] = Card_0;
            Card[1] = Card_1;
            Card[2] = Card_2;
            Card[3] = Card_3;
            Card[4] = Card_4;
            Card[5] = Card_5;
            Card[6] = Card_6;
            Card[7] = Card_7;
            Card[8] = Card_8;
            Card[9] = Card_9;
            Card[10] = Card_10;
            Card[11] = Card_11;
            Card[12] = Card_12;
            Card[13] = Card_13;
            Card[14] = Card_14;
            Card[15] = Card_15;
            Card[16] = Card_16;
            Card[17] = Card_17;
            Card[18] = Card_18;
            Card[19] = Card_19;
            Card[20] = Card_20;
            Card[21] = Card_21;
            Card[22] = Card_22;
            Card[23] = Card_23;

            #endregion

            Random rnd = new Random();
            Pic_Card_ID = Enumerable.Range(0, Play.Number_Of_Card).OrderBy(r => rnd.Next()).ToArray();

            for (int i = 0; i < Play.Number_Of_Card; i++)
            {
                Pic[i] = new Bitmap(Directory.GetCurrentDirectory() + "\\Resources\\" + Play.Mode_Easy_Difficult + "\\" + Play.Level + "\\" + i.ToString() + ".jpg");
            }

            for (int i = 0; i < Play.Number_Of_Card; i++)
            {
                for (int j = 0; j < Play.Number_Of_Card; j++)
                {
                    if (Pic_Card_ID[i] == j) Pic_Card[i] = Pic[j];
                }
            }
            
            for (int i = 0; i < Play.Number_Of_Card; i++)
            {
                Card[i].Image = Pic_Default;
            }

            StreamReader sr = new StreamReader(Directory.GetCurrentDirectory() + "\\Resources\\Records\\records4.bin");
            Play.Record = Int16.Parse(sr.ReadLine());
            sr.Close();
            lbl_Record.Text = "Record:\n" + Play.Record.ToString();

            Timer.Start();

            lbl_Gold.Text = "Your Gold:\n" + Play.Gold.ToString();
        }

        #region Card Click            ##
        private void Card_0_Click(object sender, EventArgs e)
        {
            Click_Card_ID = 0;
            Open_Card();
        }

        private void Card_1_Click(object sender, EventArgs e)
        {
            Click_Card_ID = 1;
            Open_Card();
        }

        private void Card_2_Click(object sender, EventArgs e)
        {
            Click_Card_ID = 2;
            Open_Card();
        }

        private void Card_3_Click(object sender, EventArgs e)
        {
            Click_Card_ID = 3;
            Open_Card();
        }

        private void Card_4_Click(object sender, EventArgs e)
        {
            Click_Card_ID = 4;
            Open_Card();
        }

        private void Card_5_Click(object sender, EventArgs e)
        {
            Click_Card_ID = 5;
            Open_Card();
        }

        private void Card_6_Click(object sender, EventArgs e)
        {
            Click_Card_ID = 6;
            Open_Card();
        }

        private void Card_7_Click(object sender, EventArgs e)
        {
            Click_Card_ID = 7;
            Open_Card();
        }

        private void Card_8_Click(object sender, EventArgs e)
        {
            Click_Card_ID = 8;
            Open_Card();
        }
 
        private void Card_9_Click(object sender, EventArgs e)
        {
            Click_Card_ID = 9;
            Open_Card();
        }

        private void Card_10_Click(object sender, EventArgs e)
        {
            Click_Card_ID = 10;
            Open_Card();
        }

        private void Card_11_Click(object sender, EventArgs e)
        {
            Click_Card_ID = 11;
            Open_Card();
        }

        private void Card_12_Click(object sender, EventArgs e)
        {
            Click_Card_ID = 12;
            Open_Card();
        }

        private void Card_13_Click(object sender, EventArgs e)
        {
            Click_Card_ID = 13;
            Open_Card();
        }

        private void Card_14_Click(object sender, EventArgs e)
        {
            Click_Card_ID = 14;
            Open_Card();
        }

        private void Card_15_Click(object sender, EventArgs e)
        {
            Click_Card_ID = 15;
            Open_Card();
        }

        private void Card_16_Click(object sender, EventArgs e)
        {
            Click_Card_ID = 16;
            Open_Card();
        }

        private void Card_17_Click(object sender, EventArgs e)
        {
            Click_Card_ID = 17;
            Open_Card();
        }

        private void Card_18_Click(object sender, EventArgs e)
        {
            Click_Card_ID = 18;
            Open_Card();
        }

        private void Card_19_Click(object sender, EventArgs e)
        {
            Click_Card_ID = 19;
            Open_Card();
        }

        private void Card_20_Click(object sender, EventArgs e)
        {
            Click_Card_ID = 20;
            Open_Card();
        }

        private void Card_21_Click(object sender, EventArgs e)
        {
            Click_Card_ID = 21;
            Open_Card();
        }

        private void Card_22_Click(object sender, EventArgs e)
        {
            Click_Card_ID = 22;
            Open_Card();
        }

        private void Card_23_Click(object sender, EventArgs e)
        {
            Click_Card_ID = 23;
            Open_Card();
        }

        #endregion

        private void Open_Card()
        {
            Play.Click_Sound.Play();
            if (First_Card_ID == -1)
            {
                Card[Click_Card_ID].Image = Pic_Card[Click_Card_ID];
                First_Card_ID = Click_Card_ID;
                First_Pic_ID = Pic_Card_ID[Click_Card_ID];
            }
            else if (Second_Card_ID == -1)
            {
                Card[Click_Card_ID].Image = Pic_Card[Click_Card_ID];
                Second_Card_ID = Click_Card_ID;
                Second_Pic_ID = Pic_Card_ID[Click_Card_ID];
                Check_Two_Card();
            }
        }

        private void Check_Two_Card()
        {
            if (First_Pic_ID + Second_Pic_ID == Play.Number_Of_Card - 1)
            {
                lbl_Notification.Text = "Correct";

                Correct_Count++;
                var t = Task.Delay(500);
                t.Wait();
                Play.Tack_Sound.Play();

                for (int i = 0; i < Play.Number_Of_Card; i++)
                {
                    if (First_Card_ID == i) Card[i].Hide();
                }

                for (int i = 0; i < Play.Number_Of_Card; i++)
                {
                    if (Second_Card_ID == i) Card[i].Hide();
                }

                lbl_Notification.Text = null;
            }
            else
            {
                lbl_Notification.Text = "Wrong !!!";

                var t = Task.Delay(500);
                t.Wait();

                for (int i = 0; i < Play.Number_Of_Card; i++)
                {
                    Card[i].Image = Pic_Default;
                }

                lbl_Notification.Text = null;
            }

            Count++;
            lbl_Turns.Text = "Your Turns:\n" + Count.ToString();
            lbl_Remain.Text = "Remains:\n" + (Play.Number_Of_Card/2 - Correct_Count).ToString();

            if (Correct_Count == Play.Number_Of_Card/2)
            {
                Timer.Stop();
                Score = (Play.Number_Of_Card * 100 - Count * 10 - Time_Minute * 60 * 5 - Time_Second * 5)*Play.Multiplier - Minus_Score;
                Score = Score + Score / Play.Item_Increase_Point;

                if (Score > Play.Record)
                {
                    Play.Break_Record.Play();
                    Str_Break_Record = "You broke the record";
                    StreamWriter sw = new StreamWriter(Directory.GetCurrentDirectory() + "\\Resources\\Records\\records4.bin");
                    sw.WriteLine(Score.ToString());
                    sw.Close();
                }
                if (Score < 0)
                {
                    Score = 0;
                    Str_Break_Record = "You Use Too Much Help !!!";
                }

                Play.Gold = Play.Gold + Score / 10;

                lbl_End.Text = "Congratulation\nYour Score: " + Score.ToString() + "\n\n" + Str_Break_Record;
                lbl_End.Visible = true;
                btn_Done.Enabled = true;
                btn_Next.Enabled = true;
                btn_Help.Enabled = false;
                btn_Give_Up.Enabled = false;
                btn_Pause.Enabled = false;
                btn_Continue.Enabled = false;
            }

            First_Card_ID = -1;
            Second_Card_ID = -1;
        }

        #region Button Click

        private void btn_Give_Up_Click(object sender, EventArgs e)
        {
            Play.Click_Sound.Play();
            Close();
        }

        private void Btn_Restart_Click(object sender, EventArgs e)          // ##
        {
            Frm_Level_4 _f = new Frm_Level_4();
            _f.ShowDialog();
            Close();
        }

        private void btn_Help_Click(object sender, EventArgs e)
        {
            Play.Click_Sound.Play();
            Minus_Score = Minus_Score + 50;
            Random rand = new Random();
            while (Help_First == Help_Second)
            {
                Help_First = rand.Next(0, Play.Number_Of_Card - 1);
            }
            Card[Help_First].Image = Pic_Card[Help_First];
            Help_Second = Help_First;

        }

        private void btn_Next_Click(object sender, EventArgs e)      // ##
        {
            Play.Click_Sound.Play();
            Play.Click_Sound.Play();
            Play.Number_Of_Card = 36;
            Play.Level = "5";
            Frm_Level_5 _f = new Frm_Level_5();
            _f.Show();
            Hide();
        }

        private void btn_Pause_Click(object sender, EventArgs e)
        {
            Timer.Stop();
            btn_Continue.Enabled = true;
            btn_Pause.Enabled = false;
            lbl_End.Show();
            lbl_End.Text = "Take a break";
        }

        private void btn_Continue_Click(object sender, EventArgs e)
        {
            Timer.Start();
            btn_Continue.Enabled = false;
            btn_Pause.Enabled = true;
            lbl_End.Hide();
        }

        private void btn_Add_10_Click(object sender, EventArgs e)
        {
            Play.Item_Increase_Point = 10;
            Play.Gold = Play.Gold - 200;
            lbl_Gold.Text = "Your Gold:\n" + Play.Gold.ToString();
            btn_Add_10.Visible = false;
        }

        private void btn_Add_20_Click(object sender, EventArgs e)
        {
            Play.Item_Increase_Point = 5;
            Play.Gold = Play.Gold - 500;
            lbl_Gold.Text = "Your Gold:\n" + Play.Gold.ToString();
            btn_Add_20.Visible = false;
        }

        private void btn_Add_25_Click(object sender, EventArgs e)
        {
            Play.Item_Increase_Point = 4;
            Play.Gold = Play.Gold - 1000;
            lbl_Gold.Text = "Your Gold:\n" + Play.Gold.ToString();
            btn_Add_25.Visible = false;
        }

        private void btn_Slow_Time_Click(object sender, EventArgs e)
        {
            Timer.Interval = 2000;
            Play.Gold = Play.Gold - 1500;
            lbl_Gold.Text = "Your Gold:\n" + Play.Gold.ToString();
            btn_Slow_Time.Visible = false;
        }

        private void btn_Done_Click(object sender, EventArgs e)
        {
            Play.Click_Sound.Play();
            Close();
        }

        #endregion

        private void Timer_Tick(object sender, EventArgs e)
        {
            Time_Second++;
            if (Time_Second == 60)
            {
                Time_Second = 0;
                Time_Minute++;
            }
            Str_Time_Play = Time_Minute.ToString() + " : " + Time_Second.ToString();
            lbl_Time.Text = Str_Time_Play;
        }
    }
}
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
    public partial class Frm_Level_1 : Form
    {
        #region Declare Variables
        // khai báo mảng gồm 4 label
        Label[] Card = new Label[Play.Number_Of_Card];

        // khai báo mảng Pic gồm 4 phần tử (lưu ảnh có sẵn), mảng Pic_Card gồm 4 phần tử (lưu ảnh của thẻ)
        Bitmap[] Pic = new Bitmap[Play.Number_Of_Card];
        Bitmap[] Pic_Card = new Bitmap[Play.Number_Of_Card];

        // khai báo ảnh mặc định
        Bitmap Pic_Default = new Bitmap(Directory.GetCurrentDirectory() + "\\Resources\\Images\\" + Play.Back_Side);

        // đặt thẻ đầu = -1, thẻ sau = -1 nghĩa là 2 thẻ chưa được lật
        int First_Card_ID = -1, Second_Card_ID = -1;
        int First_Pic_ID, Second_Pic_ID;

        // bấm vào thẻ nào thì biến này lưu ID thẻ đó
        int Click_Card_ID = -1;

        // mảng Pic_Card_ID là mảng để lưu ID của ảnh trong thẻ
        int[] Pic_Card_ID = new int[Play.Number_Of_Card];

        // biến đếm lần lật, đếm lần lật đúng, điểm
        int Count = 0;
        int Correct_Count = 0;

        // biến điểm, kỷ lục, trợ giúp
        string Str_Break_Record = "";
        int Score;
        int Minus_Score = 0;
        int Help_First, Help_Second;

        // xâu lưu thời gian chơi, biến phút, biến giây
        String Str_Time_Play;
        int Time_Second = 0;
        int Time_Minute = 0;
        #endregion

        public Frm_Level_1()
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

            // ẩn hiên các Item
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

            // đặt 4 label đã tạo vào 4 biến trong mảng Card    #Khác_Nhau
            #region Add Labels To Array
            Card[0] = Card_0;
            Card[1] = Card_1;
            Card[2] = Card_2;
            Card[3] = Card_3;
            #endregion

            // sinh 1 dãy số bất kỳ từ 4 số 0,1,2,3 lưu vào mảng Pic_Card_ID
            Random rnd = new Random();
            Pic_Card_ID = Enumerable.Range(0, Play.Number_Of_Card).OrderBy(r => rnd.Next()).ToArray();

            // load ảnh vào các biến Pic (Cố định không thay đổi)
            for (int i = 0; i < Play.Number_Of_Card; i++)
            {
                Pic[i] = new Bitmap(Directory.GetCurrentDirectory() + "\\Resources\\" + Play.Mode_Easy_Difficult + "\\" + Play.Level + "\\" + i.ToString() + ".jpg");
            }

            // cho 4 ảnh ngẫu nhiên vào 4 biến Pic_Card
            for (int i = 0; i < Play.Number_Of_Card; i++)
            {
                for (int j = 0; j < Play.Number_Of_Card; j++)
                {
                    if (Pic_Card_ID[i] == j) Pic_Card[i] = Pic[j];
                }
            }

            // cài ảnh mặc định cho 4 thẻ
            for (int i = 0; i < Play.Number_Of_Card; i++)
            {
                Card[i].Image = Pic_Default;
            }

            // hiện kỷ lục
            StreamReader sr = new StreamReader(Directory.GetCurrentDirectory() + "\\Resources\\Records\\Records.bin");
            Play.Record = Int16.Parse(sr.ReadLine());
            sr.Close();
            lbl_Record.Text = "Record:\n" + Play.Record.ToString();

            // cho thời gian bắt đầu chạy
            Timer.Start();

            // label Gold
            lbl_Gold.Text = "Your Gold:\n" + Play.Gold.ToString();
        }

        #region Card Click
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
        #endregion  // #Khác_Nhau

        private void Open_Card()
        {
            Play.Click_Sound.Play();
            // nếu ảnh đầu chưa lật thì lật lên
            if (First_Card_ID == -1)
            {
                Card[Click_Card_ID].Image = Pic_Card[Click_Card_ID];
                First_Card_ID = Click_Card_ID;
                First_Pic_ID = Pic_Card_ID[Click_Card_ID];
            }
            // nếu ảnh sau chưa lật thì lật lên
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
            // nếu lật đúng
            if (First_Pic_ID + Second_Pic_ID == Play.Number_Of_Card - 1)
            {
                // hiện thông báo ở lbl_notification
                lbl_Notification.Text = "Correct";

                // dừng nửa giây, tăng số lần lật đúng
                Correct_Count++;
                var t = Task.Delay(500);
                t.Wait();
                Play.Tack_Sound.Play();

                // ẩn thẻ đầu
                for (int i = 0; i < Play.Number_Of_Card; i++)
                {
                    if (First_Card_ID == i) Card[i].Hide();
                }

                // ẩn thẻ sau
                for (int i = 0; i < Play.Number_Of_Card; i++)
                {
                    if (Second_Card_ID == i) Card[i].Hide();
                }

                // ẩn thông báo ở lbl_notification
                lbl_Notification.Text = null;
            }

            // nếu lật sai
            else
            {
                // hiện thông báo ở lbl_notification
                lbl_Notification.Text = "Wrong !!!";

                // dừng nửa giây
                var t = Task.Delay(500);
                t.Wait();

                // úp tất cả các thẻ
                for (int i = 0; i < Play.Number_Of_Card; i++)
                {
                    Card[i].Image = Pic_Default;
                }

                // ẩn thông báo ở lbl_notification
                lbl_Notification.Text = null;
            }

            // tăng số lần lật ô
            Count++;
            lbl_Turns.Text = "Your Turns:\n" + Count.ToString();
            lbl_Remain.Text = "Remains:\n" + (Play.Number_Of_Card/2 - Correct_Count).ToString();

            // nếu số lần lật đúng là 2 (là chơi xong) thì dừng thời gian, show điểm
            if (Correct_Count == Play.Number_Of_Card/2)
            {
                Timer.Stop();
                Score = (Play.Number_Of_Card * 100 - Count * 10 - Time_Minute * 60 * 5 - Time_Second * 5)*Play.Multiplier - Minus_Score;
                Score = Score + Score / Play.Item_Increase_Point;

                // ghi điểm cao vào file
                if (Score > Play.Record)
                {
                    Play.Break_Record.Play();
                    Str_Break_Record = "You broke the record";
                    StreamWriter sw = new StreamWriter(Directory.GetCurrentDirectory() + "\\Resources\\Records\\Records.bin");
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

            // cho ID thẻ đầu và ID thẻ sau về -1 (nghĩa là úp xuống)
            First_Card_ID = -1;
            Second_Card_ID = -1;
        }

        #region Button Click

        private void btn_Give_Up_Click(object sender, EventArgs e)
        {
            Play.Click_Sound.Play();
            Close();
        }

        private void Btn_Restart_Click(object sender, EventArgs e)          // # Khác_Nhau
        {
            Frm_Level_1 _f = new Frm_Level_1();
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

        private void btn_Next_Click(object sender, EventArgs e)      // # Khác_Nhau
        {
            Play.Click_Sound.Play();
            Play.Number_Of_Card = 8;
            Play.Level = "2";
            Frm_Level_2 _f = new Frm_Level_2();
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
            // bấm vào nút Done là thoát Form này
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

            // label chỉ thời gian hiển thị số phút + số giây
            Str_Time_Play = Time_Minute.ToString() + " : " + Time_Second.ToString();
            lbl_Time.Text = Str_Time_Play;
        }
    }
}
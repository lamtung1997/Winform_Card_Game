using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Card_Match
{
    public partial class Frm_Start : Form
    {
        int Number_Of_Click = 0;

        public Frm_Start()
        {
            InitializeComponent();

            btn_Lv_1.Hide();
            btn_Lv_2.Hide();
            btn_Lv_3.Hide();
            btn_Lv_4.Hide();
            btn_Lv_5.Hide();
            btn_Mean.Hide();

            Icon = Play.Play_Icon;

            lbl_Gold.Text = "Your gold:\n" + Play.Gold.ToString();

            BackgroundImage = new Bitmap(Directory.GetCurrentDirectory() + "\\Resources\\Images\\" + Play.Back_Ground);

            #region Load Image To Buttons

            btn_10.BackgroundImage = Play.Button_Image;
            btn_20.BackgroundImage = Play.Button_Image;
            btn_25.BackgroundImage = Play.Button_Image;
            btn_Mean.BackgroundImage = Play.Button_Image;
            btn_Back.BackgroundImage = Play.Button_Image;
            btn_Back_2.BackgroundImage = Play.Button_Image;
            btn_Difficult.BackgroundImage = Play.Button_Image;
            btn_Easy.BackgroundImage = Play.Button_Image;
            btn_Item.BackgroundImage = Play.Button_Image;
            btn_Lv_1.BackgroundImage = Play.Button_Image;
            btn_Lv_2.BackgroundImage = Play.Button_Image;
            btn_Lv_3.BackgroundImage = Play.Button_Image;
            btn_Lv_4.BackgroundImage = Play.Button_Image;
            btn_Lv_5.BackgroundImage = Play.Button_Image;
            btn_Time_Slow.BackgroundImage = Play.Button_Image;
            lbl_Gold.Image = Play.Button_Image;

            #endregion
        }

        #region Button CLick

        private void btn_Easy_Click(object sender, EventArgs e)
        {
            Play.Mode_Easy_Difficult = "Easy";
            Play.Multiplier = 1;

            btn_Easy.Hide();
            btn_Difficult.Hide();
            btn_Item.Hide();

            btn_Lv_1.Show();
            btn_Lv_2.Show();
            btn_Lv_3.Show();
            btn_Lv_4.Show();
            btn_Lv_5.Show();
            btn_Back_2.Show();

            btn_Back.Hide();
            btn_10.Hide();
            btn_20.Hide();
            btn_25.Hide();
            btn_Time_Slow.Hide();
        }

        private void btn_Difficult_Click(object sender, EventArgs e)
        {
            Play.Mode_Easy_Difficult = "Difficult";
            Play.Multiplier = 2;

            btn_Easy.Hide();
            btn_Difficult.Hide();
            btn_Item.Hide();

            btn_Lv_1.Show();
            btn_Lv_2.Show();
            btn_Lv_3.Show();
            btn_Lv_4.Show();
            btn_Lv_5.Show();
            btn_Back_2.Show();

            btn_Back.Hide();
            btn_Back.Hide();
            btn_10.Hide();
            btn_20.Hide();
            btn_25.Hide();
            btn_Time_Slow.Hide();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Back_2_Click(object sender, EventArgs e)
        {
            btn_Lv_1.Hide();
            btn_Lv_2.Hide();
            btn_Lv_3.Hide();
            btn_Lv_4.Hide();
            btn_Lv_5.Hide();

            btn_Easy.Show();
            btn_Difficult.Show();
            btn_Item.Show();
            btn_Back.Show();

            btn_Back_2.Hide();
        }

        private void btn_Item_Click(object sender, EventArgs e)
        {
            Number_Of_Click++;
            if (Number_Of_Click%2 == 0)
            {
                btn_10.Hide();
                btn_20.Hide();
                btn_25.Hide();
                btn_Time_Slow.Hide();
            }
            else
            {
                btn_10.Show();
                btn_20.Show();
                btn_25.Show();
                btn_Time_Slow.Show();
            }
        }

        #endregion

        #region Item Bahavior

        private void btn_10_MouseLeave(object sender, EventArgs e)
        {
            btn_Mean.Hide();
        }

        private void btn_10_MouseMove(object sender, MouseEventArgs e)
        {
            btn_Mean.Show();
            btn_Mean.Text = "Increase your score by 10% \n Gold: 200";
        }

        private void btn_20_MouseMove(object sender, MouseEventArgs e)
        {
            btn_Mean.Show();
            btn_Mean.Text = "Increase your score by 20% \n Gold: 500";
        }

        private void btn_25_MouseMove(object sender, MouseEventArgs e)
        {
            btn_Mean.Show();
            btn_Mean.Text = "Increase your score by 25% \n Gold: 1000";
        }

        private void btn_Time_Slow_MouseMove(object sender, MouseEventArgs e)
        {
            btn_Mean.Show();
            btn_Mean.Text = "Make time slower \n Gold: 1500";
        }

        #endregion

        #region Level Click

        private void btn_Lv_1_Click(object sender, EventArgs e)
        {
            Play.Level = "1";
            Play.Number_Of_Card = 4;
            Frm_Level_1 _f = new Frm_Level_1();
            _f.ShowDialog();
        }

        private void btn_Lv_2_Click(object sender, EventArgs e)
        {
            Play.Level = "2";
            Play.Number_Of_Card = 8;
            Frm_Level_2 _f = new Frm_Level_2();
            _f.ShowDialog();
        }

        private void btn_Lv_3_Click(object sender, EventArgs e)
        {
            Play.Level = "3";
            Play.Number_Of_Card = 16;
            Frm_Level_3 _f = new Frm_Level_3();
            _f.ShowDialog();
        }

        private void btn_Lv_4_Click(object sender, EventArgs e)
        {
            Play.Level = "4";
            Play.Number_Of_Card = 24;
            Frm_Level_4 _f = new Frm_Level_4();
            _f.ShowDialog();
        }


        private void btn_Lv_5_Click(object sender, EventArgs e)
        {
            Play.Level = "5";
            Play.Number_Of_Card = 36;
            Frm_Level_5 _f = new Frm_Level_5();
            _f.ShowDialog();
        }

        #endregion
    }
}

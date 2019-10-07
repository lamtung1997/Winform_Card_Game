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
    public partial class Frm_Feed_Back : Form
    {
        Bitmap Star = new Bitmap(Directory.GetCurrentDirectory() + "\\Resources\\Feed_Back\\Star.png");
        Bitmap Yellow_Star = new Bitmap(Directory.GetCurrentDirectory() + "\\Resources\\Feed_Back\\YellowStar.png");
        Bitmap[] Emoji = new Bitmap[5];

        public Frm_Feed_Back()
        {
            InitializeComponent();

            btn_Back.BackgroundImage = Play.Button_Image;
            btn_Send.BackgroundImage = Play.Button_Image;

            Icon = Play.Play_Icon;
            BackgroundImage = new Bitmap(Directory.GetCurrentDirectory() + "\\Resources\\Images\\" + Play.Back_Ground);
            for (int i = 1;i<=5;i++)
            {
                Emoji[i-1] = new Bitmap(Directory.GetCurrentDirectory() + "\\Resources\\Feed_Back\\" + (i).ToString() + ".jpg");
            }

            lbl_Star_1.Image = Star;
            lbl_Star_2.Image = Star;
            lbl_Star_3.Image = Star;
            lbl_Star_4.Image = Star;
            lbl_Star_5.Image = Star;
        }
#region Button Click
        private void btn_Back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your feed back was sent to our email");
        }
        #endregion

#region Stars Behavior
        private void lbl_Star_1_MouseMove(object sender, MouseEventArgs e)
        {
            lbl_Star_1.Image = Yellow_Star;
            lbl_Satisfaction_Level.Text = "Very Poor";
            lbl_Emoji.Image = Emoji[0];
        }

        private void lbl_Star_1_MouseLeave(object sender, EventArgs e)
        {
            lbl_Star_1.Image = Star;
            lbl_Satisfaction_Level.Text = null;
            lbl_Emoji.Image = null;
        }

        private void lbl_Star_2_MouseMove(object sender, MouseEventArgs e)
        {
            lbl_Star_1.Image = Yellow_Star;
            lbl_Star_2.Image = Yellow_Star;

            lbl_Satisfaction_Level.Text = "Poor";
            lbl_Emoji.Image = Emoji[1];
        }

        private void lbl_Star_2_MouseLeave(object sender, EventArgs e)
        {
            lbl_Star_1.Image = Star;
            lbl_Star_2.Image = Star;

            lbl_Satisfaction_Level.Text = null;
            lbl_Emoji.Image = null;
        }

        private void lbl_Star_3_MouseMove(object sender, MouseEventArgs e)
        {
            lbl_Star_1.Image = Yellow_Star;
            lbl_Star_2.Image = Yellow_Star;
            lbl_Star_3.Image = Yellow_Star;

            lbl_Satisfaction_Level.Text = "Average";
            lbl_Emoji.Image = Emoji[2];
        }

        private void lbl_Star_3_MouseLeave(object sender, EventArgs e)
        {
            lbl_Star_1.Image = Star;
            lbl_Star_2.Image = Star;
            lbl_Star_3.Image = Star;

            lbl_Satisfaction_Level.Text = null;
            lbl_Emoji.Image = null;
        }

        private void lbl_Star_4_MouseMove(object sender, MouseEventArgs e)
        {
            lbl_Star_1.Image = Yellow_Star;
            lbl_Star_2.Image = Yellow_Star;
            lbl_Star_3.Image = Yellow_Star;
            lbl_Star_4.Image = Yellow_Star;

            lbl_Satisfaction_Level.Text = "Good";
            lbl_Emoji.Image = Emoji[3];
        }

        private void lbl_Star_4_MouseLeave(object sender, EventArgs e)
        {
            lbl_Star_1.Image = Star;
            lbl_Star_2.Image = Star;
            lbl_Star_3.Image = Star;
            lbl_Star_4.Image = Star;

            lbl_Satisfaction_Level.Text = null;
            lbl_Emoji.Image = null;
        }

        private void lbl_Star_5_MouseMove(object sender, MouseEventArgs e)
        {
            lbl_Star_1.Image = Yellow_Star;
            lbl_Star_2.Image = Yellow_Star;
            lbl_Star_3.Image = Yellow_Star;
            lbl_Star_4.Image = Yellow_Star;
            lbl_Star_5.Image = Yellow_Star;

            lbl_Satisfaction_Level.Text = "Excellent";
            lbl_Emoji.Image = Emoji[4];
        }

        private void lbl_Star_5_MouseLeave(object sender, EventArgs e)
        {
            lbl_Star_1.Image = Star;
            lbl_Star_2.Image = Star;
            lbl_Star_3.Image = Star;
            lbl_Star_4.Image = Star;
            lbl_Star_5.Image = Star;

            lbl_Satisfaction_Level.Text = null;
            lbl_Emoji.Image = null;
        }

        #endregion

        private void lbl_Star_1_Click(object sender, EventArgs e)
        {
            Hide_Star();
        }

        private void lbl_Star_2_Click(object sender, EventArgs e)
        {
            Hide_Star();
        }

        private void lbl_Star_3_Click(object sender, EventArgs e)
        {
            Hide_Star();
        }

        private void lbl_Star_4_Click(object sender, EventArgs e)
        {
            Hide_Star();
        }

        private void lbl_Star_5_Click(object sender, EventArgs e)
        {
            Hide_Star();
        }

        private void Hide_Star()
        {
            lbl_Star_1.Hide();
            lbl_Star_2.Hide();
            lbl_Star_3.Hide();
            lbl_Star_4.Hide();
            lbl_Star_5.Hide();

            tbox_Problem.Visible = true;
            tbox_Comment.Visible = true;

            btn_Send.Visible = true;

            lbl_Thank_You.Visible = true;
            lbl_Problem.Visible = true;
            lbl_Comment.Visible = true;

        }
    }
}

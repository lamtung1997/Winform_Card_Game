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
    public partial class Frm_Instruction : Form
    {
        public Frm_Instruction()
        {
            InitializeComponent();

            btn_Rule.BackgroundImage = Play.Button_Image;
            btn_Scoring_Method.BackgroundImage = Play.Button_Image;
            btn_Tips.BackgroundImage = Play.Button_Image;
            btn_Back.BackgroundImage = Play.Button_Image;

            Icon = Play.Play_Icon;
            BackgroundImage = new Bitmap(Directory.GetCurrentDirectory() + "\\Resources\\Images\\" + Play.Back_Ground);
        }

        private void btn_Rule_Click(object sender, EventArgs e)
        {
            tbox.Text = "When you flip two cards, if two cards have the same image, they will disappear and you will earn points. If two cards are not the same they will return to their original state. The game ends when you find all the pairs";
        }

        private void btn_Scoring_Method_Click(object sender, EventArgs e)
        {
            tbox.Text = "When you flip a pair correctly, you have 200 more points, when you flip a turn, you are subtracted 5 points, every second we subtract your 5 points.";
        }

        private void btn_Tips_Click(object sender, EventArgs e)
        {
            tbox.Text = "You should flip the cells in angled or corner positions, as you can easily memorize them, instead of having to memorize a card in the middle of the screen.";
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

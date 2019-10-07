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
    public partial class Frm_About_Us : Form
    {
        public Frm_About_Us()
        {
            InitializeComponent();

            BackgroundImage = new Bitmap(Directory.GetCurrentDirectory() + "\\Resources\\Images\\" + Play.Back_Ground);
            Icon = Play.Play_Icon;

            btn_Back.BackgroundImage = Play.Button_Image;
            btn_Our_Other_Products.BackgroundImage = Play.Button_Image;
            btn_Producer.BackgroundImage = Play.Button_Image;
            btn_Version.BackgroundImage = Play.Button_Image;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Version_Click(object sender, EventArgs e)
        {
            TextBox.Text = "Version 2.2:\r\n - Update theme and active items" + "\r\nVersion 2.1:\r\n - Fix bugs" + "\r\nVersion 2.0:\r\n - Update Sounds" + "\r\nVersion 1.5:\r\n - Update level 2,3,4,5" + "\r\nVersion 1:\r\n - No theme, just level 1";
        }

        private void btn_Producer_Click(object sender, EventArgs e)
        {
            TextBox.Text = "Group 4 Sami:\r\nCaptain: Nguyen Lam Tung\r\nAssistant: Nguyen Tuan Anh\r\nAssistant: Nguyen Van Kien";
        }

        private void btn_Our_Other_Products_Click(object sender, EventArgs e)
        {
            TextBox.Text = "League Of Legens New"
                + "\r\n - link: sa4mi.vn/LOL_New"
                + "\r\nHalf - Life"
                + "\r\n - link: s4mi.vn/HL1.6";
        }
    }
}

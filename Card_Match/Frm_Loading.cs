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
    public partial class Frm_Loading : Form
    {
        int Second = 0;

        public Frm_Loading()
        {
            InitializeComponent();
            Icon = Play.Play_Icon;
            BackgroundImage = new Bitmap(Directory.GetCurrentDirectory() + "\\Resources\\Images\\Back_Ground_Loading.jpg");
            Icon = new Icon(Directory.GetCurrentDirectory() + "\\Resources\\Icons\\Loading.ico");
        }

        private void Frm_Loading_Load(object sender, EventArgs e)
        {
            timer_progress_bar.Start();
            lbl_Click_To_Continue.Visible = false;
        }

        private void timer_progress_bar_Tick(object sender, EventArgs e)
        {
            Progress_Bar.Increment(1);
            Second++;
            if (Second == 110)
            {
                lbl_Loading.Text = null;
                Progress_Bar.Visible = false;
                lbl_Click_To_Continue.Visible = true;
            }
        }

        private void lbl_Click_To_Continue_Click(object sender, EventArgs e)
        {
            Frm_Menu _f = new Frm_Menu();
            _f.Show();
            Hide();
        }

    }
}

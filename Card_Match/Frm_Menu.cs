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
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
            BackgroundImage = new Bitmap(Directory.GetCurrentDirectory() + "\\Resources\\Images\\Back_Ground_Menu.jpg");
            Icon = new Icon(Directory.GetCurrentDirectory() + "\\Resources\\Icons\\Play.ico");
        }

        #region Label Click
        private void lbl_Start_Click(object sender, EventArgs e)
        {
            Play.Click_Sound.Play();
            Frm_Start _f = new Frm_Start();
            _f.ShowDialog();
        }

        private void lbl_Setting_Click(object sender, EventArgs e)
        {
            Play.Click_Sound.Play();
            Frm_Setting _f = new Frm_Setting();
            _f.ShowDialog();
        }

        private void lbl_Instruction_Click(object sender, EventArgs e)
        {
            Play.Click_Sound.Play();
            Frm_Instruction _f = new Frm_Instruction();
            _f.ShowDialog();
        }

        private void lbl_About_Us_Click(object sender, EventArgs e)
        {
            Play.Click_Sound.Play();
            Frm_About_Us _f = new Frm_About_Us();
            _f.ShowDialog();
        }

        private void lbl_Feed_Back_Click(object sender, EventArgs e)
        {
            Play.Click_Sound.Play();
            Frm_Feed_Back _f = new Frm_Feed_Back();
            _f.ShowDialog();
        }

        private void lbl_Exit_Click(object sender, EventArgs e)
        {
            Play.Click_Sound.Play();
            DialogResult dlr = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (dlr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        #endregion

        #region Label Behavior
        private void lbl_Start_MouseMove(object sender, MouseEventArgs e)
        {
            lbl_Start.ForeColor = Color.White;
        }

        private void lbl_Start_MouseLeave(object sender, EventArgs e)
        {
            lbl_Start.ForeColor = Color.Black;
        }

        private void lbl_Exit_MouseMove(object sender, MouseEventArgs e)
        {
            lbl_Exit.ForeColor = Color.White;
        }

        private void lbl_Exit_MouseLeave(object sender, EventArgs e)
        {
            lbl_Exit.ForeColor = Color.Black;
        }

        private void lbl_Setting_MouseMove(object sender, MouseEventArgs e)
        {
            lbl_Setting.ForeColor = Color.White;
        }

        private void lbl_Setting_MouseLeave(object sender, EventArgs e)
        {
            lbl_Setting.ForeColor = Color.Black;
        }

        private void lbl_Instruction_MouseMove(object sender, MouseEventArgs e)
        {
            lbl_Instruction.ForeColor = Color.White;
        }

        private void lbl_Instruction_MouseLeave(object sender, EventArgs e)
        {
            lbl_Instruction.ForeColor = Color.Black;
        }

        private void lbl_About_Us_MouseMove(object sender, MouseEventArgs e)
        {
            lbl_About_Us.ForeColor = Color.White;
        }

        private void lbl_About_Us_MouseLeave(object sender, EventArgs e)
        {
            lbl_About_Us.ForeColor = Color.Black;
        }

        private void lbl_Feed_Back_MouseMove(object sender, MouseEventArgs e)
        {
            lbl_Feed_Back.ForeColor = Color.White;
        }

        private void lbl_Feed_Back_MouseLeave(object sender, EventArgs e)
        {
            lbl_Feed_Back.ForeColor = Color.Black;
        }
        #endregion
    }
}

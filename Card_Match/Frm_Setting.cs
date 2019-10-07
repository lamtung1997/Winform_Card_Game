using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Card_Match
{
    public partial class Frm_Setting : Form
    {
        public Frm_Setting()
        {
            InitializeComponent();

            btn_Back.BackgroundImage = Play.Button_Image;
            btn_Reset.BackgroundImage = Play.Button_Image;
            btn_Sound.BackgroundImage = Play.Button_Image;
            btn_Theme.BackgroundImage = Play.Button_Image;

            Icon = Play.Play_Icon;

            Cb_Back_Ground.Hide();
            Cb_Back_side.Hide();
            lbl_Back_Ground.Hide();
            lbl_Back_Side.Hide();
            chbox_Playing_Sound.Hide();
            lbl_Reset.Hide();

            BackgroundImage = new Bitmap(Directory.GetCurrentDirectory() + "\\Resources\\Images\\" + Play.Back_Ground);
        }
        #region Button Click
        private void btn_Sound_Click(object sender, EventArgs e)
        {
            chbox_Playing_Sound.Show();

            lbl_Back_Ground.Hide();
            lbl_Back_Side.Hide();
            Cb_Back_Ground.Hide();
            Cb_Back_side.Hide();
            lbl_Reset.Hide();
        }

        private void btn_Theme_Click(object sender, EventArgs e)
        {
            lbl_Back_Ground.Show();
            lbl_Back_Side.Show();
            Cb_Back_Ground.Show();
            Cb_Back_side.Show();

            chbox_Playing_Sound.Hide();
            lbl_Reset.Hide();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            lbl_Reset.Show();
            Cb_Back_Ground.Hide();
            Cb_Back_side.Hide();
            lbl_Back_Ground.Hide();
            lbl_Back_Side.Hide();
            chbox_Playing_Sound.Hide();

            StreamWriter sw = new StreamWriter(Directory.GetCurrentDirectory() + "\\Resources\\Records\\Records.bin");
            sw.WriteLine("0");
            sw.Close();

            StreamWriter sw2 = new StreamWriter(Directory.GetCurrentDirectory() + "\\Resources\\Records\\Records2.bin");
            sw2.WriteLine("0");
            sw2.Close();

            StreamWriter sw3 = new StreamWriter(Directory.GetCurrentDirectory() + "\\Resources\\Records\\Records3.bin");
            sw3.WriteLine("0");
            sw3.Close();

            StreamWriter sw4 = new StreamWriter(Directory.GetCurrentDirectory() + "\\Resources\\Records\\Records4.bin");
            sw4.WriteLine("0");
            sw4.Close();

            StreamWriter sw5 = new StreamWriter(Directory.GetCurrentDirectory() + "\\Resources\\Records\\Records5.bin");
            sw5.WriteLine("0");
            sw5.Close();
        }
        #endregion

        private void chbox_Playing_Sound_CheckedChanged(object sender, EventArgs e)
        {
            if (chbox_Playing_Sound.Checked == true)
            {
                Play.Click_Sound = new SoundPlayer(Directory.GetCurrentDirectory() + "\\Resources\\Sounds\\Click.wav");
                Play.Tack_Sound = new SoundPlayer(Directory.GetCurrentDirectory() + "\\Resources\\Sounds\\Tack.wav");
                Play.Break_Record = new SoundPlayer(Directory.GetCurrentDirectory() + "\\Resources\\Sounds\\Break_Record.wav");
            }
            else
            {
                Play.Click_Sound = Play.Mute;
                Play.Tack_Sound = Play.Mute;
                Play.Break_Record = Play.Mute;
            }
        }

        private void Cb_Back_Ground_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Cb_Back_Ground.SelectedItem)
            {
                case "Grass" :  Play.Back_Ground = "Back_Ground_Grass.png";
                                break;
                case "Wood":    Play.Back_Ground = "Back_Ground_Wood.jpg";
                                break;
                case "Water":   Play.Back_Ground = "Back_Ground_Water.jpg";
                                break;
                case "Sky":     Play.Back_Ground = "Back_Ground_Sky.png";
                                break;
                case "Ground":  Play.Back_Ground = "Back_Ground_Ground.png";
                                break;
                default:        Play.Back_Ground = "Back_Ground_Grass.png";
                                break;
            }
        }

        private void Cb_Back_side_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Cb_Back_side.SelectedItem)
            {
                case "Poke Ball":           Play.Back_Side = "PokeBall.png";
                                            break;
                case "Unknown Pokemon":     Play.Back_Side = "Unknown.jpg";
                                            break;
                case "Question Mark":       Play.Back_Side = "Question_Mark.png";
                                            break;
                default:                    break;
            }
        }
    }
}

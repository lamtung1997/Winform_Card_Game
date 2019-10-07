using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Card_Match
{
    public static class Play
    {
        public static string Back_Ground = "Back_Ground_Grass.png";
        public static string Back_Side = "PokeBall.png";
        public static string Mode_Easy_Difficult = null;    // Easy, Difficult
        public static string Level;                         // 1, 2, 3, 4, 5

        public static SoundPlayer Click_Sound = new SoundPlayer(Directory.GetCurrentDirectory() + "\\Resources\\Sounds\\Click.wav");
        public static SoundPlayer Tack_Sound = new SoundPlayer(Directory.GetCurrentDirectory() + "\\Resources\\Sounds\\Tack.wav");
        public static SoundPlayer Break_Record = new SoundPlayer(Directory.GetCurrentDirectory() + "\\Resources\\Sounds\\Break_Record.wav");
        public static SoundPlayer Mute = new SoundPlayer(Directory.GetCurrentDirectory() + "\\Resources\\Sounds\\Mute.wav");
        public static SoundPlayer Sound_Track = new SoundPlayer(Directory.GetCurrentDirectory() + "\\Resources\\Sounds\\Mute.wav");

        public static int Gold = 0;
        public static int Multiplier = 1;
        public static int Record;
        public static int Number_Of_Card;
        public static int Item_Increase_Point;

        public static Bitmap Button_Image = new Bitmap(Directory.GetCurrentDirectory() + "\\Resources\\Images\\Button.png");
        public static Icon Play_Icon = new Icon(Directory.GetCurrentDirectory() + "\\Resources\\Icons\\Play.ico");
    }
}
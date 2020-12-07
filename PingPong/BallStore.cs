using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PingPong.Properties;

namespace PingPong
{
    public partial class BallStore : Form
    {

        private string Ballfile = @"Balls.txt";
        private Image[] Balls = new Image[10];
        private string fileName = @"HighScore.txt";
        private int points = 0;
        private PictureBox pic;

        public BallStore()
        {
            InitializeComponent();
            Cursor.Show();

            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = false;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            BallArray();


            StreamReader sr = new StreamReader(fileName); // קריאת התוצאה הכי טובה
            points = int.Parse(sr.ReadToEnd());

            foreach (Control p in Store_box.Controls)
            {
                pic = p as PictureBox;

                if (p is PictureBox)
                {
                    CheckPicture(pic);
                }
            }

            Made_by.Top = Store_Panel.Bottom - (Store_Panel.Bottom / 15);
            Made_by.Left = (Store_Panel.Width / 2) - (Store_box.Width / 4);

            Store_box.Left = (Store_Panel.Width / 2) - (Store_box.Width / 2);
            Store_box.Top = (Store_Panel.Height / 2) - (Store_box.Height / 2);

            Main_lbl.Top = Store_Panel.Top - (Store_Panel.Top / 5);
            Main_lbl.Left = (Store_Panel.Width / 2) - (Store_box.Width / 4);
        }

        private void BallStore_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Cursor.Hide();
                Close();
            }
        }

        private void Click_box(object sender, EventArgs e)
        { // פעולה אשר לוקחת את התג של התמונה הנבחרת (שלחצו עליה) ושומרת אותו בתוך קובץ
            int num;

            PictureBox pictureBox = sender as PictureBox;
            PictureBox picName = pictureBox;
            num = Convert.ToInt32(picName.Tag);

            StreamWriter sw = new StreamWriter(Ballfile);
            sw.Write(num);
            sw.Close();
        }

        private void BallArray()
        {
            Balls[0] = Resources.Red;
            Balls[1] = Resources.Blue;
            Balls[2] = Resources.Orange;
            Balls[3] = Resources.Green;
            Balls[4] = Resources.Gold;
            Balls[5] = Resources.Donats;
            Balls[6] = Resources.Gif_Ball;
            Balls[7] = Resources.Football;
            Balls[8] = Resources.Basketball;
            Balls[9] = Resources.Earth;
        }

        private void CheckPicture(PictureBox pic)
        {// פעולה אשר בודקת האם ניתן להראות את הכדור למשתמש (מבחינת נקודות ), ואם כן היא גם תבטל את האופציה שאי אפשר ללחוץ
            BallArray();
            if (Convert.ToInt32(pic.Tag) * 4 <= points)
            {
                pic.Enabled = true;
                pic.Image = Balls[Convert.ToInt32(pic.Tag)];
            }
        }

    }
}

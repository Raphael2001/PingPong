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
using System.Xml.Serialization;
using PingPong.Properties;
using Microsoft.VisualBasic;


namespace PingPong
{


    public partial class Form1 : Form
    {
        public double speed_left = 4; // מהירות של הכדור 
        public double speed_top = 4;
        public int points = 0;
        public int bestscore;
        private string fileName = @"HighScore.txt";  // שם של הקובץ של התוצאה הכי טובה
        private string file = @"HighScoreName.txt";  // של של הקובץ של השם של השחקן הכי טוב
        private int highscore; // התוצאה הכי טובה (לא מעודכנת) 
        private Image[] Balls = new Image[10];
        private string BestPlayerName = "";
        private string NameFile = @"Names.txt";
        private string ScoreFile = @"Scores.txt";
        private string PlayerName = "";
        private string Ballfile = @"Balls.txt";
        private Image[] img = new Image[8];




        public Form1()
        {
            InitializeComponent();

            timer1.Start();
            Cursor.Hide(); // מחביא את הסמן של עכבר

            this.FormBorderStyle = FormBorderStyle.None; // מסתיר את האופיציה של האיקס כדי לצאת
            this.TopMost = true; // מביא את המסך לקדימה
            this.Bounds = Screen.PrimaryScreen.Bounds; // גורם להיות במסך מלא

            racket.Top = playground.Bottom - (playground.Bottom / 10); // מגדיר את המיקום של הלוח

            gameover_lbl.Left = (playground.Width / 2) - (gameover_lbl.Width / 2);  // למקם את הליבל של "המשחק נגמר" באמצע המסך
            gameover_lbl.Top = (playground.Height / 2) - (gameover_lbl.Height / 2);
            gameover_lbl.Visible = false;

           
            BallArray();

            Made_by.Top = playground.Bottom - (playground.Bottom / 15);
            Made_by.Left = (playground.Width / 2) - (gameover_lbl.Width / 4);

            BallChange();

            StreamReader sr = new StreamReader(fileName); // קריאת התוצאה הכי טובה
            highscore = int.Parse(sr.ReadToEnd());
            bestscore = highscore;
            bestpoints_lbl.Text = bestscore.ToString();

            StreamReader St = new StreamReader(file);//קריאת השם של השחקן הכי טוב
            BestPlayerName = St.ReadLine();
            BestName_lbl.Text = BestPlayerName;
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            racket.Left = Cursor.Position.X - (racket.Width / 2);

            ball.Left += Convert.ToInt32(speed_left); // מזיז את הכדור
            ball.Top += Convert.ToInt32(speed_top);

            if (ball.Bottom >= racket.Top && ball.Bottom <= racket.Bottom && ball.Left >= racket.Left && ball.Right <= racket.Right)  // התנגשות של הכדור עם הלוח
            {
                speed_top += 0.5;
                speed_left += 1;
                speed_top = -speed_top; // משנה את הכיוון של הכדור
                points += 1;
                Points_lbl.Text = points.ToString();
                if (bestscore < points)
                {
                    bestscore = points;
                    bestpoints_lbl.Text = bestscore.ToString();
                }
                Random rand = new Random();
                playground.BackColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256)); // בכל פעם בוחר צבע רנדומלי
                                                                                                       // playground.BackgroundImage = img[rand.Next(8)];                                                                                       // playground.BackgroundImage = img[rand.Next(8)];

            }
            if (ball.Left <= playground.Left)
            {
                speed_left = -speed_left;
            }
            if (ball.Right >= playground.Right)
            {
                speed_left = -speed_left;
            }
            if (ball.Top <= playground.Top)
            {
                speed_top = -speed_top;
            }
            if (ball.Bottom >= playground.Bottom)
            {

                timer1.Stop(); // כדור מחוץ למשחק -> עצור את המשחק
                gameover_lbl.Visible = true;


                if (bestscore > highscore)
                {
                    BestPlayerName = OpenDialog();
                    Save();
                    SaveNames(BestPlayerName);
                    SaveScores(bestscore);
                }
                else
                {
                    PlayerName = OpenDialog();
                    SaveNames(PlayerName);
                    SaveScores(points);
                }


            }

        }

        private void Save()
        { // פעולה אשר שומרת את התוצאה הכי טובה + שמו של המשתמש שעשה עשה אותה
            StreamWriter sw = new StreamWriter(fileName);
            sw.Write(bestscore);
            sw.Close();
            this.TopMost = false;


            StreamWriter St = new StreamWriter(file);
            St.Write(BestPlayerName);
            St.Close();
            BestName_lbl.Text = PlayerName;

        }

        private static DialogResult ShowInputDialog(ref string input)
        {  // פעולה אשר פותחת דיאלוג אשר מקבל שם לצורך שמירה

            Size size = new Size(200, 70);
            Form inputBox = new Form();

            inputBox.FormBorderStyle = FormBorderStyle.FixedDialog;
            inputBox.ClientSize = size;
            inputBox.Text = "Name";



            TextBox textBox = new TextBox();
            textBox.Size = new Size(size.Width - 10, 23);
            textBox.Location = new Point(5, 5);
            textBox.Text = input;
            inputBox.Controls.Add(textBox);

            Button okButton = new Button();
            okButton.DialogResult = DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.Text = "&OK";
            okButton.Location = new Point(size.Width - 80 - 80, 39);
            inputBox.Controls.Add(okButton);

            Button cancelButton = new Button();
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.Text = "&Cancel";
            cancelButton.Location = new Point(size.Width - 80, 39);
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            inputBox.BringToFront();
            DialogResult result = inputBox.ShowDialog();

            input = textBox.Text;
            return result;
        }

        public void SaveScores(int points)
        { // שומר את התוצאה הנוכחית
            using (FileStream fs = new FileStream(ScoreFile, FileMode.Append, FileAccess.Write))
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine(points);
            }
        }

        public void SaveNames(string Name)
        {// שומר את שם השחקן הנוכחי

            using (FileStream fs = new FileStream(NameFile, FileMode.Append, FileAccess.Write))
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine(Name);
            }
        }

        public string OpenDialog()
        { // פותח דיאלוג שבו ניתן להקליד שם
            this.TopMost = false;
            string input = "";
            ShowInputDialog(ref input);
            return input;
        }

        private void BallChange()
        { // קורא את מספר הכדור הנבחר
            BallArray();

            StreamReader sr = new StreamReader(Ballfile);
            int Ball = int.Parse(sr.ReadToEnd());
            ball.Image = Balls[Ball];
        }

        public void BallArray()
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

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // פעולה אשר אחראית על מקשים
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();  // לוחץ על אסקייפ כדי לצאת מהמשחק
            }
            if (e.KeyCode == Keys.F1) // משחק מחדש
            {

                this.TopMost = true;

                ball.Top = 50;
                ball.Left = 50;
                speed_left = 4;
                speed_top = 4;
                points = 0;

                BallChange();

                StreamReader sr = new StreamReader(fileName); // קריאת התוצאה הכי טובה
                highscore = int.Parse(sr.ReadToEnd());
                bestscore = highscore;
                bestpoints_lbl.Text = bestscore.ToString();

                StreamReader St = new StreamReader(file);//קריאת השם של השחקן הכי טוב
                BestPlayerName = St.ReadLine();
                BestName_lbl.Text = BestPlayerName;

                timer1.Start();

                Points_lbl.Text = "0";
                gameover_lbl.Visible = false;
                playground.BackColor = Color.White;

            }
            if (e.KeyCode == Keys.F2)
            {
                gameover_lbl.Visible = true;
                timer1.Stop();
                this.TopMost = false;
                HighScoresTable newforn = new HighScoresTable();
                newforn.Show();
            }
            if (e.KeyCode == Keys.F3)
            {
                gameover_lbl.Visible = true;
                timer1.Stop();
                this.TopMost = false;
                BallStore newforn = new BallStore();
                newforn.Show();
            }
        }
    }
}





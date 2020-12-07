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

namespace PingPong
{


    public partial class HighScoresTable : Form
    {
        private string fileName = @"HighScore.txt";
        private string file = @"HighScoreName.txt";
        private int highscore;
        private string PlayerName = "";
        private HighScores[] Scores = new HighScores[10000];
        private HighScores test = new HighScores();
        private string NameFile = @"Names.txt";
        private string ScoreFile = @"Scores.txt";
        private string[] ScoresT = new string[10000];
        private string[] NamesT = new string[10000];
        private const int N = 10;

        public HighScoresTable()
        {
            InitializeComponent();
            

            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = false;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            Tabel_box.Left = (PanelMain.Width / 2) - (Tabel_box.Width / 2);
            Tabel_box.Top = (PanelMain.Height / 2) - (Tabel_box.Height / 2);

            StreamReader sr = new StreamReader(fileName); // קריאת התוצאה הכי טובה
            highscore = int.Parse(sr.ReadToEnd());


            StreamReader St = new StreamReader(file);//קריאת השם של השחקן הכי טוב
            PlayerName = St.ReadLine();


            Name_lbl3.ForeColor = Color.FromArgb(205, 127, 50);
            Score_lbl3.ForeColor = Color.FromArgb(205, 127, 50);
            Num_lbl3.ForeColor = Color.FromArgb(205, 127, 50);

            TwoArrayToOne(NamesT, ScoresT, Scores);
            UpdateArray(Scores);
            SetLbl();

            Made_by.Top = PanelMain.Bottom - (PanelMain.Bottom / 15); // מיקום התוויות זכויות יוצרים
            Made_by.Left = (PanelMain.Width / 2) - (Tabel_box.Width /3);

            Main_lbl.Top = PanelMain.Top - (PanelMain.Top / 5); // מיקום של התוויות בה מוזכר השם של המקום
            Main_lbl.Left = (PanelMain.Width / 2) - (Tabel_box.Width / 2);

            
        }

        private void HighScoresTable_KeyDown(object sender, KeyEventArgs e)
        { // פעולה אשר אחראית על מקשים

            if (e.KeyCode == Keys.Escape)
            {
               
                this.Close();  // לוחץ על אסקייפ כדי לצאת מהמשחק
            }
        }

        private void SetLbl()
        { // מסדר בכל ליבל את התא התואם לו

            for (int i = 0; i < N; i++)
            {
                if (Scores[i] != null)
                {
                    Tabel_box.Controls["Name_lbl" + (i + 1)].Text = Scores[i].GetName();
                    Tabel_box.Controls["Score_lbl" + (i + 1)].Text = Scores[i].GetScore().ToString();
                }
            }

        }
       
        private void UpdateArray(HighScores[] scores)
        { // מסדר את המערך מהגדול לקטן
            HighScores temp = null;

            for (int i = 0; i < scores.Length; i++)
            {
                for (int j = i + 1; j < scores.Length; j++)
                {
                    if (scores[i] != null && scores[j] != null)
                        if (scores[i].GetScore() < scores[j].GetScore())
                        {
                            temp = scores[i];
                            scores[i] = scores[j];
                            scores[j] = temp;
                        }
                }
            }
        }

        private string[] ReadFromFile(string FileName)
        {// קורא את כל הנתונים מקובץ
            var lines = File.ReadAllLines(FileName).ToArray();
            return lines;
        }

        private void TwoArrayToOne(string[] NamesT, string[] ScoresT, HighScores[] Scores)
        { // הופך שני מערכים למערך אחד
            for (int i = 0; i < Scores.Length; i++)
            {
                NamesT[i] = "";
                ScoresT[i] = 0.ToString();
            }
            NamesT = ReadFromFile(NameFile);
            ScoresT = ReadFromFile(ScoreFile);

            for (int i = 0; i < ScoresT.Length; i++)
            {
                Scores[i] = new HighScores();
                if (ScoresT[i] != null && NamesT[i] != null)
                {
                    Scores[i].SetName(NamesT[i]);
                    Scores[i].SetScore(Convert.ToInt32(ScoresT[i]));
                }
            }
        }

    }
}

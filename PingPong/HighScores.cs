using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong
{
    class HighScores
    {
        private int Score;
        private string Name;

        public HighScores (int Score,string Name)
        {
            this.Score = Score;
            this.Name = Name;
        }

        public HighScores()
        {

        }

        public HighScores(int Score)
        {
            this.Score = Score;
        }

        public HighScores(string Name)
        {
            this.Name = Name;
        }

        public int GetScore()
        {
            return Score;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetScore(int Score)
        {
            this.Score = Score;
        }

        public void SetName(string Name)
        {
            this.Name = Name;
        }
    }
}

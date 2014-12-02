using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _22_writing_and_reading_from_files
{
    public class Score
    {
        //Fields name, score
        private int score;
        private string name;


        //Properties Name, Score
        public int Score { get; set; }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        //Constructor 
        public Score(string name, int score)
        {
            this.name = name;
            this.score = score;
        }
    }
}

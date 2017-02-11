using System;
using System.IO;
using System.Text;

namespace Game
{
    /// <summary>
    /// A class to handle the scores
    /// </summary>
    class ScoreEngine
    {
        // constants
        private const byte maxRecords = 10;
        private const string file = "Scores.txt";
        private int lastID = 0;

        private Player[] scores;

        /// <summary>
        /// Array to hold all the scores for the game
        /// </summary>
        public Player[] Scores
        {
            get { return scores; }
            set { scores = value; }
        }

        /// <summary>
        /// Last id of all the records in the file
        /// </summary>
        public int LastID
        {
            get { return lastID; }
            set { lastID = value; }
        }

        /// <summary>
        /// A constructor for the Score class.
        /// </summary>
        public ScoreEngine()
        {
            this.Scores = new Player[maxRecords];
        }

        /// <summary>
        /// Reads the existing score from a file or
        /// generates the scores if the file does not exist.
        /// </summary>
        public void LoadScores()
        {
            if (File.Exists(file))
            {
                try
                {
                    StreamReader reader = new StreamReader(file);
                    using (reader)
                    {
                        for (int i = 0; i < this.Scores.Length; i++)
                        {
                            string line = reader.ReadLine();
                            string[] information = line.Split(',');
                            this.Scores[i] = new Player(information[0], int.Parse(information[1]), int.Parse(information[2]));
                            if (this.LastID < int.Parse(information[2]))
                            {
                                this.LastID = int.Parse(information[2]);
                            }
                        }
                    }

                }
                catch (Exception e)
                {
                    Logger.Log(e);
                }
            }
            else
            {
                for (int i = 0; i < this.Scores.Length; i++)
                {
                    this.Scores[i] = new Player("Player", 0, 0);
                }
            }
        }

        /// <summary>
        /// Saves the scores to a file. Creates or overwrites it. 
        /// </summary>
        public void SaveScores()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this.Scores.Length; i++)
            {
                sb.Append(Scores[i].Name);
                sb.Append(",");
                sb.Append(Scores[i].Score.ToString());
                sb.Append(",");
                sb.Append(Scores[i].ID.ToString());
                sb.AppendLine();
            }

            try
            {
                StreamWriter writer = new StreamWriter(file, false); // overwrites the file
                using (writer)
                {
                    writer.Write(sb.ToString());
                }
            }
            catch (Exception e)
            {
                Logger.Log(e);
            }
        }

        /// <summary>
        /// Merges the player's score and sorts the array.
        /// </summary>
        /// <param name="player"></param>
        public void MergeSort(Player player)
        {
            try
            {
                if (this.Scores[9].Score < player.Score)
                {
                    // assigning the player's score to the last position.
                    this.Scores[9].Score = player.Score;
                    this.Scores[9].Name = player.Name;
                    this.Scores[9].ID = player.ID;
                    // sort the scores
                    Sort();
                }
            }
            catch (Exception e)
            {
                Logger.Log(e);
            }
        }

        /// <summary>
        /// Sort the the scores
        /// </summary>
        private void Sort()
        {
            try
            {
                Player temp;
                for (int i = 0; i < this.Scores.Length - 1; i++)
                {
                    for (int j = i + 1; j < this.Scores.Length; j++)
                    {
                        if (this.Scores[i].Score < this.Scores[j].Score) // swap items
                        {
                            temp = new Player(this.Scores[i].Name, this.Scores[i].Score, this.Scores[i].ID);
                            this.Scores[i] = this.Scores[j];
                            this.Scores[j] = temp;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Logger.Log(e);
            }
        }
    }
}

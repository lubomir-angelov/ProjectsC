using System;

namespace Game
{
    class Player
    {
        // constant fields
        private sbyte initialLives = 3;
        private int initialScore = 0;
        // variables
        private sbyte lives;
        private string name;
        private int score;
        private int id;

        private int keys;

        public int Keys
        {
            get { return keys; }
            set { keys = value; }
        }
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public sbyte Lives
        {
            get { return lives; }
            set { lives = value; }
        }

        public Player(int typeKeys)
        {
            try
            {
                Console.Write("Enter your name: ");

                this.Name = Console.ReadLine(); // sets Player's name
                this.Score = initialScore; // sets Player's initial score to initialScore
                this.Lives = initialLives; // sets Player's initial lives to initialLives

                if (typeKeys == 1) this.Keys = 1;
                else if (typeKeys == 2) this.Keys = 2;
            }
            catch (Exception e)
            {
                Logger.Log(e);
                PrintEngine.ClearScreen();
                Console.WriteLine("Failed to initialize player!");
                Environment.Exit(0);
            }
        }

        public Player(string name, int score, int id)
        {
            try
            {
                this.Name = name;
                this.Score = score;
                this.ID = id;
            }
            catch (Exception e)
            {
                Logger.Log(e);
            }
        }
    }
}

using System;

namespace Game
{
    /// <summary>
    /// A class for the player.
    /// </summary>
    internal class Pacman
    {
        // constants 
        public const ConsoleKey playerOneUp = ConsoleKey.UpArrow;
        public const ConsoleKey playerOneDown = ConsoleKey.DownArrow;
        public const ConsoleKey playerOneLeft = ConsoleKey.LeftArrow;
        public const ConsoleKey playerOneRight = ConsoleKey.RightArrow;
        public const ConsoleKey playerTwoUp = ConsoleKey.W;
        public const ConsoleKey playerTwoDown = ConsoleKey.S;
        public const ConsoleKey playerTwoLeft = ConsoleKey.A;
        public const ConsoleKey playerTwoRight = ConsoleKey.D;
        private const int scorePowerPellet = 50;
        private const int scoreDot = 10;
        private const double timeForEating = 15;
        private const int liveBonus = 10000;
        private const int ghostBonus = 100;
        // variables 
        private char symbol;
        private Way direction;
        private int row;
        private int column;
        private int score;
        private sbyte lives;
        private bool canEatGhosts;
        private DateTime eatingStart;
        private DateTime eatingDone;
        private int homeRow;
        private int homeColumn;
        private byte numberOfGhostsEaten = 0;
        private int currentLiveBonus = 10000;
        private ConsoleKey keyUp;
        private ConsoleKey keyDown;
        private ConsoleKey keyLeft;
        private ConsoleKey keyRight;

        public DateTime EatingDone
        {
            get { return eatingDone; }
            set { eatingDone = value; }
        }

        public DateTime EatingStart
        {
            get { return eatingStart; }
            set { eatingStart = value; }
        }

        public bool CanEatGhosts
        {
            get { return canEatGhosts; }
            set { canEatGhosts = value; }
        }

        public sbyte Lives
        {
            get { return lives; }
            set { lives = value; }
        }

        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        public int Column
        {
            get { return column; }
            set { column = value; }
        }

        public int Row
        {
            get { return row; }
            set { row = value; }
        }

        public char Symbol
        {
            get { return symbol; }
            set { symbol = value; }
        }

        public Way Direction
        {
            get { return direction; }
            set { direction = value; }
        }

        public Pacman(int row, int column, char symbol, Player player)
        {
            try
            {
                this.Row = row;
                this.Column = column;
                this.Symbol = symbol;
                this.Score = player.Score;
                this.Direction = Way.Left;
                this.Lives = player.Lives;
                this.CanEatGhosts = false;
                this.homeColumn = column;
                this.homeRow = row;

                if (player.Keys == 1)
                {
                    this.keyUp = playerOneUp;
                    this.keyDown = playerOneDown;
                    this.keyLeft = playerOneLeft;
                    this.keyRight = playerOneRight;
                }
                else if (player.Keys == 2)
                {
                    this.keyUp = playerTwoUp;
                    this.keyDown = playerTwoDown;
                    this.keyLeft = playerTwoLeft;
                    this.keyRight = playerTwoRight;
                }
            }
            catch (Exception e)
            {
                Logger.Log(e);
            }
        }

        public enum Way
        {
            /// <summary>
            /// Direction keyUp
            /// </summary>
            Up = 0,

            /// <summary>
            /// Direction keyDown
            /// </summary>
            Down = 1,

            /// <summary>
            /// Direction keyLeft
            /// </summary>
            Left = 2,

            /// <summary>
            /// Direction keyRight
            /// </summary>
            Right = 3
        }

        /// <summary>
        /// Change direction and move or just move
        /// for single player
        /// </summary>
        public void ChangeDirectionAndMoveOrJustMove()
        {
            try
            {
                AddLives();
                if (CanEatGhosts)
                {
                    CheckEating();
                }
                if (Console.KeyAvailable) //do this only if key is pressed
                {
                    ConsoleKeyInfo userInput = Console.ReadKey();
                    if (userInput.Key == this.keyUp)
                    {
                        // check if there is a wall. if there is wall -> return
                        if (Maze.IsWall(this.Row - 1, this.Column)) return;
                        if (Maze.IsDot(this.Row - 1, this.Column))
                        {
                            this.score += scoreDot;
                            Maze.dotsCounter--;
                            Maze.ChangeDotToEmpty(this.Row - 1, this.Column);
                        }
                        if (Maze.IsPowerPellet(this.Row - 1, this.Column))
                        {
                            this.score += scorePowerPellet;
                            Maze.dotsCounter--;
                            Maze.ChangePelletToEmpty(this.Row - 1, this.Column);
                            this.CanEatGhosts = true;
                            StartEating();
                        }
                        PrintEngine.PrintSymbol(this.Row, this.Column, Maze.symbolEmpty);
                        // set the direction
                        this.Direction = Way.Up;
                        // move player position
                        this.Row--;
                        // check if pacman is outside the screen
                        if (this.Row < Maze.minMazeRow) this.Row = Maze.maxMazeRow;
                    }
                    else if (userInput.Key == this.keyLeft)
                    {
                        if (Maze.IsWall(this.Row, this.Column - 1)) return;
                        if (Maze.IsDot(this.Row - 1, this.Column))
                        {
                            this.score += scoreDot;
                            Maze.dotsCounter--;
                            Maze.ChangeDotToEmpty(this.Row, this.Column - 1);
                        }
                        if (Maze.IsPowerPellet(this.Row, this.Column - 1))
                        {
                            this.score += scorePowerPellet;
                            Maze.dotsCounter--;
                            Maze.ChangePelletToEmpty(this.Row, this.Column - 1);
                            StartEating();
                        }
                        PrintEngine.PrintSymbol(this.Row, this.Column, Maze.symbolEmpty);
                        this.Direction = Way.Left;
                        this.Column--;
                        if (this.Column < Maze.minMazeColumn) this.Column = Maze.maxMazeColumn;
                    }
                    else if (userInput.Key == this.keyRight)
                    {
                        if (Maze.IsWall(this.Row, this.Column + 1)) return;
                        if (Maze.IsDot(this.Row, this.Column + 1))
                        {
                            this.score += scoreDot;
                            Maze.dotsCounter--;
                            Maze.ChangeDotToEmpty(this.Row, this.Column + 1);
                        }
                        if (Maze.IsPowerPellet(this.Row, this.Column + 1))
                        {
                            this.score += scorePowerPellet;
                            Maze.dotsCounter--;
                            Maze.ChangePelletToEmpty(this.Row, this.Column + 1);
                            StartEating();
                        }
                        PrintEngine.PrintSymbol(this.Row, this.Column, Maze.symbolEmpty);
                        this.Direction = Way.Right;
                        this.Column++;
                        if (this.Column > Maze.maxMazeColumn) this.Column = Maze.minMazeColumn;
                    }
                    else if (userInput.Key == this.keyDown)
                    {
                        if (Maze.IsWall(this.Row + 1, this.Column)) return;
                        if (Maze.IsDot(this.Row + 1, this.Column))
                        {
                            this.score += scoreDot;
                            Maze.dotsCounter--;
                            Maze.ChangeDotToEmpty(this.Row + 1, this.Column);
                        }
                        if (Maze.IsPowerPellet(this.Row + 1, this.Column))
                        {
                            this.score += scorePowerPellet;
                            Maze.dotsCounter--;
                            Maze.ChangePelletToEmpty(this.Row + 1, this.Column);
                            StartEating();
                        }
                        PrintEngine.PrintSymbol(this.Row, this.Column, Maze.symbolEmpty);
                        this.Direction = Way.Down;
                        this.Row++;
                        if (this.Row > Maze.maxMazeRow) this.Row = Maze.minMazeRow;
                    }
                    else
                    {

                    }
                    // prints the new position of pacman
                    PrintEngine.PrintSymbol(this.Row, this.Column, this.Symbol);
                }
                else
                {
                    switch (this.Direction)
                    {
                        case Way.Up: // direction Up
                            // check if there is a wall. if there is wall -> break
                            if (Maze.IsWall(this.Row - 1, this.Column)) break;
                            //add points for dot/pellet and change the matrix;
                            if (Maze.IsDot(this.Row - 1, this.Column))
                            {
                                this.score += scoreDot;
                                Maze.dotsCounter--;
                                Maze.ChangeDotToEmpty(this.Row - 1, this.Column);
                            }
                            if (Maze.IsPowerPellet(this.Row - 1, this.Column))
                            {
                                this.score += scorePowerPellet;
                                Maze.dotsCounter--;
                                Maze.ChangePelletToEmpty(this.Row - 1, this.Column);
                                StartEating();
                            }
                            PrintEngine.PrintSymbol(this.Row, this.Column, Maze.symbolEmpty);
                            // move player position
                            this.Row--;
                            // check if pacman is outside the screen
                            if (this.Row - 1 < Maze.minMazeRow) this.Row = Maze.maxMazeRow;
                            // print symbol on the new position
                            PrintEngine.PrintSymbol(this.Row, this.Column, this.Symbol);
                            break;
                        case Way.Down: // direction Down
                            if (Maze.IsWall(this.Row + 1, this.Column)) break;
                            if (Maze.IsDot(this.Row + 1, this.Column))
                            {
                                this.score += scoreDot;
                                Maze.dotsCounter--;
                                Maze.ChangeDotToEmpty(this.Row + 1, this.Column);
                            }
                            if (Maze.IsPowerPellet(this.Row + 1, this.Column))
                            {
                                this.score += scorePowerPellet;
                                Maze.dotsCounter--;
                                Maze.ChangePelletToEmpty(this.Row + 1, this.Column);
                                StartEating();
                            }
                            PrintEngine.PrintSymbol(this.Row, this.Column, Maze.symbolEmpty);
                            this.Row++;
                            if (this.Row + 1 > Maze.maxMazeRow)
                                this.Row = Maze.minMazeRow; // fixed moving from one end to the other
                            PrintEngine.PrintSymbol(this.Row, this.Column, this.Symbol);
                            break;
                        case Way.Left: // direction Left
                            if (Maze.IsWall(this.Row, this.Column - 1)) break;
                            if (Maze.IsDot(this.Row, this.Column - 1))
                            {
                                this.score += scoreDot;
                                Maze.dotsCounter--;
                                Maze.ChangeDotToEmpty(this.Row, this.Column - 1);
                            }
                            if (Maze.IsPowerPellet(this.Row, this.Column - 1))
                            {
                                this.score += scorePowerPellet;
                                Maze.dotsCounter--;
                                Maze.ChangePelletToEmpty(this.Row, this.Column - 1);
                                StartEating();
                            }
                            PrintEngine.PrintSymbol(this.Row, this.Column, Maze.symbolEmpty);
                            this.Column--;
                            if (this.Column - 1 < Maze.minMazeColumn)
                                this.Column = Maze.maxMazeColumn; // fixed moving from one end to the other
                            PrintEngine.PrintSymbol(this.Row, this.Column, this.Symbol);
                            break;
                        case Way.Right: // direction Right
                            if (Maze.IsWall(this.Row, this.Column + 1)) break;
                            if (Maze.IsDot(this.Row, this.Column + 1))
                            {
                                this.score += scoreDot;
                                Maze.dotsCounter--;
                                Maze.ChangeDotToEmpty(this.Row, this.Column + 1);
                            }
                            if (Maze.IsPowerPellet(this.Row, this.Column + 1))
                            {
                                this.score += scorePowerPellet;
                                Maze.dotsCounter--;
                                Maze.ChangePelletToEmpty(this.Row, this.Column + 1);
                                StartEating();
                            }
                            PrintEngine.PrintSymbol(this.Row, this.Column, Maze.symbolEmpty);
                            this.Column++;
                            if (this.Column + 1 > Maze.maxMazeColumn)
                                this.Column = Maze.minMazeColumn; // fixed moving from one end to the other
                            PrintEngine.PrintSymbol(this.Row, this.Column, this.Symbol);
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                Logger.Log(e);
                PrintEngine.ClearScreen();
                Console.WriteLine("Failed to initialize player!");
                Environment.Exit(0);
            }
        }

        /// <summary>
        /// pacman is starting to eat ghosts.
        /// sets the timers.
        /// </summary>
        private void StartEating()
        {
            try
            {
                this.CanEatGhosts = true;
                this.EatingStart = DateTime.Now;
                this.EatingDone = DateTime.Now.AddSeconds(timeForEating);
            }
            catch (Exception e)
            {
                Logger.Log(e);
            }
        }

        /// <summary>
        /// checks if pacman is done with eating 
        /// </summary>
        private void CheckEating()
        {
            try
            {
                // timespan 
                TimeSpan time = this.EatingDone - DateTime.Now;
                if (time.TotalSeconds <= 0)
                {
                    this.CanEatGhosts = false;
                    this.numberOfGhostsEaten = 0;
                }
            }
            catch (Exception e)
            {
                Logger.Log(e);
            }
        }

        /// <summary>
        /// checks what happens if pacman and ghost
        /// are on the same spot
        /// </summary>
        /// <param name="ghost">input a ghost</param>
        public void CheckGhost(Ghost ghost)
        {
            try
            {
                // case can't eat ghosts
                if (this.Row == ghost.Row && this.Column == ghost.Column && this.CanEatGhosts == false)
                {
                    // pacman is moved to home location
                    this.Row = this.homeRow;
                    this.column = this.homeColumn;
                    // lives decrease with 1
                    this.Lives--;
                    // print pacman at his new location
                    PrintEngine.PrintSymbol(this.Row, this.Column, this.Symbol);
                    // play death sound
                    SoundEngine.PlayDeathSound();

                }
                // case can eat ghosts
                else if (this.Row == ghost.Row && this.Column == ghost.Column &&
                         this.CanEatGhosts == true && ghost.IsEaten == false)
                {
                    // set  ghost is eaten
                    ghost.IsEaten = true;
                    // increase the number for eaten ghosts
                    this.numberOfGhostsEaten++;
                    // add the ghost to the score based on the number for eaten ghosts
                    this.AddGhostToScore();
                    // set ghost symbol to dead
                    ghost.Symbol = Maze.symbolGhostDead;
                    // print the ghost with the new symbol
                    PrintEngine.PrintSymbol(ghost.Row, ghost.Column, ghost.Symbol);
                    PrintEngine.PrintSymbol(this.Row, this.Column, this.Symbol);
                }
            }
            catch (Exception e)
            {
                Logger.Log(e);
                PrintEngine.ClearScreen();
                Console.WriteLine("Failed to initialize collision detection!");
                Environment.Exit(0);
            }
        }

        /// <summary>
        /// Add bonus lives every currentLiveBonus score
        /// </summary>
        private void AddLives()
        {
            try
            {
                if (this.score >= this.currentLiveBonus)
                {
                    this.lives++;
                    this.currentLiveBonus += liveBonus;
                }
            }
            catch (Exception e)
            {
                Logger.Log(e);
            }
        }

        /// <summary>
        /// Add bonus score for eating ghosts
        /// </summary>
        private void AddGhostToScore()
        {
            this.score = this.numberOfGhostsEaten * ghostBonus;
        }

        /// <summary>
        /// Change direction for multi-player
        /// and move with one position
        /// </summary>
        /// <param name="way">input a new direction</param>
        public void ChangeDirectionAndMove(Way way)
        {
            try
            {
                AddLives();
                if (CanEatGhosts)
                {
                    CheckEating();
                }
                //AddLives(); -- if we put it here as void it constantly adds lives before we press a button 
                // with the old condition (0 % 10 000 == 0) --> add life
                //Console.SetCursorPosition(50, 51);
                //Console.Write(this.CanEatGhosts);
                //Console.SetCursorPosition(50, 52);
                //Console.WriteLine(((this.EatingDone - DateTime.Now).TotalSeconds));

                if (way == Way.Up)
                {
                    // check if there is a wall. if there is wall -> return
                    if (Maze.IsWall(this.Row - 1, this.Column)) return;
                    if (Maze.IsDot(this.Row - 1, this.Column))
                    {
                        this.score += scoreDot;
                        Maze.dotsCounter--;
                        Maze.ChangeDotToEmpty(this.Row - 1, this.Column);
                    }
                    if (Maze.IsPowerPellet(this.Row - 1, this.Column))
                    {
                        this.score += scorePowerPellet;
                        Maze.dotsCounter--;
                        Maze.ChangePelletToEmpty(this.Row - 1, this.Column);
                        this.CanEatGhosts = true;
                        StartEating();
                    }
                    PrintEngine.PrintSymbol(this.Row, this.Column, Maze.symbolEmpty);
                    // set the direction
                    this.Direction = Way.Up;
                    // move player position
                    this.Row--;
                    // check if pacman is outside the screen
                    if (this.Row < Maze.minMazeRow) this.Row = Maze.maxMazeRow;
                }
                else if (way == Way.Left)
                {
                    if (Maze.IsWall(this.Row, this.Column - 1)) return;
                    if (Maze.IsDot(this.Row - 1, this.Column))
                    {
                        this.score += scoreDot;
                        Maze.dotsCounter--;
                        Maze.ChangeDotToEmpty(this.Row, this.Column - 1);
                    }
                    if (Maze.IsPowerPellet(this.Row, this.Column - 1))
                    {
                        this.score += scorePowerPellet;
                        Maze.dotsCounter--;
                        Maze.ChangePelletToEmpty(this.Row, this.Column - 1);
                        StartEating();
                    }
                    PrintEngine.PrintSymbol(this.Row, this.Column, Maze.symbolEmpty);
                    this.Direction = Way.Left;
                    this.Column--;
                    if (this.Column < Maze.minMazeColumn) this.Column = Maze.maxMazeColumn;
                }
                else if (way == Way.Right)
                {
                    if (Maze.IsWall(this.Row, this.Column + 1)) return;
                    if (Maze.IsDot(this.Row, this.Column + 1))
                    {
                        this.score += scoreDot;
                        Maze.dotsCounter--;
                        Maze.ChangeDotToEmpty(this.Row, this.Column + 1);
                    }
                    if (Maze.IsPowerPellet(this.Row, this.Column + 1))
                    {
                        this.score += scorePowerPellet;
                        Maze.dotsCounter--;
                        Maze.ChangePelletToEmpty(this.Row, this.Column + 1);
                        StartEating();
                    }
                    PrintEngine.PrintSymbol(this.Row, this.Column, Maze.symbolEmpty);
                    this.Direction = Way.Right;
                    this.Column++;
                    if (this.Column > Maze.maxMazeColumn) this.Column = Maze.minMazeColumn;
                }
                else if (way == Way.Down)
                {
                    if (Maze.IsWall(this.Row + 1, this.Column)) return;
                    if (Maze.IsDot(this.Row + 1, this.Column))
                    {
                        this.score += scoreDot;
                        Maze.dotsCounter--;
                        Maze.ChangeDotToEmpty(this.Row + 1, this.Column);
                    }
                    if (Maze.IsPowerPellet(this.Row + 1, this.Column))
                    {
                        this.score += scorePowerPellet;
                        Maze.dotsCounter--;
                        Maze.ChangePelletToEmpty(this.Row + 1, this.Column);
                        StartEating();
                    }
                    PrintEngine.PrintSymbol(this.Row, this.Column, Maze.symbolEmpty);
                    this.Direction = Way.Down;
                    this.Row++;
                    if (this.Row > Maze.maxMazeRow) this.Row = Maze.minMazeRow;
                }
                // prints the new position of pacman
                PrintEngine.PrintSymbol(this.Row, this.Column, this.Symbol);
            }
            catch (Exception e)
            {
                Logger.Log(e);
                PrintEngine.ClearScreen();
                Console.WriteLine("Failed to initialize player!");
                Environment.Exit(0);
            }
        }

        /// <summary>
        /// Move for multi-player without changing direction
        /// </summary>
        public void Move()
        {
            try
            {
                AddLives();
                if (CanEatGhosts)
                {
                    CheckEating();
                }
                switch (this.Direction)
                {
                    case Way.Up: // direction Up
                        // check if there is a wall. if there is wall -> break
                        if (Maze.IsWall(this.Row - 1, this.Column)) break;
                        //add points for dot/pellet and change the matrix;
                        if (Maze.IsDot(this.Row - 1, this.Column))
                        {
                            this.score += scoreDot;
                            Maze.dotsCounter--;
                            Maze.ChangeDotToEmpty(this.Row - 1, this.Column);
                        }
                        if (Maze.IsPowerPellet(this.Row - 1, this.Column))
                        {
                            this.score += scorePowerPellet;
                            Maze.dotsCounter--;
                            Maze.ChangePelletToEmpty(this.Row - 1, this.Column);
                            StartEating();
                        }
                        PrintEngine.PrintSymbol(this.Row, this.Column, Maze.symbolEmpty);
                        // move player position
                        this.Row--;
                        // check if pacman is outside the screen
                        if (this.Row - 1 < Maze.minMazeRow) this.Row = Maze.maxMazeRow;
                        // print symbol on the new position
                        PrintEngine.PrintSymbol(this.Row, this.Column, this.Symbol);
                        break;
                    case Way.Down: // direction Down
                        if (Maze.IsWall(this.Row + 1, this.Column)) break;
                        if (Maze.IsDot(this.Row + 1, this.Column))
                        {
                            this.score += scoreDot;
                            Maze.dotsCounter--;
                            Maze.ChangeDotToEmpty(this.Row + 1, this.Column);
                        }
                        if (Maze.IsPowerPellet(this.Row + 1, this.Column))
                        {
                            this.score += scorePowerPellet;
                            Maze.dotsCounter--;
                            Maze.ChangePelletToEmpty(this.Row + 1, this.Column);
                            StartEating();
                        }
                        PrintEngine.PrintSymbol(this.Row, this.Column, Maze.symbolEmpty);
                        this.Row++;
                        if (this.Row + 1 > Maze.maxMazeRow)
                            this.Row = Maze.minMazeRow; // fixed moving from one end to the other
                        PrintEngine.PrintSymbol(this.Row, this.Column, this.Symbol);
                        break;
                    case Way.Left: // direction Left
                        if (Maze.IsWall(this.Row, this.Column - 1)) break;
                        if (Maze.IsDot(this.Row, this.Column - 1))
                        {
                            this.score += scoreDot;
                            Maze.dotsCounter--;
                            Maze.ChangeDotToEmpty(this.Row, this.Column - 1);
                        }
                        if (Maze.IsPowerPellet(this.Row, this.Column - 1))
                        {
                            this.score += scorePowerPellet;
                            Maze.dotsCounter--;
                            Maze.ChangePelletToEmpty(this.Row, this.Column - 1);
                            StartEating();
                        }
                        PrintEngine.PrintSymbol(this.Row, this.Column, Maze.symbolEmpty);
                        this.Column--;
                        if (this.Column - 1 < Maze.minMazeColumn)
                            this.Column = Maze.maxMazeColumn; // fixed moving from one end to the other
                        PrintEngine.PrintSymbol(this.Row, this.Column, this.Symbol);
                        break;
                    case Way.Right: // direction Right
                        if (Maze.IsWall(this.Row, this.Column + 1)) break;
                        if (Maze.IsDot(this.Row, this.Column + 1))
                        {
                            this.score += scoreDot;
                            Maze.dotsCounter--;
                            Maze.ChangeDotToEmpty(this.Row, this.Column + 1);
                        }
                        if (Maze.IsPowerPellet(this.Row, this.Column + 1))
                        {
                            this.score += scorePowerPellet;
                            Maze.dotsCounter--;
                            Maze.ChangePelletToEmpty(this.Row, this.Column + 1);
                            StartEating();
                        }
                        PrintEngine.PrintSymbol(this.Row, this.Column, Maze.symbolEmpty);
                        this.Column++;
                        if (this.Column + 1 > Maze.maxMazeColumn)
                            this.Column = Maze.minMazeColumn; // fixed moving from one end to the other
                        PrintEngine.PrintSymbol(this.Row, this.Column, this.Symbol);
                        break;
                }
            }
            catch (Exception e)
            {
                Logger.Log(e);
                PrintEngine.ClearScreen();
                Console.WriteLine("Failed to initialize player !");
                Environment.Exit(0);
            }
        }
    }
}
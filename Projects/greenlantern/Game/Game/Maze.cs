using System;
using System.IO;

namespace Game
{
    /// <summary>
    /// A class for the maze.
    /// </summary>
    class Maze
    {
        // variables
        public const int maxScreenX = 140; // max width of the game screen 140
        public const int maxScreenY = 55; // max height of the game screen 60
        public const int fileInputColumn = maxMazeColumn + 1;
        public const int fileInputRow = maxMazeRow + 1;
        public const int freeLines = 5; // lines to hold the player's name, current score and lives
        public const int maxMazeColumn = maxScreenX - 1; // max width of the maze
        public const int maxMazeRow = maxScreenY - freeLines - 1; // max height of the maze
        public const int minMazeRow = 0;
        public const int minMazeColumn = 0;

        public const char symbolDot = '.'; // dot to be eaten 
        public const char symbolPacman1 = 'W'; // pacman1
        public const char symbolPacman2 = 'G'; // pacman2
        public const char symbolGhostPinkSpeedy = 'P'; // ghost pink
        public const char symbolGhostCyanBashful = 'C'; // ghost cyan 
        public const char symbolGhostRedShadow = 'R'; // ghost red
        public const char symbolGhostOrangePokey = 'O'; // ghost orange
        public const char symbolGhostDead = '∞'; // ghost deada
        public const char symbolWall = '|'; // wall
        public const char symbolEmpty = ' '; // space
        public const char symbolPower = '@'; // power pellets
        public const char symbolDoor = '-'; // door 

        public static int dotsCounter = 0;
        public static Random random = new Random();
        public static int rowPacman1;
        public static int columnPacman1;
        public static int rowPacman2;
        public static int columnPacman2;
        public static int rowGhostPink;
        public static int columnGhostPink;
        public static int rowGhostRed;
        public static int columnGhostRed;
        public static int rowGhostCyan;
        public static int columnGhostCyan;
        public static int rowGhostOrange;
        public static int columnGhostOrange;
        private static int currentMaze = 0;

        // key infoes for players

       


        private static readonly string[] files = { "Graphics/maze1.txt", "Graphics/maze2.txt", "Graphics/maze3.txt" }; 

        private static char[,] symbols;

        public static char[,] Matrix
        {
            get { return symbols; }
            set { symbols = value; }
        }

        /// <summary>
        /// Reads a text to generate a maze.
        /// </summary>
        public static void CreateMaze(int numberOfPlayers = 1)
        {
            currentMaze = random.Next(0, 3);

            try
            {
                using (StreamReader reader = new StreamReader(File.OpenRead(files[currentMaze])))
                {

                    Matrix = new char[fileInputRow, fileInputColumn];
                    for (int row = 0; row < Matrix.GetLength(0); row++)
                    {
                        string line = reader.ReadLine();

                        for (int column = 0; column < Matrix.GetLength(1); column++)
                        {
                            Matrix[row, column] = line[column];
                            switch (Matrix[row, column])
                            {
                                case symbolPacman1:
                                    rowPacman1 = row;
                                    columnPacman1 = column;
                                    break;
                                case symbolPacman2:
                                    rowPacman2 = row;
                                    columnPacman2 = column;
                                    if (numberOfPlayers == 1)
                                    {
                                        Matrix[row, column] = symbolEmpty;
                                    }
                                    break;
                                case symbolGhostCyanBashful:
                                    rowGhostCyan = row;
                                    columnGhostCyan = column;
                                    break;
                                case symbolGhostOrangePokey:
                                    rowGhostOrange = row;
                                    columnGhostOrange = column;
                                    break;
                                case symbolGhostPinkSpeedy:
                                    rowGhostPink = row;
                                    columnGhostPink = column;
                                    break;
                                case symbolGhostRedShadow:
                                    rowGhostRed = row;
                                    columnGhostRed = column;
                                    break;
                                case symbolDot:
                                    dotsCounter++;
                                    break;
                                case symbolPower:
                                    dotsCounter++;
                                    break;
                            }
                        }
                    }
                }
            }
            catch (OutOfMemoryException ome)
            {
                Logger.Log(ome);
                PrintEngine.ClearScreen();
                Console.WriteLine("System is out of memory, please close some applications and try again!");
                Environment.Exit(0);
            }
            catch (ArgumentNullException an)
            {
                Logger.Log(an);
                PrintEngine.ClearScreen();
                Console.WriteLine("The chosen pathfile for the level is incorrect (null).");
                Environment.Exit(0);
            }
            catch (ArgumentException ae)
            {
                Logger.Log(ae);
                PrintEngine.ClearScreen();
                Console.WriteLine("The chosen pathfile for game level is empty.");
                Environment.Exit(0);
            }
            catch (FileNotFoundException fnf)
            {
                Logger.Log(fnf);
                PrintEngine.ClearScreen();
                Console.WriteLine("Could not find level {0} file", files[currentMaze]);
                Environment.Exit(0);
            }
            catch (DirectoryNotFoundException dnf)
            {
                Logger.Log(dnf);
                PrintEngine.ClearScreen();
                Console.WriteLine("Could not find {0} directory", files[currentMaze]);
                Environment.Exit(0);
            }
            catch (IOException e)
            {
                Logger.Log(e);
                PrintEngine.ClearScreen();
                Console.WriteLine("Failed to load map data!");
                Environment.Exit(0);
            }
        }

        /// <summary>
        /// Checks if there is a wall on the position
        /// with coordinates row and column
        /// </summary>
        /// <param name="row">input row</param>
        /// <param name="column">input column</param>
        /// <returns>true or false</returns>
        public static bool IsWall(int row, int column)
        {
            if (row > maxMazeRow || row < minMazeRow || column > maxMazeColumn || column < minMazeColumn) return false;
            else if (Matrix[row, column] == symbolWall) return true;
            else return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <returns></returns>
        public static bool IsPowerPellet(int row, int column)
        {
            bool isPellet = false;

            if (row > maxMazeRow || row < minMazeRow || column > maxMazeColumn || column < minMazeColumn)
            {
                return isPellet;
            }
            try
            {
                if (Matrix[row, column] == symbolPower)
                {
                    isPellet = true;
                }
            }
            catch (Exception e)
            {
                Logger.Log(e);
            }

            return isPellet;
        }

        public static bool IsDot(int row, int column)
        {
            bool isDot = false;

            if (row > maxMazeRow || row < minMazeRow || column > maxMazeColumn || column < minMazeColumn)
            {
                return isDot;
            }
            try
            {
                if (Matrix[row, column] == symbolDot)
                {
                    isDot = true;
                }

            }
            catch (Exception e)
            {
                Logger.Log(e);
            }
            return isDot;
        }

        public static void ChangePelletToEmpty(int row, int column)
        {
            try
            {
                if (Matrix[row, column] == symbolPower)
                {
                    Matrix[row, column] = symbolEmpty;
                    // TODO: Don't play the sound here, but in Pacman.cs
                    SoundEngine.PlayEatPowerPelletSound();
                }
            }
            catch (Exception e)
            {
                Logger.Log(e);
            }
        }

        public static void ChangeDotToEmpty(int row, int column)
        {
            try
            {


                Matrix[row, column] = symbolEmpty;
                SoundEngine.PlayEatDotSound();
            }
            catch (Exception e)
            {
                Logger.Log(e);
            }
        }

        public static bool IsDoor(int row, int column)
        {
            if (row > maxMazeRow || row < minMazeRow || column > maxMazeColumn || column < minMazeColumn) return false;
            else if (Matrix[row, column] == symbolDoor) return true;
            else return false;
        }
    }
}

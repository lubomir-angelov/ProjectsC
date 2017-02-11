using System;
using System.IO;
using System.Text;

namespace Game
{
    /// <summary>
    /// A class to handle the printing on the screen.
    /// </summary>
    class PrintEngine
    {
        const string pathGameTitle = "../../Graphics/GameTitle.txt";
        const string pathMenu = "../../Graphics/ScoresAndMenu.txt";
        const string pathGameOver = "../../Graphics/GameOver.txt";
        /// <summary>
        /// Prints an icon on the screen
        /// </summary>
        /// <param name="icon">Input: an icon</param>
        public static void PrintSymbol(int row, int column, char symbol)
        {
            try
            {
                Console.SetCursorPosition(column, row);
                switch (symbol)
                {
                    case Maze.symbolPacman1:
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case Maze.symbolPower:
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        break;
                    case Maze.symbolGhostOrangePokey:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case Maze.symbolGhostPinkSpeedy:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    case Maze.symbolGhostRedShadow:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case Maze.symbolDot:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case Maze.symbolGhostCyanBashful:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        break;
                    case Maze.symbolWall:
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                    case Maze.symbolDoor:
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                    case Maze.symbolGhostDead:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                }
            }
            catch (Exception e)
            {
                Logger.Log(e, row, column, symbol);
                PrintEngine.ClearScreen();
                Console.WriteLine("Internal output error!");
                Environment.Exit(0);
            }

            Console.Write(symbol);
        }

        /// <summary>
        /// Sets the window's size.
        /// </summary>
        public static void SetWindow()
        {
            try
            {
                Console.BufferWidth = Console.WindowWidth = Maze.maxScreenX;
                Console.BufferHeight = Console.WindowHeight = Maze.maxScreenY; // Maze.maxScreenY on my PC is not working with height larger than 58!
            }
            catch (Exception e)
            {
                Logger.Log(e);
                Console.WriteLine("Failed to set window dimensions!");
                Environment.Exit(0);
            }
        }

        /// <summary>
        /// Clears the screen
        /// </summary>
        internal static void ClearScreen()
        {
            Console.Clear();
        }

        /// <summary>
        /// Prints the maze
        /// </summary>
        internal static void PrintMaze()
        {
            try
            {
                for (byte row = 0; row < Maze.Matrix.GetLength(0); row++)
                {
                    for (byte col = 0; col < Maze.Matrix.GetLength(1); col++)
                    {
                        Console.SetCursorPosition(col, row);
                        switch (Maze.Matrix[row, col])
                        {
                            case Maze.symbolPacman1:
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                            case Maze.symbolPower:
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                break;
                            case Maze.symbolGhostOrangePokey:
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                break;
                            case Maze.symbolGhostPinkSpeedy:
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                break;
                            case Maze.symbolGhostRedShadow:
                                Console.ForegroundColor = ConsoleColor.Red;
                                break;
                            case Maze.symbolDot:
                                Console.ForegroundColor = ConsoleColor.Green;
                                break;
                            case Maze.symbolGhostCyanBashful:
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                break;
                            case Maze.symbolWall:
                                Console.ForegroundColor = ConsoleColor.Gray;
                                break;
                            case Maze.symbolDoor:
                                Console.ForegroundColor = ConsoleColor.Gray;
                                break;
                        }
                        Console.OutputEncoding = Encoding.Unicode;
                        Console.WriteLine(Maze.Matrix[row, col]);
                    }
                }

            }
            catch (Exception e)
            {
                Logger.Log(e);
                PrintEngine.ClearScreen();
                Console.WriteLine("Failed to print map!");
                Environment.Exit(0);
            }
        }

        /// <summary>
        /// Prints score and lives for each player
        /// </summary>
        /// <param name="pacman"></param>
        internal static void PrintScoreLives(Pacman[] pacmans)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.White;
                for (int indexOffset = 0; indexOffset < pacmans.Length; indexOffset++)
                {
                    Console.SetCursorPosition(Maze.minMazeColumn + 1 + indexOffset * 120, Maze.maxMazeRow + 2);
                    Console.Write("Score: ");
                    Console.SetCursorPosition(Maze.minMazeColumn + 1 + indexOffset * 120, Maze.maxMazeRow + 3);
                    Console.Write("Lives: ");

                    Console.SetCursorPosition(Maze.minMazeColumn + 8 + indexOffset * 120, Maze.maxMazeRow + 2);
                    Console.Write(pacmans[indexOffset].Score);
                    Console.SetCursorPosition(Maze.minMazeColumn + 8 + indexOffset * 120, Maze.maxMazeRow + 3);
                    Console.Write(pacmans[indexOffset].Lives);

                }
            }
            catch (Exception e)
            {
                Logger.Log(e);
            }
        }

        /// <summary>
        /// Prints Game Over screen
        /// </summary>
        /// <param name="player"></param>
        internal static void PrintEnd(Player[] player, int newID) // TODO: Print GameOver screen with scores
        {
            const int gameOverHeight = 11;
            const int highscoresAndMenuHeight = 40;
            try
            {
                StreamReader reader = new StreamReader(pathGameOver); // Print game over screen
                Console.ForegroundColor = ConsoleColor.Red;
                for (int row = 0; row < gameOverHeight; row++)
                {
                    Console.Write(reader.ReadLine());
                }
                reader.Close();

                reader = new StreamReader(pathMenu); // Print scores and menu boxes
                Console.ForegroundColor = ConsoleColor.White;
                for (int row = 0; row < highscoresAndMenuHeight; row++)
                {
                    Console.Write(reader.ReadLine());
                }
                reader.Close();

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;

                for (int index = 0; index < player.Length; index++) // Print scores
                {
                    // outline new scores
                    if (player[index].ID >= newID)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    Console.SetCursorPosition(17, 25 + index);
                    Console.Write(player[index].Name);
                    Console.SetCursorPosition(45, 25 + index);
                    Console.Write(player[index].Score);

                    Console.ForegroundColor = ConsoleColor.White;
                }

                Console.SetCursorPosition(90, 30);
                Console.Write("Press any key to exit");
                Console.ReadKey();
                Console.SetCursorPosition(90, 30);
            }
            catch (Exception e)
            {
                Logger.Log(e);
                PrintEngine.ClearScreen();
                Console.WriteLine("Failed to load template file!");
                Environment.Exit(0);
            }
        }

        /// <summary>
        /// Prints the intro screen for the game with Highscores
        /// </summary>
        /// <param name="player"></param>
        internal static void PrintIntro(Player[] player)
        {
            const int gameTitleHeight = 11;
            const int highscoresAndMenuHeight = 40;
            try
            {
                StreamReader reader = new StreamReader(pathGameTitle); // Print game title
                Console.ForegroundColor = ConsoleColor.Red;
                for (int row = 0; row < gameTitleHeight; row++)
                {
                    Console.Write(reader.ReadLine());
                }
                reader.Close();

                reader = new StreamReader(pathMenu); // Print scores and menu boxes
                Console.ForegroundColor = ConsoleColor.White;
                for (int row = 0; row < highscoresAndMenuHeight; row++)
                {
                    Console.Write(reader.ReadLine());
                }
                reader.Close();

                for (int index = 0; index < player.Length; index++) // Print scores
                {
                    Console.SetCursorPosition(17, 25 + index);
                    Console.Write(player[index].Name);
                    Console.SetCursorPosition(45, 25 + index);
                    Console.Write(player[index].Score);
                }

                // TODO: A better menu possibly

                Console.SetCursorPosition(90, 25);
                Console.Write("1 -> Single player game");
                Console.SetCursorPosition(90, 26);
                Console.Write("2 -> Multiplayer game");
                Console.SetCursorPosition(90, 27);
                Console.Write("3 -> Exit");
                Console.SetCursorPosition(90, 29);
                Console.Write("Your choice: ");
                Console.SetCursorPosition(103, 29);
            }
            catch (Exception e)
            {
                Logger.Log(e);
                PrintEngine.ClearScreen();
                Console.WriteLine("Failed to load template file!");
                Environment.Exit(0);
            }
        }

        internal static void PrintScoreLives(Pacman pacman1, Pacman pacman2)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(Maze.minMazeColumn + 8, Maze.maxMazeRow + 2);
                Console.Write(pacman1.Score);
                Console.SetCursorPosition(Maze.minMazeColumn + 8, Maze.maxMazeRow + 3);
                Console.Write(pacman1.Lives);

                Console.SetCursorPosition(Maze.maxMazeColumn - 20, Maze.maxMazeRow + 2);
                Console.Write(pacman2.Score);
                Console.SetCursorPosition(Maze.maxMazeColumn - 20, Maze.maxMazeRow + 3);
                Console.Write(pacman2.Lives);

            }
            catch (Exception e)
            {
                Logger.Log(e);
            }
        }
    }
}

using System.Threading;
using System;

namespace Game
{
    class Game
    {
        static void Main()
        {
            int menuChoice = 0; // User's choice in the menu
            int numberOfPlayers = 0; // Number of players 

            // sets the width and the height of the window.
            PrintEngine.SetWindow();
            // create the score engine
            ScoreEngine scoreEngine = new ScoreEngine();
            // load the scores from a file or generate empty ones
            scoreEngine.LoadScores();
            // show the intro screen and the menu
            PrintEngine.PrintIntro(scoreEngine.Scores);
            // Starts the intro music
            SoundEngine.PlayIntroSound(true);
            

            while (menuChoice == 0) // First choice or invalid input
            {
                try
                {
                    menuChoice = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    menuChoice = 0;
                    Logger.Log(e);
                }

                switch (menuChoice)
                {
                    case 1: // One player
                        numberOfPlayers = 1;
                        break;
                    case 2: // Two players
                        numberOfPlayers = 2;
                        break;
                    case 3: // Exit
                        Console.SetCursorPosition(90, 30);
                        Environment.Exit(0);
                        break;
                    default: // Invalid input
                        menuChoice = 0;
                        Console.SetCursorPosition(103, 29);
                        Console.Write(" ");
                        Console.SetCursorPosition(103, 29);
                        break;
                }
            }
 
            if (numberOfPlayers == 1)
            {
                Console.SetCursorPosition(90, 30);
                // create player 1
                Player player1 = new Player(1);
                // start the loop for the game
                while (true)
                {
                    // create the maze
                    Maze.CreateMaze(numberOfPlayers);
                    // create pacman
                    Pacman pacman1 = new Pacman(Maze.rowPacman1, Maze.columnPacman1, Maze.symbolPacman1, player1);
                    // clear the screen
                    PrintEngine.ClearScreen();
                    // create the ghosts
                    Ghost[] ghosts = new Ghost[4];
                    ghosts[0] = new Shadow(Maze.rowGhostRed, Maze.columnGhostRed, Maze.symbolGhostRedShadow); // creates the red ghost
                    ghosts[1] = new Speedy(Maze.rowGhostPink, Maze.columnGhostPink, Maze.symbolGhostPinkSpeedy); // creates the pink ghost
                    ghosts[2] = new Bashful(Maze.rowGhostCyan, Maze.columnGhostCyan, Maze.symbolGhostCyanBashful); // creates the cyan ghost
                    ghosts[3] = new Pokey(Maze.rowGhostOrange, Maze.columnGhostOrange, Maze.symbolGhostOrangePokey);  // creates the orange ghost
                    // print the maze
                    PrintEngine.PrintMaze();
                    // print player's score and lives
                    PrintEngine.PrintScoreLives(new Pacman[] {pacman1});
                    // start the loop for the maze
                    while (true)
                    {
                        // move pacman
                        pacman1.ChangeDirectionAndMoveOrJustMove();
                        //move all ghosts
                        foreach (Ghost ghost in ghosts)
                        {
                            ghost.MoveGhost(pacman1);
                        }
                        // check interferences between pacman and the ghosts
                        foreach (Ghost ghost in ghosts)
                        {
                            pacman1.CheckGhost(ghost);
                        }
                        // print player's score and lives
                        PrintEngine.PrintScoreLives(new Pacman[] {pacman1});
                        if (pacman1.Lives<=0)
                        {
                            break;
                        }
                        if (Maze.dotsCounter <= 0)
                        {
                            break;
                        }

                        // thread sleep
                        Thread.Sleep(100);
                    }
                    // set player's score and lives based on pacman for the new maze
                    player1.Lives = pacman1.Lives;
                    player1.Score = pacman1.Score;
                    player1.ID = scoreEngine.LastID + 1;
                    if (player1.Lives <=0)
                    {
                        break;
                    }
                }
                // merge player's score with existing scores
                scoreEngine.MergeSort(player1);
                // saves the scores
                scoreEngine.SaveScores();
                // load the scores for outlining in the end game screen

                // clear the screen
                PrintEngine.ClearScreen();
                // print end screen
                SoundEngine.PlayIntroSound(true);
                PrintEngine.PrintEnd(scoreEngine.Scores, scoreEngine.LastID + 1);
            }
            else if (numberOfPlayers == 2) // Just in case
            {
                Console.SetCursorPosition(90, 30);
                // create player 1
                Player player1 = new Player(1);
                // create player 2
                Console.SetCursorPosition(90, 31);
                Player player2 = new Player(2);
                // start the loop for the game
                while (true)
                {
                    // create the maze
                    Maze.CreateMaze(numberOfPlayers);

                    // create pacmans

                    var pacman1 = new Pacman(Maze.rowPacman1, Maze.columnPacman1, Maze.symbolPacman1, player1);
                    var pacman2 = new Pacman(Maze.rowPacman2, Maze.columnPacman2, Maze.symbolPacman2, player2);
                    
                    // clear the screen
                    PrintEngine.ClearScreen();
                    // create the ghosts
                    Ghost[] ghosts = new Ghost[4];
                    ghosts[0] = new Shadow(Maze.rowGhostRed, Maze.columnGhostRed, Maze.symbolGhostRedShadow); // creates the red ghost
                    ghosts[1] = new Speedy(Maze.rowGhostPink, Maze.columnGhostPink, Maze.symbolGhostPinkSpeedy); // creates the pink ghost
                    ghosts[2] = new Bashful(Maze.rowGhostCyan, Maze.columnGhostCyan, Maze.symbolGhostCyanBashful); // creates the cyan ghost
                    ghosts[3] = new Pokey(Maze.rowGhostOrange, Maze.columnGhostOrange, Maze.symbolGhostOrangePokey);  // creates the orange ghost
                    // print the maze
                    PrintEngine.PrintMaze();
                    // print player's score and lives
                    PrintEngine.PrintScoreLives(new Pacman[] {pacman1, pacman2});
                    // start the loop for the maze
                    while (true)
                    {
                        if (Console.KeyAvailable) //do this only if key is pressed
                        {
                            ConsoleKeyInfo userInput = Console.ReadKey();

                            if (userInput.Key == Pacman.playerOneUp)
                            {
                                pacman1.ChangeDirectionAndMove(Pacman.Way.Up);
                            }
                            else if (userInput.Key == Pacman.playerOneDown)
                            {
                                pacman1.ChangeDirectionAndMove(Pacman.Way.Down);
                            }
                            else if (userInput.Key == Pacman.playerOneLeft)
                            {
                                pacman1.ChangeDirectionAndMove(Pacman.Way.Left);
                            }
                            else if (userInput.Key == Pacman.playerOneRight)
                            {
                                pacman1.ChangeDirectionAndMove(Pacman.Way.Right);
                            }
                            else if (userInput.Key == Pacman.playerTwoDown)
                            {
                                pacman2.ChangeDirectionAndMove(Pacman.Way.Down);
                            }
                            else if (userInput.Key == Pacman.playerTwoLeft)
                            {
                                pacman2.ChangeDirectionAndMove(Pacman.Way.Left);
                            }
                            else if (userInput.Key == Pacman.playerTwoRight)
                            {
                                pacman2.ChangeDirectionAndMove(Pacman.Way.Right);
                            }
                            else if (userInput.Key == Pacman.playerTwoUp)
                        {
                                pacman2.ChangeDirectionAndMove(Pacman.Way.Up);
                        }
                        }
                        else
                        {
                            pacman1.Move();
                            pacman2.Move();
                        }

                        //move all ghosts
                        foreach (Ghost ghost in ghosts)
                        {
                            ghost.MoveGhost(pacman1, pacman2);
                        }
                        // check interferences between pacman and the ghosts
                        foreach (Ghost ghost in ghosts)
                        {

                            pacman1.CheckGhost(ghost);
                            pacman2.CheckGhost(ghost);
                            }
                        // print player's score and lives
                        PrintEngine.PrintScoreLives(new Pacman[] {pacman1, pacman2});
                        // thread sleep
                        Thread.Sleep(100);
                        if (pacman1.Lives <= 0 || pacman2.Lives <=0)
                        {
                            break;
                        }
                        if (Maze.dotsCounter <= 0)
                        {
                            break;
                        }
                    }
                    // set player's score and lives based on pacman for the new maze
                    player1.Lives = pacman1.Lives;
                    player1.Score = pacman1.Score;
                    player1.ID = scoreEngine.LastID + 1;
                    player2.Lives = pacman2.Lives;
                    player2.Score = pacman2.Score;
                    player2.ID = scoreEngine.LastID + 2;

                    if (player1.Lives <= 0 || player2.Lives <= 0)
                    {
                        break;
                    }
                }
                // merge player scores with existing scores
                scoreEngine.MergeSort(player1);
                scoreEngine.MergeSort(player2);
                // saves the scores
                scoreEngine.SaveScores();
                // load the scores for outlining in the end game screen

                // clear the screen
                PrintEngine.ClearScreen();
                // print end screen
                SoundEngine.PlayIntroSound(true);
                PrintEngine.PrintEnd(scoreEngine.Scores, scoreEngine.LastID + 1);
            }
        }
    }
}

using System;

namespace Game
{
    using System.Collections.Generic;

    /// <summary>
    /// A general class for the ghosts
    /// </summary>
    abstract class Ghost
    {
        protected bool isEaten = false;
        protected int row;
        protected int column;
        protected char symbol;
        protected Way direction;
        protected int homeRow;
        protected int homeColumn;

        /// <summary>
        /// Property for symbol field
        /// </summary>
        public char Symbol
        {
            get { return this.symbol; }
            set { this.symbol = value; }
        }

        /// <summary>
        /// Property for column field
        /// </summary>
        public int Column
        {
            get { return this.column; }
            set { this.column = value; }
        }

        /// <summary>
        /// Property for row field
        /// </summary>
        public int Row
        {
            get { return this.row; }
            set { this.row = value; }
        }

        /// <summary>
        /// Enumerator for direction of Ghost
        /// </summary>
        public enum Way
        {
            /// <summary>
            /// Direction up
            /// </summary>
            Up = 0,
            /// <summary>
            /// Direction down
            /// </summary>
            Left = 1,
            /// <summary>
            /// Direction left
            /// </summary>
            Down = 2,
            /// <summary>
            /// Direction right
            /// </summary>
            Right = 3
        }

        /// <summary>
        /// Property for Way enumerator field
        /// </summary>
        public Way Direction
        {
            get { return this.direction; }
            set { this.direction = value; }
        }

        /// <summary>
        /// Property for isBeEaten field
        /// </summary>
        public bool IsEaten
        {
            get { return this.isEaten; }
            set { this.isEaten = value; }
        }

        /// <summary>
        /// Property for homeColumn field
        /// </summary>
        protected int HomeColumn
        {
            get { return this.homeColumn; }
            set { this.homeColumn = value; }
        }

        /// <summary>
        /// Property for home field
        /// </summary>
        protected int HomeRow
        {
            get { return this.homeRow; }
            set { this.homeRow = value; }
        }

        /// <summary>
        /// Constructor for Ghost
        /// </summary>
        /// <param name="row">set the Ghost row</param>
        /// <param name="column">set the Ghost column</param>
        /// <param name="symbol">set the Ghost symbol</param>
        protected Ghost(int row, int column, char symbol)
        {
            this.row = row;
            this.column = column;
            this.symbol = symbol;
            
        }

        /// <summary>
        /// Eaten ghost tries to find way to home.
        /// </summary>
        protected void GhostGoesHome()
        {
            //int deltaRow = this.Row - this.HomeRow;
            //int deltaColl = this.Column - this.HomeColumn;

            //if (deltaRow > 0 && !Maze.IsWall(this.Row - 1, this.Column))
            //{
            //    this.Row--;
            //    return;
            //}
            //else if (deltaRow < 0 && !Maze.IsWall(this.Row + 1, this.Column))
            //{
            //    this.Row++;
            //    return;
            //}
            //else if (deltaColl > 0 && !Maze.IsWall(this.Row, this.Column-1))
            //{
            //    this.Column--;
            //    return;
            //}
            //else if (deltaColl < 0 && !Maze.IsWall(this.Row, this.Column + 1))
            //{
            //    this.Column++;
            //    return;
            //}
            //this.Row = this.HomeRow;
            //this.Column = this.HomeColumn;
            //return;

            Coordinates home = FindNextStep(this.HomeRow, this.HomeColumn);
            this.Row = home.Row;
            this.column = home.Coll;
        }

        /// <summary>
        /// Structure with coordinates indicated one pisition in the matrix
        /// </summary>
        public struct Coordinates
        {
            private int row;
            private int coll;

            public Coordinates(int row, int coll)
            {
                this.row = row;
                this.coll = coll;
            }

            public int Row
            {
                get { return this.row; }
                set { this.row = value; }
            }

            public int Coll
            {
                get { return this.coll; }
                set { this.coll = value; }
            }
        }

        public abstract void MoveGhost(Pacman pacman);
        public abstract void MoveGhost(Pacman pacman1, Pacman pacman2);

        protected bool IsCrossRoad()
        {
            bool upEmpty = !Maze.IsWall(this.Row - 1, this.Column);
            bool leftEmpty = !Maze.IsWall(this.Row, this.Column - 1);
            bool rightEmpty = !Maze.IsWall(this.Row, this.Column + 1);
            bool downEmpty = !Maze.IsWall(this.Row + 1, this.Column);

            if (this.Direction == Way.Up) // up
            {
                if (rightEmpty || leftEmpty) return true;
            }
            else if (this.Direction == Way.Down) // down
            {
                if (rightEmpty || leftEmpty) return true;
            }
            else if (this.Direction == Way.Left) // left
            {
                if (upEmpty || downEmpty) return true;
            }
            else if (this.Direction == Way.Right) // right
            {
                if (upEmpty || downEmpty) return true;
            }

            return false;
        }

        protected int DistanceToPacman(Pacman pacman)
        {
            double x = pacman.Column - this.column;
            double y = pacman.Row - this.row;

            return (int)Math.Sqrt(x * x + y * y);
        }

        protected void ChangeToWhereAvailableDirection()
        {
            bool upEmpty = !Maze.IsWall(this.Row - 1, this.Column);
            bool leftEmpty = !Maze.IsWall(this.Row, this.Column - 1);
            bool rightEmpty = !Maze.IsWall(this.Row, this.Column + 1);
            bool downEmpty = !Maze.IsWall(this.Row + 1, this.Column);

            if (this.Direction == Way.Up) // up
            {
                while (true)
                {
                    Way temp = (Way)Maze.random.Next(0, 4);

                    if (temp == Ghost.Way.Left && leftEmpty)
                    {
                        this.Direction = Ghost.Way.Left;
                        break;
                    }
                    else if (temp == Ghost.Way.Right && rightEmpty)
                    {
                        this.Direction = Ghost.Way.Right;
                        break;
                    }
                    else if (temp == Ghost.Way.Down)
                    {
                        continue;

                    }
                    else if (temp == Ghost.Way.Up && upEmpty)
                    {
                        break;
                    }
                }
            }
            else if (this.Direction == Way.Down) // down
            {
                while (true)
                {
                    Way temp = (Way)Maze.random.Next(0, 4);

                    if (temp == Ghost.Way.Left && leftEmpty)
                    {
                        this.Direction = Ghost.Way.Left;
                        break;
                    }
                    else if (temp == Ghost.Way.Right && rightEmpty)
                    {
                        this.Direction = Ghost.Way.Right;
                        break;
                    }
                    else if (temp == Ghost.Way.Down && downEmpty)
                    {
                        break;

                    }
                    else if (temp == Ghost.Way.Up)
                    {
                        continue;
                    }
                }
            }
            else if (this.Direction == Way.Left) // left
            {
                while (true)
                {
                    Way temp = (Way)Maze.random.Next(0, 4);

                    if (temp == Ghost.Way.Left && leftEmpty)
                    {
                        break;
                    }
                    else if (temp == Ghost.Way.Right)
                    {
                        continue;
                    }
                    else if (temp == Ghost.Way.Down && downEmpty)
                    {
                        this.Direction = Ghost.Way.Down;
                        break;
                    }
                    else if (temp == Ghost.Way.Up && upEmpty)
                    {
                        this.Direction = Ghost.Way.Up;
                        break;
                    }
                }
            }
            else if (this.Direction == Way.Right) // right
            {
                while (true)
                {
                    Way temp = (Way)Maze.random.Next(0, 4);

                    if (temp == Ghost.Way.Left)
                    {
                        continue;
                    }
                    else if (temp == Ghost.Way.Right && rightEmpty)
                    {
                        this.Direction = Ghost.Way.Right;
                        break;
                    }
                    else if (temp == Ghost.Way.Down && downEmpty)
                    {
                        this.Direction = Ghost.Way.Down;
                        break;

                    }
                    else if (temp == Ghost.Way.Up && upEmpty)
                    {

                        this.Direction = Ghost.Way.Up;
                        break;
                    }
                }
            }
        }

        protected void ChangeToRandomDirection()
        {
            int existingDirection = (int)this.Direction;
            int opositeExistingDirextion = (((int)existingDirection) + 2) % 4;
            while (true)
            {
                int tempDirection = Maze.random.Next(0, 4);
                if (tempDirection == existingDirection || tempDirection == opositeExistingDirextion)
                {
                    continue;
                }
                else
                {
                    Console.SetCursorPosition(80, 53);
                    Console.Write(this.Direction);
                    this.Direction = (Way)tempDirection;
                    break;
                }
                // this is for testing

            }
        }
        /// <summary>
        /// Checks what symbol present on current position in the global symbol matrix Maze
        /// </summary>
        protected void FigureWhatToPrintOnExsitingPosition()
        {
            if (Maze.IsDot(this.Row, this.Column))
            {
                PrintEngine.PrintSymbol(this.Row, this.Column, Maze.symbolDot);
            }
            else if (Maze.IsPowerPellet(this.Row, this.Column))
            {
                PrintEngine.PrintSymbol(this.Row, this.Column, Maze.symbolPower);
            }
            else if (Maze.IsDoor(this.Row, this.Column))
            {
                PrintEngine.PrintSymbol(this.Row, this.Column, Maze.symbolDoor);
            }
            else
            {
                PrintEngine.PrintSymbol(this.Row, this.Column, Maze.symbolEmpty);
            }
        }

        protected void MoveOneStepBasedOnDirection()
        {
            switch (this.Direction)
            {
                case Way.Up: // direction Up
                    FigureWhatToPrintOnExsitingPosition();
                    // move player position
                    this.Row--;
                    // check if pacman is outside the screen
                    if (this.Row < 0) this.Row = Maze.maxMazeRow;
                    PrintEngine.PrintSymbol(this.Row, this.Column, this.Symbol);
                    break;
                case Way.Down:  // direction Down
                    FigureWhatToPrintOnExsitingPosition();
                    this.Row++;
                    if (this.Row > Maze.maxMazeRow) this.Row = 0;
                    PrintEngine.PrintSymbol(this.Row, this.Column, this.Symbol);
                    break;
                case Way.Left: // direction Left
                    FigureWhatToPrintOnExsitingPosition();
                    this.Column--;
                    if (this.Column < 0) this.Column = Maze.maxMazeColumn;
                    PrintEngine.PrintSymbol(this.Row, this.Column, this.Symbol);
                    break;
                case Way.Right: // direction Right
                    FigureWhatToPrintOnExsitingPosition();
                    this.Column++;
                    if (this.Column > Maze.maxMazeColumn) this.Column = 0;
                    PrintEngine.PrintSymbol(this.Row, this.Column, this.Symbol);
                    break;
            }
        }
        protected void ChangeDirection(Coordinates nextStep)
        {
            if (nextStep.Row == this.Row + 1)
            {
                this.direction = Way.Right;
            }
            else if (nextStep.Row == this.Row - 1)
            {
                this.direction = Way.Down;
            }
            else if (nextStep.Coll == this.Column + 1)
            {
                this.direction = Way.Down;
            }
            else if (nextStep.Coll == this.Column - 1)
            {
                this.direction = Way.Up;
            }
        }

        protected bool HitWall()
        {
            switch (this.direction)
            {
                case Way.Up: return Maze.IsWall(this.row - 1, this.column);
                case Way.Down: return Maze.IsWall(this.row + 1, this.column);
                case Way.Left: return Maze.IsWall(this.row, this.column - 1);
                case Way.Right: return Maze.IsWall(this.row, this.column + 1);
                default: return true;
            }
        }

        protected bool IsOnCrossroad()
        {
            int numberOfPossibleWays = 0;

            for (int i = 1; i < 10 && this.row + i < Maze.maxMazeRow; i++)
            {
                if (Maze.Matrix[this.row + i, this.column] == '|')
                {
                    i = 10;
                    numberOfPossibleWays++;
                }
            }

            for (int i = 1; i < 10 && this.row - i >= 0; i++)
            {
                if (Maze.Matrix[this.row - i, this.column] == '|')
                {
                    i = 10;
                    numberOfPossibleWays++;
                }
            }

            for (int i = 1; i < 10 && this.column - i >= 0; i++)
            {
                if (Maze.Matrix[this.row, this.column - i] == '|')
                {
                    i = 10;
                    numberOfPossibleWays++;
                }
            }

            for (int i = 1; i < 10 && this.column + i < Maze.maxMazeColumn; i++)
            {
                if (Maze.Matrix[this.row, this.column + i] == '|')
                {
                    i = 10;
                    numberOfPossibleWays++;
                }
            }

            return numberOfPossibleWays >= 3;
        }

        protected static Coordinates GetNextStep(Coordinates current, int[,] pathsMatrix)
        {
            if (pathsMatrix[current.Row, current.Coll] == 0)
            {
                return current;
            }

            while (pathsMatrix[current.Row, current.Coll] != 1)
            {
                if (pathsMatrix[current.Row, current.Coll - 1] == pathsMatrix[current.Row, current.Coll] - 1)
                {
                    current = new Coordinates(current.Row, current.Coll - 1);
                }
                else if (pathsMatrix[current.Row, current.Coll + 1] == pathsMatrix[current.Row, current.Coll] - 1)
                {
                    current = new Coordinates(current.Row, current.Coll + 1);
                }
                else if (pathsMatrix[current.Row - 1, current.Coll] == pathsMatrix[current.Row, current.Coll] - 1)
                {
                    current = new Coordinates(current.Row - 1, current.Coll);
                }
                else if (pathsMatrix[current.Row + 1, current.Coll] == pathsMatrix[current.Row, current.Coll] - 1)
                {
                    current = new Coordinates(current.Row + 1, current.Coll);
                }
            }

            return current;
        }

        protected static void AddNeighbours(Coordinates current, int[,] pathsMatrix, ref Queue<Coordinates> nextPoints)
        {
            if (current.Coll + 1 < Maze.maxMazeColumn &&
                !Maze.IsWall(current.Row, current.Coll + 1) &&
                pathsMatrix[current.Row, current.Coll + 1] == 0)
            {
                pathsMatrix[current.Row, current.Coll + 1] = pathsMatrix[current.Row, current.Coll] + 1;
                nextPoints.Enqueue(new Coordinates(current.Row, current.Coll + 1));
            }

            if (current.Coll - 1 > 0 &&
                !Maze.IsWall(current.Row, current.Coll - 1) &&
                pathsMatrix[current.Row, current.Coll - 1] == 0)
            {
                pathsMatrix[current.Row, current.Coll - 1] = pathsMatrix[current.Row, current.Coll] + 1;
                nextPoints.Enqueue(new Coordinates(current.Row, current.Coll - 1));
            }

            if (current.Row + 1 < Maze.maxMazeRow &&
                !Maze.IsWall(current.Row + 1, current.Coll) &&
                pathsMatrix[current.Row + 1, current.Coll] == 0)
            {
                pathsMatrix[current.Row + 1, current.Coll] = pathsMatrix[current.Row, current.Coll] + 1;
                nextPoints.Enqueue(new Coordinates(current.Row + 1, current.Coll));
            }

            if (current.Row - 1 > 0 &&
                !Maze.IsWall(current.Row - 1, current.Coll) &&
                pathsMatrix[current.Row - 1, current.Coll] == 0)
            {
                pathsMatrix[current.Row - 1, current.Coll] = pathsMatrix[current.Row, current.Coll] + 1;
                nextPoints.Enqueue(new Coordinates(current.Row - 1, current.Coll));
            }
        }

        protected Coordinates FindNextStep(int y, int x)
        {
            int[,] pathsMatrix = new int[Maze.maxMazeRow, Maze.maxMazeColumn];

            Queue<Coordinates> nextPoints = new Queue<Coordinates>();
            Coordinates next = new Coordinates(this.Row, this.Column);

            while (next.Coll != x || next.Row != y)
            {
                AddNeighbours(next, pathsMatrix, ref nextPoints);  // TODO check
                if (nextPoints.Count != 0)
                {
                    next = nextPoints.Peek();
                    nextPoints.Dequeue();
                }
                else
                {
                    return new Coordinates(this.row, this.column);
                }
            }

            return GetNextStep(next, pathsMatrix);
        }


    }
}
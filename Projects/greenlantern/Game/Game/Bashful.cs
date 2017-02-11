using System;

namespace Game
{
    class Bashful : Ghost
    {
        private int steps;

        public Bashful(int row, int column, char symbol)
            : base(row, column, symbol)
        {
            this.Direction = Way.Up;
            this.isEaten = false;
            this.steps = 0;
            this.homeColumn = column;
            this.homeRow = row;
        }

        public override void MoveGhost(Pacman pacman1, Pacman pacman2)
        {
            if (this.IsEaten)
            {
                this.FigureWhatToPrintOnExsitingPosition();
                this.GhostGoesHome();
                PrintEngine.PrintSymbol(this.Row, this.Column, this.Symbol);
                if (this.Row == this.HomeRow && this.Column == this.HomeColumn)
                {
                    this.Symbol = Maze.symbolGhostCyanBashful;
                    this.isEaten = false;
                }
            }
            else if (pacman1.CanEatGhosts)
            {
                // crossroad
                if (this.IsCrossRoad())
                {
                    // might change direction
                    this.ChangeToWhereAvailableDirection();
                    // move one position
                    this.MoveOneStepBasedOnDirection();
                }
                else // continue on existing direction
                {
                    this.MoveOneStepBasedOnDirection();
                }
            }
            else if (!pacman1.CanEatGhosts)
            {
                // crossroad
                if (this.IsCrossRoad())
                {
                    // might change direction
                    this.ChangeToWhereAvailableDirection();
                    // move one position
                    this.MoveOneStepBasedOnDirection();
                }
                else // continue on existing direction
                {
                    // move one position
                    this.MoveOneStepBasedOnDirection();
                }
            }
        }

        public override void MoveGhost(Pacman pacman)
        {

            if (this.IsEaten)
            {
                FigureWhatToPrintOnExsitingPosition();
                this.GhostGoesHome();
                PrintEngine.PrintSymbol(this.Row, this.Column, this.Symbol);
                if (this.Row == this.HomeRow && this.Column == this.HomeColumn)
                {
                    this.Symbol = Maze.symbolGhostCyanBashful;
                    this.isEaten = false;
                }
            }
            else if (pacman.CanEatGhosts)
            {
                // crossroad
                if (this.IsCrossRoad())
                {
                    this.ChangeToWhereAvailableDirection();
                    this.MoveOneStepBasedOnDirection();
                }
                else // continue on existing direction
                {
                    this.MoveOneStepBasedOnDirection();
                }
            }

            else if (!pacman.CanEatGhosts)
            {
                if (DistanceToPacman(pacman) > 15)
                {
                    // crossroad
                    if (this.IsCrossRoad())
                    {
                        // might change direction
                        this.ChangeToWhereAvailableDirection();
                        // move one position
                        this.MoveOneStepBasedOnDirection();
                    }
                    else // continue on existing direction
                    {
                        // move one position
                        this.MoveOneStepBasedOnDirection();
                    }
                }

                else
                {

                    this.FigureWhatToPrintOnExsitingPosition();

                    if (steps % 3 != 0)
                    {
                        Coordinates nextStep = this.FindNextStep(pacman.Row, pacman.Column);

                        this.row = nextStep.Row;
                        this.column = nextStep.Coll;

                        this.ChangeDirection(nextStep);
                    }
                    this.steps++;
                    PrintEngine.PrintSymbol(this.Row, this.Column, this.Symbol);
                }


            }
        }


    }
}


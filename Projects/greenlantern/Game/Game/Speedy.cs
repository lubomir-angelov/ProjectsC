using System;
using System.Collections.Generic;

namespace Game
{
    class Speedy : Ghost
    {
        private int stepsMade;

        public Speedy(int row, int column, char symbol)
            : base(row,column, symbol)
        {
            this.direction = Way.Up;
            this.stepsMade = 0;
            this.isEaten = false;
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
                    this.Symbol = Maze.symbolGhostPinkSpeedy;
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
            else
            {
                FigureWhatToPrintOnExsitingPosition();

                int x = 0;
                int y = 0;

                if (DistanceToPacman(pacman1) < DistanceToPacman(pacman2))
                {
                    x = pacman1.Column;
                    y = pacman1.Row;
                }
                else
                {
                    x = pacman2.Column;
                    y = pacman2.Row;
                }

                if (stepsMade % 2 == 0)
                {
                    Coordinates nextStep = this.FindNextStep(y, x);

                    this.row = nextStep.Row;
                    this.column = nextStep.Coll;

                    this.ChangeDirection(nextStep);
                }
                stepsMade++;
                PrintEngine.PrintSymbol(this.Row, this.Column, this.Symbol);
            }
        }

        public override void MoveGhost(Pacman pacman)
        {
            if (this.IsEaten)
            {
                this.FigureWhatToPrintOnExsitingPosition();
                this.GhostGoesHome();
                PrintEngine.PrintSymbol(this.Row, this.Column, this.Symbol);
                if (this.Row == this.HomeRow && this.Column == this.HomeColumn)
                {
                    this.Symbol = Maze.symbolGhostPinkSpeedy;
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
            else
            {
                
                this.FigureWhatToPrintOnExsitingPosition();

                if (stepsMade % 3 != 0)
                {
                    Coordinates nextStep = this.FindNextStep(pacman.Row, pacman.Column);

                    this.row = nextStep.Row;
                    this.column = nextStep.Coll;

                    this.ChangeDirection(nextStep);
                }
                this.stepsMade++;
                PrintEngine.PrintSymbol(this.Row, this.Column, this.Symbol);
               
            }
        }
    }
}
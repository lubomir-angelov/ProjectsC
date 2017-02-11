using System;

namespace Game
{
    class Pokey : Ghost
    {
        public Pokey(int row, int column, char symbol)
            : base(row, column, symbol)
        {
            this.Direction = Way.Up;
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
                    this.Symbol = Maze.symbolGhostOrangePokey;
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
                this.FigureWhatToPrintOnExsitingPosition();
                this.GhostGoesHome();
                PrintEngine.PrintSymbol(this.Row, this.Column, this.Symbol);
                if (this.Row == this.HomeRow && this.Column == this.HomeColumn)
                {
                    this.Symbol = Maze.symbolGhostOrangePokey;
                    this.isEaten = false;
                }
            }
            else if (pacman.CanEatGhosts)
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
            else if(!pacman.CanEatGhosts)
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
    }
}

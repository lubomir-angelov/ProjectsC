using System;
using System.Collections.Generic;

namespace Game
{
    class Shadow : Ghost
    {
        private int stepsMade;

        public Shadow(int row, int column, char symbol)
            : base(row, column, symbol)
        {
            this.Direction = Ghost.Way.Up;
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
                    this.Symbol = Maze.symbolGhostRedShadow;
                    this.isEaten = false;
                }
            }
            else if (pacman2.CanEatGhosts || pacman1.CanEatGhosts)
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

                if (DistanceToPacman(pacman1) < DistanceToPacman(pacman2))
                {
                    Ambush(pacman1);
                }
                else
                {
                    Ambush(pacman2);
                }

                PrintEngine.PrintSymbol(this.Row, this.Column, this.Symbol);

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
                    this.Symbol = Maze.symbolGhostRedShadow;
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
                if (DistanceToPacman(pacman) < 10)
                {

                    this.FigureWhatToPrintOnExsitingPosition();

                    Coordinates nextStep = this.FindNextStep(pacman.Row, pacman.Column);

                    this.row = nextStep.Row;
                    this.column = nextStep.Coll;

                    this.ChangeDirection(nextStep);
                    PrintEngine.PrintSymbol(this.Row, this.Column, this.Symbol);
                }
                else
                {
                    Ambush(pacman);
                }
            }
        }

        private void Ambush(Pacman pacman)
        {
            FigureWhatToPrintOnExsitingPosition();
            Coordinates nextStep = FindPositionToAmbush(pacman);
            nextStep = FindNextStep(nextStep.Row, nextStep.Coll);
            this.row = nextStep.Row;
            this.column = nextStep.Coll;
            PrintEngine.PrintSymbol(this.Row, this.Column, this.Symbol);
        }

        private Coordinates FindPositionToAmbush(Pacman pacman)
        {
            double direction = 0;

            switch (pacman.Direction)
            {
                case Pacman.Way.Down: direction = Math.PI / 2; break;
                case Pacman.Way.Right: direction = 0; break;
                case Pacman.Way.Up: direction = (3 * Math.PI) / 2; break;
                case Pacman.Way.Left: direction = Math.PI; break;
            }

            for(double i = 0; i < Math.PI; i += 0.1)
            {
                int x = (int)Math.Ceiling(10 * Math.Cos(direction + i)) + pacman.Column;
                int y = (int)Math.Ceiling(10 * Math.Sin(direction + i)) + pacman.Row;

                if (!Maze.IsWall(y, x))
                {
                    return new Coordinates(y, x);
                }

                x = (int)Math.Ceiling(10 * Math.Cos(direction - i)) + pacman.Column;
                y = (int)Math.Ceiling(10 * Math.Sin(direction - i)) + pacman.Row;

                if (!Maze.IsWall(y, x))
                {
                    return new Coordinates(y, x);
                }
            }

            return new Coordinates(pacman.Row, pacman.Column);
        }
    }
}

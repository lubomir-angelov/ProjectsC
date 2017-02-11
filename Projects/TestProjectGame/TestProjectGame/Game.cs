using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectGame
{
    class Game
    {

        const char Dwarf_Color = '0';

        const ConsoleColor BACKGROUND_COLOR = ConsoleColor.Black;



        public static Coordinate Dwarf { get; set; } //Will represent our dwarf that's moving around :P/>



        static void Main(string[] args)
        {
            
            InitGame();



            ConsoleKeyInfo keyInfo;

            while ((keyInfo = Console.ReadKey(true)).Key != ConsoleKey.Escape)
            {

                switch (keyInfo.Key)
                {

                    case ConsoleKey.RightArrow:

                        MoveDwarf(1, 0);

                        break;
                   

                    case ConsoleKey.LeftArrow:

                        MoveDwarf(-1, 0);

                        break;

                }

            }

        }



        /// <summary>

        /// Paint the new hero

        /// </summary>

        static void MoveDwarf(int x, int y)
        {

            Coordinate newDwarf = new Coordinate()

            {

                X = Dwarf.X + x,

                Y = Dwarf.Y + y

            };



            if (CanMove(newDwarf))
            {

                RemoveHero();



                Dwarf_Color = '';

                Console.SetCursorPosition(newDwarf.X, newDwarf.Y);

                Console.Write(" ");



                Dwarf = newDwarf;

            }

        }



        /// <summary>

        /// Overpaint the old hero

        /// </summary>

        static void RemoveHero()
        {

            Console.BackgroundColor = BACKGROUND_COLOR;

            Console.SetCursorPosition(Dwarf.X, Dwarf.Y);

            Console.Write(" ");

        }



        /// <summary>

        /// Make sure that the new coordinate is not placed outside the

        /// console window (since that will cause a runtime crash

        /// </summary>

        static bool CanMove(Coordinate c)
        {

            if (c.X < 0 || c.X >= Console.WindowWidth)

                return false;


  //          if (c.Y < 0 || c.Y >= Console.WindowHeight)

  //              return false;



            return true;

        }



        /// <summary>

        /// Paint a background color

        /// </summary>

        /// <remarks>

        /// It is very important that you run the Clear() method after

        /// changing the background color since this causes a repaint of the background

        /// </remarks>

        static void SetBackgroundColor()
        {

            Console.BackgroundColor = BACKGROUND_COLOR;

            Console.Clear(); //Important!

        }


        /// <summary>

        /// Initiates the game by painting the background

        /// and initiating the hero

        /// </summary>

        static void InitGame()
        {

            SetBackgroundColor();



            Dwarf = new Coordinate()

            {

                X = 40,

                Y = 25

            };


            MoveDwarf(40, 25);



        }

    }



    /// <summary>

    /// Represents a map coordinate

    /// </summary>

    class Coordinate
    {

        public int X { get; set; } //Left

        public int Y { get; set; } //Top

    }

}
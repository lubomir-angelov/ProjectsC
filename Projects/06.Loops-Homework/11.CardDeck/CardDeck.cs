using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that prints all possible cards from a standard deck of 52 cards (without jokers). 
//The cards should be printed with their English names. Use nested for loops and switch-case.

namespace _11.CardDeck
{
    class CardDeck
    {
        static void Main(string[] args)
        {
            string[] clubs = 
            {
             "A of clubs", "2 of clubs", "3 of clubs", "4 of clubs", "5 of clubs", 
             "6 of clubs", "7 of clubs", "8 of clubs", "9 of clubs", "10 of clubs",
             "J of clubs", "Q of clubs", "K of clubs"
            };
            string[] diamonds = 
            {
             "A of diamonds", "2 of diamonds", "3 of diamonds", "4 of diamonds", "5 of diamonds", 
             "6 of diamonds", "7 of diamonds", "8 of diamonds", "9 of diamonds", "10 of diamonds",
             "J of diamonds", "Q of diamonds", "K of diamonds"
            };
            string[] hearts = 
            {
             "A of hearts", "2 of hearts", "3 of hearts", "4 of hearts", "5 of hearts", 
             "6 of hearts", "7 of hearts", "8 of hearts", "9 of hearts", "10 of hearts",
             "J of hearts", "Q of hearts", "K of hearts"
            };
            string[] spades = 
            {
             "A of spades", "2 of spades", "3 of spades", "4 of spades", "5 of spades", 
             "6 of spades", "7 of spades", "8 of spades", "9 of spades", "10 of spades",
             "J of spades", "Q of spades", "K of spades"
            };

            for (int i = 0; i < spades.Length; i++)
            {
                Console.Write("{0}, {1}, {2}, {3}\n", clubs[i], diamonds[i], hearts[i], spades[i]);
            }
        }
    }
}

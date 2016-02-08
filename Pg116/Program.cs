using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Pg116
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to die roller! Type 'quit' at any time to exit.");
                TotalOfRolls();
        }
        static void TotalOfRolls()
        {
            Console.WriteLine("Please enter the number of dice you would like to roll.");
            Random rollTheDice = new Random();
            var input = Console.ReadLine();
            int numberOfDice;
            int total = 0;

            if (input == "quit")
            {
                return;
            }
            
            if (!Int32.TryParse(input, out numberOfDice))
            {
                Console.WriteLine("Your entry was not a number, try again.");
                TotalOfRolls();
            }
            else
            {
                for (int i = 0; i <= numberOfDice; i++)
                {
                    int dieRoll = rollTheDice.Next(6) + 1;
                    total = dieRoll + total;
                }
                Console.WriteLine("The total points from the dice rolled are " + total);
                TotalOfRolls();
            }
        }
    }

    }

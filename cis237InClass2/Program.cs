using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237InClass2
{
    class Program
    {
        static void Main(string[] args)
        {
                // User prompt and saving of choice:
            Console.Write("Enter 1 for Factorial or 2 for Tower of Hanoi: ");
            string userInput = Console.ReadLine();

            if(userInput == "1")
            {
                // Do Factorial:
                Factorial factorial = new Factorial();
            }
            else
            {
                // Do Tower of Hanoi:
                TowersOfHanoi towersOfHanoi = new TowersOfHanoi();
                Console.WriteLine();
                Console.WriteLine("That number of discs required {0} moves.", towersOfHanoi.NumberOfMoves);
            }
        }
    }
}

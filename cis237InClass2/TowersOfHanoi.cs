using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237InClass2
{
    class TowersOfHanoi
    {
        private int _numberOfMoves = 0;

        public int NumberOfMoves
        {
            get { return _numberOfMoves; }
        }

        public TowersOfHanoi()
        {   
                // Get input from user for number of disks to use:
            Console.Write("Enter a number of disks to use: ");
            int numberOfDisks = Int32.Parse(Console.ReadLine());
            Console.WriteLine();

                // Make the first call to the recursive method:
            moveDisk(numberOfDisks, 'A', 'B', 'C');
        }

        private void moveDisk(int n, char src, char aux, char des)
        {
                // If one peg is being moved, this is the base case:
            if (n == 1)
            {
                    // One move made - print to screen:
                Console.WriteLine("Move disk from {0} to {1}", src, des);
                _numberOfMoves++;
            }
                // Otherwise, start the recursive call set:
            else
            {
                    // Recursive call to move n-1 disks from the source peg to the auxiliary peg:
                moveDisk(n - 1, src, des, aux);
                    // Recursive call to move 1 disk from source peg to destination peg:
                moveDisk(1, src, aux, des);
                    // Recursive call to move n-1 disks from the auxiliary peg to the destination peg:
                moveDisk(n - 1, aux, src, des);
            }
        }
    }
}

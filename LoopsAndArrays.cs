//Matthew Bowling
//Loops and Arrays

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery
{
    class Program
    {
        const int NumberOfEntries = 5;

        static void Main(string[] args)
        {
            int [] WinningDigits = new int[NumberOfEntries];
            int[] GuessedDigits = new int[NumberOfEntries];
            int NumberCorrect = 0;

            Console.WriteLine("Please enter your five digit guess numbers");
            for(int i = 0; i < NumberOfEntries;i++)
            {
                GuessedDigits[i] = Convert.ToInt32(Console.ReadLine());

                while (GuessedDigits[i] > 9 || GuessedDigits[i] < 0)
                {
                    Console.WriteLine("Please enter a valid number guess");
                    GuessedDigits[i] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Will now randomly select five numbers");
            Random rnd = new Random();

            for(int i = 0; i < NumberOfEntries;i++)
            {
                WinningDigits[i] = rnd.Next(0, 9);
            }

            Console.WriteLine("The winning digits are");

            for(int i = 0; i < NumberOfEntries;i++)
            {
                Console.WriteLine(WinningDigits[i]);

                if(WinningDigits[i] == GuessedDigits[i])
                {
                    NumberCorrect++;
                }

            }

            Console.WriteLine("You had " + NumberCorrect + " digits guessed correctly!");
        }
    }
}

//Matthew Bowling
//Palindrone Testing

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindroneTestingCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string Palindrone;
            string ReversePalindrone;
            int checker = 0;

            Console.WriteLine("Enter a word/words to see if theyre palindrone!");
            Palindrone = Convert.ToString(Console.ReadLine());
            Palindrone = Palindrone.Replace(" ", "");
            Palindrone = Palindrone.ToLower();

            ReversePalindrone = Program.ReverseString(Palindrone);
            Console.WriteLine(Palindrone);
            Console.WriteLine(ReversePalindrone);

            for(int i = 0;i<Palindrone.Length;i++)
            {
                if (Palindrone[i] != ReversePalindrone[i])
                {
                    continue;
                }
                else if (Palindrone[i] == ReversePalindrone[i])
                {
                    checker++;
                }
            }

            if (checker == Palindrone.Length)
            {
                Console.WriteLine("This word is a palindrone!");
            }

            else
            {
                Console.WriteLine("This word is not a palindrone");
            }
        }

        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}

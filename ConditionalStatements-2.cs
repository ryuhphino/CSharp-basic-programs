//Matthew Bowling
//Conditional Statements

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeCalculatorCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double time;
            double days, hours, minutes;

            Console.WriteLine("Please enter an amount of seconds");
            time = Convert.ToDouble(Console.ReadLine());

            days = time / 86400;
            hours = time / 3600;
            minutes = time / 60;

            if ( time > 86400)
            {
                Console.WriteLine("The number of seconds you entered is " + days + " days");
            }
            else if (86400 > time && time > 3600)
            {
                Console.WriteLine("The number of seconds you entered is " + hours + " hours");
            }
            else if (3600 > time && time >60)
            {
                Console.WriteLine("The number of seconds you entered is " + minutes + " minutes");
            }
            else
            {
                Console.WriteLine("The number of seconds you entered is " + time + " seconds");
            }
        }
    }
}

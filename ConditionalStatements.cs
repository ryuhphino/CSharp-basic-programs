//Matthew Bowling
//Conditional Statements

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            int Test1, Test2, Test3, Test4, Test5;
            int Total;
            int Average;

            Console.WriteLine("Please enter five test scores");
            Test1 = Convert.ToInt32(Console.ReadLine());
            while (Test1 > 100 || Test1 < 0)
            {
                Console.WriteLine("Please enter a valid Test Score");
                Test1 = Convert.ToInt32(Console.ReadLine());
            }
            Test2 = Convert.ToInt32(Console.ReadLine());
            while (Test2 > 100 || Test2 < 0)
            {
                Console.WriteLine("Please enter a valid Test Score");
                Test2 = Convert.ToInt32(Console.ReadLine());
            }
            Test3 = Convert.ToInt32(Console.ReadLine());
            while  (Test3 > 100 || Test3 < 0)
            {
                Console.WriteLine("Please enter a valid Test Score");
                Test3 = Convert.ToInt32(Console.ReadLine());
            }
            Test4 = Convert.ToInt32(Console.ReadLine());
            while  (Test4 > 100 || Test4 < 0)
            {
                Console.WriteLine("Please enter a valid Test Score");
                Test4 = Convert.ToInt32(Console.ReadLine());
            }
            Test5 = Convert.ToInt32(Console.ReadLine());
            while (Test5 > 100 || Test5 < 0)
            {
                Console.WriteLine("Please enter a valid Test Score");
                Test5 = Convert.ToInt32(Console.ReadLine());
            }

            Total = Test1 + Test2 + Test3 + Test4 + Test5;
            Average = Total / 5;

            Console.WriteLine("The Average Test Score is " + Average);
            Console.ReadKey();
        }
    }
}

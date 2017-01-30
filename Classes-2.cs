//Matthew Bowling
//Classes-2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 0;
            string m = "";
            int s = 0;

            Console.WriteLine("Please enter a Year, Make, and speed of the vehicle");
            y = Convert.ToInt32(Console.ReadLine());

            while (y > 2018 || y < 1950)
            {
                Console.WriteLine("Please enter a valid year");
                y = Convert.ToInt32(Console.ReadLine());
            }

            m = Convert.ToString(Console.ReadLine());
            s = Convert.ToInt32(Console.ReadLine());

            Car vehicle1 = new Car(y, m, s);
            vehicle1.Accelerate();
            vehicle1.Accelerate();
            vehicle1.Accelerate();
            vehicle1.Accelerate();
            vehicle1.Accelerate();
            vehicle1.getValues();
            vehicle1.Brake();
            vehicle1.Brake();
            vehicle1.Brake();
            vehicle1.Brake();
            vehicle1.Brake();

        }
    }

    class Car
    {
        private static int Year;
        private static string Make;
        private static int Speed;

        public Car(int y, string m, int s)
        {
            Year = y;
            Make = m;
            Speed = s;
         }

        public void getValues()
        {
            Console.WriteLine("The year, make, and speed of the vehicle is");
            Console.WriteLine(Year + " " + Make + " " + Speed + "MPH");
        }

        public void Accelerate()
        {
            Speed += 5;
            Console.WriteLine("You are now going " + Speed + " MPH");
        }

        public void Brake()
        {
            Speed -= 5;
            Console.WriteLine("You are now going " + Speed + " MPH");
        }
    }

}

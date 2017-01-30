//Matthew Bowling
//Methods

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkUp
{
    class Program
    {
        static void Main(string[] args)
        {
            double cost, markup;

            Console.WriteLine("Please enter a cost for an item cost and its markup");
            cost = Convert.ToDouble(Console.ReadLine());
            markup = Convert.ToDouble(Console.ReadLine());
            if (markup > 1)
            {
                markup = markup * .01;
            }

            Console.WriteLine("The retail price of the item is " + calculateRetail(cost, markup));

        }

        static double calculateRetail(double cst, double mrkup)
        {
            double total = cst + (cst * mrkup);

            return total;
        }
    }
}

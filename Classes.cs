//Matthew Bowling
//Classes


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulationClass
{
    class Program
    {
        static void Main(string[] args)
        {
            int pop = 0;
            int death = 0;
            int birth = 0;

            Console.WriteLine("Please enter a population ammount for the country, as well as how many people have died and have been born");
            pop = Convert.ToInt32(Console.ReadLine());

            while (pop < 2)
            {
                pop = 2;
            }
            death = Convert.ToInt32(Console.ReadLine());
            birth = Convert.ToInt32(Console.ReadLine());

            Population pop1 = new Population(pop, death, birth);
            pop1.getBirthRate();
            pop1.getDeathRate();
        }
    }

    class Population
    {
        private static int population;
        private static int births;
        private static int deaths;

        public Population(int pop, int birth, int death)
        {
            population = pop;
            births = birth;
            deaths = death;
        }

        public void getBirthRate()
        {
            Console.WriteLine("The birth rate is " + (births + population));
        }

        public void getDeathRate()
        {
            Console.WriteLine("The death rate is " + (deaths + population));
        }
    }
}

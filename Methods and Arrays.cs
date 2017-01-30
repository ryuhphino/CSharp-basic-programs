//Matthew Bowling
//Methods and Arrays

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowestScoreDropCSharp
{
    class Program
    {
        const int ScoreNumbers = 5;

        static void Main(string[] args)
        {
            int[] scores = new int[ScoreNumbers];
            Console.WriteLine("Please Enter five test scores");

            getScore(scores);

            calcAverage(scores);

        }

        static void getScore(int[] score)
        {
            for (int i = 0; i < ScoreNumbers; i++)
            {
                score[i] = Convert.ToInt32(Console.ReadLine());

                while (score[i] > 100 || score[i] < 0)
                {
                    Console.WriteLine("Please enter a score between 100 and 0");
                    score[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        static void calcAverage(int[] score)
        {
            int findlowest;
            int total = 0;
            int Average = 0;

            findlowest = findLowest(score);
            int j = 0;

            for(int i = 0;i<ScoreNumbers;i++)
            {
                if(score[i] == findlowest && j == 0)
                {
                    continue;
                    j++;
                }
                else if (score[i] != findlowest || j == 1)
                {
                    total = (total + score[i]);
                }
            }

            Average = total / (ScoreNumbers - 1);
            Console.WriteLine("The average Testscore is " + Average);
        }

        static int findLowest(int[] score)
        {
            int lowest = 100; //highest possible score

            for(int i = 0;i<ScoreNumbers;i++)
            {
                if(score[i] < lowest )
                {
                    lowest = score[i];
                }
            }
            return lowest;
        }
    }
}

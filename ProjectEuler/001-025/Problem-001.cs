using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem_001
    {
        static void Main(string[] args)
        {
            SumOfNaturalNumber(1000, 3, 5);

            Console.WriteLine("Press any key to exit..");
            Console.Read();
        }

        public static void SumOfNaturalNumber(int range, int value1, int value2)
        {
            // Problem 1: Multiples of 3 and 5
            // If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23
            // Find the sum of all the multiples of 3 or 5 below 1000.

            int sum = 0;
            for (int i = 1; i < range; i++)
            {
                if ((i % value1 == 0) || (i % value2) == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum.ToString());
        }
    }
}

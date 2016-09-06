using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem_012
    {
        static void Main(string[] args)
        {
            HighlyDivisibleTriangularNumber(500);
            Console.WriteLine("Press any key to exit..");
            Console.Read();
        }

        public static void HighlyDivisibleTriangularNumber(int maxDivisor)
        {
            // Problem 12: Highly divisible triangular number

            int trinagleNumber = 0;
            int number = 1;
            while (true)
            {
                int divisor = 0;
                trinagleNumber += number;
                for (int i = 1; i <= trinagleNumber; i++)
                {
                    if (trinagleNumber % i == 0)
                    {
                        if (divisor > maxDivisor)
                        {
                            Console.WriteLine("The number {0} has maximum divisor {1}", trinagleNumber, divisor);
                            return;
                        }
                        divisor++;
                    }
                }
                number++;
            }
        }

    }
}

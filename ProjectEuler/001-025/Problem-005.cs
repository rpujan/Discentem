using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem_005
    {
        static void Main(string[] args)
        {
            SmallestMultiple(1, 20);

            Console.WriteLine("Press any key to exit..");
            Console.Read();
        }

        public static void SmallestMultiple(int from, int to)
        {
            // Problem 5: Smallest multiple
            // 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
            // What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?

            int number = 1;
            while (true)
            {
                int loopCount = 0;
                for (int i = from; i <= to; i++)
                {
                    if (number % i == 0)
                    {
                        loopCount++;
                    }
                }
                if ((to - loopCount) == 0)
                {
                    Console.WriteLine(number.ToString());
                    return;
                }
                number++;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem_003
    {
        static void Main(string[] args)
        {
            LastgestPrimeFactor(600851475143);

            Console.WriteLine("Press any key to exit..");
            Console.Read();
        }

        public static void LastgestPrimeFactor(long number)
        {
            // Problem 3: Largest prime factor
            // The prime factors of 13195 are 5, 7, 13 and 29.
            // What is the largest prime factor of the number 600851475143 ?

            int count = 1;
            while (count < (number / 2))
            {
                if (number % count == 0)
                {
                    int innerCount = 1;
                    int loopCount = 0;
                    while (innerCount < (count))
                    {
                        if (count % innerCount != 0 && innerCount != 1)
                        {
                            loopCount++;
                        }
                        if (count - 2 == loopCount)
                        {
                            int largestFactor = count;
                            Console.WriteLine(largestFactor.ToString());
                            break;
                        }
                        innerCount++;
                    }
                }
                count++;
            }
        }

    }
}

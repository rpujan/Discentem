using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem_007
    {
        static void Main(string[] args)
        {
            //SpecificPrimeNumber(101);
            Console.WriteLine("Press any key to exit..");
            Console.Read();
        }

        public static void SpecificPrimeNumber(int position)
        {
            // Problem 7: 10001st prime
            // By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
            // What is the 10001st prime number?

            int positionCount = 0;
            int number = 1;

            while (true)
            {
                int count = 0;
                for (int i = 1; i < number; i++)
                {
                    if (number % i != 0 && i != 1)
                    {
                        count++;
                    }
                }
                if (number - 2 == count)
                {
                    positionCount++;
                }
                if (positionCount == position)
                {
                    Console.WriteLine(number.ToString());
                    return;
                }
                number++;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem_002
    {
        static void Main(string[] args)
        {
            EvenFibonacciNumbers();

            Console.WriteLine("Press any key to exit..");
            Console.Read();
        }

        public static void EvenFibonacciNumbers()
        {
            // Problem 2: Even Fibonacci numbers
            // By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms

            int sumOfEven = 0;
            const int maxValue = 4000000;
            int firstValue = 0;
            int nextValue = firstValue + 1;
            int sum = 0;
            while (sum < maxValue)
            {
                sum = firstValue + nextValue;
                if (sum < maxValue)
                {
                    firstValue = nextValue;
                    nextValue = sum;
                    //Console.WriteLine(sum.ToString());
                    if (sum % 2 == 0)
                    {
                        sumOfEven += sum;
                    }
                }
            }
            Console.WriteLine(sumOfEven.ToString());
        }
    }
}

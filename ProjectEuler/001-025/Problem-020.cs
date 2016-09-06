using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem_020
    {
        static void Main(string[] args)
        {
            FactorialDigitSum(100);
            Console.WriteLine("Press any key to exit..");
            Console.Read();
        }

        public static void FactorialDigitSum(int factorial)
        {
            // Problem 20: Factorial digit sum

            var result = new int[1000];
            result[0] = 1;
            var output = 0;
            var resultSize = 1;

            for (int i = 2; i <= factorial; i++)
            {
                resultSize = Multiply(i, result, resultSize);
            }
            for (int z = resultSize - 1; z >= 0; z--)
            {
                output += result[z];
            }
            Console.WriteLine("Sum of factorial {0} is {1}", factorial, output);
        }

        private static int Multiply(int num, int[] array, int resultSize)
        {
            int carry = 0;
            for (int i = 0; i < resultSize; i++)
            {
                int product = array[i] * num + carry;
                array[i] = product % 10;
                carry = product / 10;
            }

            // Put carry in res and increase result size
            while (carry > 0)
            {
                array[resultSize] = carry % 10;
                carry = carry / 10;
                resultSize++;
            }
            return resultSize;
        }

    }
}

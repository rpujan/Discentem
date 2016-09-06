using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem_021
    {
        static void Main(string[] args)
        {
            AmicableNumbers(10000);
            Console.WriteLine("Press any key to exit..");
            Console.Read();
        }

        public static void AmicableNumbers(int target)
        {
            // Problem 21: Amicable numbers
            // For example, the proper divisors of 220 are 1, 2, 4, 5, 10, 11, 20, 22, 44, 55 and 110; therefore d(220) = 284. The proper divisors of 284 are 1, 2, 4, 71 and 142; so d(284) = 220.
            // Evaluate the sum of all the amicable numbers under 10000.

            var number = 1;
            int total = 0;
            while (number < target)
            {
                int sum = 0;
                int temp = 0;
                for (int i = 1; i <= number / 2; i++)
                {
                    if (number % i == 0)
                    {
                        temp += i;
                    }
                }
                for (int j = 1; j <= temp / 2; j++)
                {
                    if (temp % j == 0)
                    {
                        sum += j;
                    }
                }
                if ((number == sum) && (number != temp))
                {
                    total += number;
                }
                number++;
            }
            Console.WriteLine(total.ToString());
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem_006
    {
        static void Main(string[] args)
        {
            SumSquareDifference(1, 100);
            Console.WriteLine("Press any key to exit..");
            Console.Read();
        }

        public static void SumSquareDifference(int from, int to)
        {
            // Problem 6: Sum square difference

            int sum = 0;
            int squareSum = 0;
            int sumSquare = 0;
            int diff = 0;

            for (int i = from; i <= to; i++)
            {
                squareSum += i * i;
                sum += i;
            }

            sumSquare = sum * sum;
            diff = sumSquare - squareSum;
            Console.WriteLine(diff.ToString());
        }

    }
}

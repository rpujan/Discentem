using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem_014
    {
        static void Main(string[] args)
        {
            //LongestCollatzSequence(1000000);
            Console.WriteLine("Press any key to exit..");
            Console.Read();
        }

        public static void LongestCollatzSequence(int number)
        {
            // Problem 14: Longest collatz sequence

            int count = 1;
            int maxSequence = 0;
            int num = 0;

            while (count < number)
            {
                int sequence = 1;
                int input = count;
                while (input > 1)
                {
                    if (input % 2 == 0)
                    {
                        input = input / 2;
                    }
                    else
                    {
                        input = (input * 3) + 1;
                    }
                    sequence++;
                }
                if (sequence > maxSequence)
                {
                    maxSequence = sequence;
                    num = count;
                }
                count++;
            }
            Console.WriteLine("Number: {0} has longest chain {1}", num, maxSequence);
        }

    }
}

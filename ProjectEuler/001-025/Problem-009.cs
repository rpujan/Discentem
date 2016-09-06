using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem_009
    {
        static void Main(string[] args)
        {
            SpecialPythagoreanTriplet(1000);
            Console.WriteLine("Press any key to exit..");
            Console.Read();
        }

        public static void SpecialPythagoreanTriplet(int number)
        {
            // Problem 9: Special Pythagorean triplet

            for (int i = 1; i <= number; i++)
            {
                for (int j = i + 1; j <= number; j++)
                {
                    for (int k = j + 1; k <= number; k++)
                    {
                        if ((i + j + k == number) && ((i * i) + (j * j) == (k * k)))
                        {
                            Console.WriteLine("Product of i:{0} j:{1} k:{2} : {3}", i, j, k, i * j * k);
                        }
                    }
                }
            }
        }

    }
}

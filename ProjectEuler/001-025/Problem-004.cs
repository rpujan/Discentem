using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem_004
    {
        static void Main(string[] args)
        {
            LargestPalindromeProduct(999);

            Console.WriteLine("Press any key to exit..");
            Console.Read();
        }

        public static void LargestPalindromeProduct(int maxValue)
        {
            // Problem 4: Largest palindrome product
            // A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
            // Find the largest palindrome made from the product of two 3-digit numbers.

            int value = 0;
            int largestPalindrome = 0;
            for (int i = 0; i <= maxValue; i++)
            {
                for (int j = 0; j <= maxValue; j++)
                {
                    int number = i * j;
                    int reverse = 0;

                    while (number > 0)
                    {
                        int reminder = number % 10;
                        reverse = (reverse * 10) + reminder;
                        number = number / 10;
                    }

                    if (i * j == reverse)
                    {
                        value = i * j;
                        if (value > largestPalindrome)
                        {
                            largestPalindrome = value;
                        }
                    }
                }
            }
            Console.WriteLine(largestPalindrome.ToString());
        }

    }
}

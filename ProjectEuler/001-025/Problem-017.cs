using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem_017
    {
        enum numberLetterEnum
        {
            one = 1,
            two = 2,
            three = 3,
            four = 4,
            five = 5,
            six = 6,
            seven = 7,
            eight = 8,
            nine = 9,
            ten = 10,
            eleven = 11,
            twelve = 12,
            thirteen = 13,
            fourteen = 14,
            fifteen = 15,
            sixteen = 16,
            seventeen = 17,
            eighteen = 18,
            nineteen = 19,
            twenty = 20,
            thirty = 30,
            forty = 40,
            fifty = 50,
            sixty = 60,
            seventy = 70,
            eighty = 80,
            ninety = 90,
            hundred = 100,
            thousand = 1000
        };

        static void Main(string[] args)
        {
            NumberLetterCounts(1000);
            Console.WriteLine("Press any key to exit..");
            Console.Read();
        }

        public static void NumberLetterCounts(int maxLimit)
        {
            // Problem 17: Number letter counts
            // If the numbers 1 to 5 are written out in words: one, two, three, four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.
            // If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used?

            int ones = 0;
            int tens = 0;
            int hundred = 0;
            int wordCount = 0;
            int blankSpace = 1;
            string numberInWords = "";

            for (int i = 1; i <= maxLimit; i++)
            {
                if (i <= 20)
                {
                    numberInWords = ((numberLetterEnum)i).ToString();
                    wordCount += numberInWords.Length;
                    Console.WriteLine(numberInWords);
                    continue;
                }

                if (i == 1000)
                {
                    Console.WriteLine("one thousand");
                    wordCount += (("one thousand").Replace(" ", string.Empty)).Length;
                    continue;
                }

                hundred = i / 100;
                tens = Math.Abs((hundred * 100 - i)) / 10;
                ones = Math.Abs((hundred * 100 - i) % 10);

                if (hundred > 0 && tens == 1 && ones > 0)
                {
                    tens = tens * 10 + ones;
                    ones = 0;
                }

                if (hundred == 0 && tens > 0 && ones > 0)
                {
                    numberInWords = ((numberLetterEnum)(tens * 10)).ToString() + " " + ((numberLetterEnum)(ones)).ToString();
                    wordCount += numberInWords.Length - (blankSpace * 1);
                    Console.WriteLine(numberInWords);
                }
                else if (hundred == 0 && tens > 0 && ones == 0)
                {
                    numberInWords = ((numberLetterEnum)(tens * 10)).ToString();
                    wordCount += numberInWords.Length;
                    Console.WriteLine(numberInWords);
                }
                else if (hundred > 0 && tens > 0 && ones > 0)
                {
                    numberInWords = ((numberLetterEnum)(hundred)).ToString() + " hundred and " +
                                    ((numberLetterEnum)(tens * 10)).ToString() + " " + ((numberLetterEnum)(ones)).ToString();
                    wordCount += numberInWords.Length - (blankSpace * 4);
                    Console.WriteLine(numberInWords);
                }
                else if (hundred > 0 && tens > 0 && ones == 0)
                {
                    if (tens > 10)
                    {
                        numberInWords = ((numberLetterEnum)(hundred)).ToString() + " hundred and " +
                                        ((numberLetterEnum)(tens)).ToString();
                        wordCount += numberInWords.Length - (blankSpace * 3);
                    }
                    else
                    {
                        numberInWords = ((numberLetterEnum)(hundred)).ToString() + " hundred and " +
                                        ((numberLetterEnum)(tens * 10)).ToString();
                        wordCount += numberInWords.Length - (blankSpace * 3);
                    }
                    Console.WriteLine(numberInWords);
                }
                else if (hundred > 0 && tens == 0 && ones > 0)
                {
                    numberInWords = ((numberLetterEnum)(hundred)).ToString() + " hundred and " + ((numberLetterEnum)(ones)).ToString();
                    wordCount += numberInWords.Length - (blankSpace * 3);
                    Console.WriteLine(numberInWords);
                }
                else if (hundred > 0 && tens == 0 && ones == 0)
                {
                    numberInWords = ((numberLetterEnum)(hundred)).ToString() + " hundred";
                    wordCount += numberInWords.Length - (blankSpace * 1);
                    Console.WriteLine(numberInWords);
                }
            }
            Console.WriteLine("Total length of words {0}", wordCount);
        }

    }
}

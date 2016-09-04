using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discentem
{
    class Alphabet
    {
        static void Main(string[] args)
        {
            // input latin charcter
            Console.WriteLine("Enter latin characters: ");
            var latinChar = Console.ReadLine();

            // input no. of word in books
            Console.WriteLine("Enter no. of words in books: ");
            var wordCount = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Please enter " + wordCount.ToString() + " word(s) separated by line: ");

            string[] answer = new string[wordCount];
            for(var i=0; i< wordCount; i++)
            {
                answer[i] = Console.ReadLine();
            }

            Console.WriteLine("Your input is:");
            for (var i = 0; i < wordCount; i++)
            {
                Console.WriteLine(answer[i]);
            }
            Console.WriteLine("Press any key to exit:");
            Console.ReadKey();
        }
    }
}

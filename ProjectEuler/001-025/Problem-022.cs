using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem_022
    {
        static void Main(string[] args)
        {
            NamesScores();
            Console.WriteLine("Press any key to exit..");
            Console.Read();
        }

        public static void NamesScores()
        {
            /* 
             // Problem 22
             Using names.txt (right click and 'Save Link/Target As...'), a 46K text file containing over five-thousand first names, 
             begin by sorting it into alphabetical order. Then working out the alphabetical value for each name, multiply this value by 
             its alphabetical position in the list to obtain a name score. 
             
             For example, when the list is sorted into alphabetical order, COLIN, which is worth 3 + 15 + 12 + 9 + 14 = 53, is the 
             938th name in the list. So, COLIN would obtain a score of 938 × 53 = 49714.
             
             What is the total of all the name scores in the file?
             
             */

            var reader = new StreamReader(File.OpenRead(@"names.txt"));
            int total = 0;
            List<string> list = new List<string>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');

                for (int i = 0; i < values.Length; i++)
                {
                    list.Add(values[i]);
                }
                list.Sort();
            }

            for (int j = 1; j <= list.Count; j++)
            {
                var name = list[j - 1];
                int sum = 0;
                for (int z = 0; z < name.Length; z++)
                {
                    int index = char.ToUpper(name[z]) - 64;
                    sum += index;
                }
                total += sum * j;
            }
            Console.WriteLine("Total length of words {0}", total);
        }

    }
}

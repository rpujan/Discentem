using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem_008
    {
        static void Main(string[] args)
        {
            var series =
                "731671765313306249192251196744265747423553491949349698352031277450632623957831801698480186947885184385861560789112949495459501737958331952853208805511";
            series +=
                "125406987471585238630507156932909632952274430435576689664895044524452316173185640309871112172238311362229893423380308135336276614282806444486645238749";
            series +=
                "303589072962904915604407723907138105158593079608667017242712188399879790879227492190169972088809377665727333001053367881220235421809751254540594752243";
            series +=
                "525849077116705560136048395864467063244157221553975369781797784617406495514929086256932197846862248283972241375657056057490261407972968652414535100474";
            series +=
                "821663704844031998900088952434506585412275886668811642717147992444292823086346567481391912316282458617866458359124566529476545682848912883142607690042";
            series +=
                "242190226710556263211111093705442175069416589604080719840385096245544436298123098787992724428490918884580156166097919133875499200524063689912560717606";
            series +=
                "0588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";

            LargestProductInSeries(series, 13);
            Console.WriteLine("Press any key to exit..");
            Console.Read();
        }

        public static void LargestProductInSeries(string series, int length)
        {
            // Problem 8: Largest product in a series

            var maxProductValue = 0;
            var seriesLength = series.Length;
            while (seriesLength >= length)
            {
                var value = series.Substring(0, length);
                var product = 1;

                if (value.Contains("0"))
                {
                    seriesLength--;
                    series = series.Substring(1);
                    continue;
                }
                Console.WriteLine(value);
                for (int i = 0; i < value.Length; i++)
                {
                    product *= Convert.ToInt16(value[i].ToString());
                }
                if (product > maxProductValue)
                {
                    maxProductValue = product;
                    Console.WriteLine("Product {0} of values {1}", maxProductValue, value);
                }
                seriesLength--;
                series = series.Substring(1);
            }
            Console.WriteLine(maxProductValue);
        }

    }
}

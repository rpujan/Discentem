using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem_016
    {
        static void Main(string[] args)
        {
            PowerDigitSum(2, 1000);
            Console.WriteLine("Press any key to exit..");
            Console.Read();
        }

        public static void PowerDigitSum(int baseValue, int exponent)
        {
            // Problem 16: Power digit sum

            string output = "";
            int sum = 0;

            var result = ArithmeticOperationAsString(baseValue.ToString(), baseValue.ToString(), '*');
            for (int i = 2; i < exponent; i++)
            {
                output = ArithmeticOperationAsString(result, baseValue.ToString(), '*');
                result = output;
            }

            for (int j = 0; j < output.Length; j++)
            {
                sum += (int)Char.GetNumericValue(output[j]);
            }

            Console.WriteLine("2**{0} = {1} and the sum of its digits is: {2}", exponent, output, sum);
        }

        public static string ArithmeticOperationAsString(string firstValue, string secondValue, char operation)
        {
            ArrayList total = new ArrayList();
            ArrayList firstAddend = new ArrayList();
            ArrayList secondAddend = new ArrayList();
            ArrayList tempTotal = new ArrayList();

            int carryForward = 0;
            string output = "";

            switch (operation)
            {
                case '*':
                    for (int i = firstValue.Length - 1; i >= 0; i--)
                    {
                        int temp = ((int)Char.GetNumericValue(firstValue[i]) * Convert.ToInt16(secondValue)) +
                                    carryForward;
                        int reminder = temp % 10;
                        carryForward = temp / 10;

                        total.Add(reminder.ToString());

                        if (i == 0 && carryForward > 0)
                        {
                            total.Add(carryForward.ToString());
                        }
                    }
                    total.Reverse();
                    for (int j = 0; j < total.Count; j++)
                    {
                        output += total[j];
                    }
                    break;

                case '+':

                    for (int a = 0; a < firstValue.Length; a++)
                    {
                        total.Add("0");
                    }

                    for (int i = 0; i < firstValue.Length; i++)
                    {
                        var temp = firstValue[i].ToString();
                        int cf = 0;

                        firstAddend = total;
                        secondAddend.Clear();

                        for (int b = 0; b < temp.Length; b++)
                        {
                            secondAddend.Add(Convert.ToInt16(temp[b].ToString()));
                        }

                        // make both number equal size in respect of length
                        var indexDifference = firstAddend.Count - secondAddend.Count;
                        if (indexDifference > 0)
                        {
                            for (int t = 0; t < indexDifference; t++)
                            {
                                secondAddend.Insert(t, 0);
                            }
                        }

                        for (int j = firstAddend.Count - 1; j >= 0; j--)
                        {
                            int sum = Convert.ToInt16(firstAddend[j].ToString()) + Convert.ToInt16(secondAddend[j].ToString()) + cf;
                            int reminder = sum % 10;
                            cf = sum / 10;

                            tempTotal.Add(reminder.ToString());

                            if (j == 0 && cf > 0)
                            {
                                tempTotal.Add(cf.ToString());
                            }
                        }

                        total = new ArrayList(tempTotal);
                        total.Reverse();
                        tempTotal.Clear();
                    }
                    for (int x = 0; x < total.Count; x++)
                    {
                        Console.Write(total[x].ToString());
                    }

                    break;
            }
            return output;
        }

    }
}

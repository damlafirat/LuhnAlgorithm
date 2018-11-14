using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuhnAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LuhnAlgoControl("4543600312287538"));
            Console.ReadLine();
        }

        private static bool LuhnAlgoControl(string cardNo)
        {
            if (String.IsNullOrEmpty(cardNo))
                return false;

            else
            {
                int sumOddDigits = 0, sumEventDigits = 0;

                for (int i = 0; i < cardNo.Length; i++)
                {
                    int num = (int)char.GetNumericValue(cardNo[i]);

                    if ((i+1) % 2 == 0)
                    {
                        sumEventDigits += num;
                    }

                    else
                    {
                        num = num * 2;

                        while (num > 0)
                        {
                            sumOddDigits += (num % 10);
                            num = num / 10;
                        }
                    }
                }

                int sum = sumOddDigits + sumEventDigits;

                if (sum % 10 == 0)
                    return true;

                else
                    return false;
            }
        }
    }
}
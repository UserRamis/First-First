using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._12._2021
{
    static class Maths
    {
        public static int GreatestCommonFactor(int num1, int num2)
        {
            if (num1 < num2)
            {
                int num = num1;
                num1 = num2;
                num2 = num;
            }
            if (num2 == 0)
            {
                return 1;
            }
            else
            {
                if (num1 % num2 == 0)
                {
                    return num2;
                }
                else
                {
                    return GreatestCommonFactor(num2, num1 % num2);
                }
            }
        }

        public static int GetDecimalDigitsCount(float num)
        {
            string str = num.ToString();
            if (str.Contains(","))
            {
                return str.Length - str.IndexOf(',') - 1;
            }
            else
            {
                return 0;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1_50
{
    internal class IntegerToRomanAlg
    {
        public string IntToRoman(int num)
        {
            int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] reps = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 13; i++)
            {
                while (num >= values[i])
                {
                    num -= values[i];
                    sb.Append(reps[i]);
                }
            }
            return sb.ToString();
        }
    }
}

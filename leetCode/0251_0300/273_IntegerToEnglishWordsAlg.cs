using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0251_0300
{
    public class _273_IntegerToEnglishWordsAlg
    {
        const int Billion = 1_000_000_000;
        const int Million = 1_000_000;
        static string[] num1 = ["","One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten",
                "Eleven", "Twelve", "Thirteen","Fourteen","Fifteen","Sixteen","Seventeen","Eighteen","Nineteen"];
        static string[] num2 = ["", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"];

        public string NumberToWords(int num)
        {
            if (num == 0)
                return "Zero";
            StringBuilder sb = new StringBuilder();
            if (num >= Billion)
            {
                string words = NumberToWords(num / Billion);
                sb.Append(" ");
                sb.Append(words).Append(" Billion");

                num %= Billion;
            }
            if (num >= Million)
            {
                string words = NumberToWords(num / Million);
                sb.Append(" ");
                sb.Append(words).Append(" Million");

                num %= Million;
            }
            if (num >= 1000)
            {
                string words = NumberToWords(num / 1000);
                sb.Append(" ");
                sb.Append(words).Append(" Thousand");

                num %= 1000;
            }
            if (num >= 100)
            {
                string words = NumberToWords(num / 100);
                sb.Append(" ");
                sb.Append(words).Append(" Hundred");

                num %= 100;
            }

            if (num < 20)
            {
                string word = num1[num];
                sb.Append(" ");
                sb.Append(word);
            }
            else
            {
                string word = num2[num / 10];
                sb.Append(" ");
                sb.Append(word);
                int d = num % 10;
                if (d > 0)
                {
                    sb.Append(" ");
                    sb.Append(num1[d]);
                }
            }

            return sb.ToString().Trim();
        }
    }
}

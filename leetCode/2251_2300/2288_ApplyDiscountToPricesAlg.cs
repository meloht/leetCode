using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2251_2300
{
    public class _2288_ApplyDiscountToPricesAlg
    {
        public string DiscountPrices(string sentence, int discount)
        {
            double d = discount;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < sentence.Length; i++)
            {
                sb.Append(sentence[i]);
                if (sentence[i] != '$')
                {
                    continue;
                }
                if (i != 0 && sentence[i - 1] != ' ')
                    continue;
                
                bool bl = false;
                double num = 0d;
                int idx = i;
                for (int j = i + 1; j < sentence.Length; j++)
                {
                    if (char.IsDigit(sentence[j]))
                    {
                        num *= 10;
                        num += sentence[j] - '0';
                        idx = j;
                        bl = true;
                    }
                    else if (sentence[j] == ' ')
                    {
                        break;
                    }
                    else
                    {
                        bl = false;
                        break;
                    }
                }
                if (bl)
                {
                    i = idx;
                    num = num - num * (d / 100);
                    num = Math.Round(num, 2);
                    sb.Append(num.ToString("F"));
                }
            }
            return sb.ToString();
        }
    }
}

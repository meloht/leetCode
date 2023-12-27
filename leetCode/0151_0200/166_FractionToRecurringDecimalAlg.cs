using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0151_0200
{
    public class _166_FractionToRecurringDecimalAlg
    {

        public string FractionToDecimal(int numerator, int denominator)
        {
            if (numerator == 0)
                return "0";
            StringBuilder sb = new StringBuilder();
            if ((numerator < 0 && denominator > 0) || (numerator >= 0 && denominator < 0))
            {
                sb.Append("-");
            }
            Dictionary<long, int> dict = new Dictionary<long, int>();
            long denominatorl = (long)denominator;
            long numeratorl = (long)numerator;
            long n = Math.Abs(numeratorl / denominatorl);
            long div = Math.Abs(denominatorl);
            long rem = Math.Abs(numeratorl % div);
            sb.Append(n);

            if (rem == 0)
                return sb.ToString();

            sb.Append(".");


            int i = 0;
            StringBuilder fractionPart = new StringBuilder();
            while (rem < div && rem != 0 && !dict.ContainsKey(rem))
            {
                dict.Add(rem, i);
                rem *= 10;
                long m = rem / div;
                fractionPart.Append(m);
                rem = rem % div;

                i++;
            }
            if (rem != 0)
            {
                int insertIndex = dict[rem];
                fractionPart.Insert(insertIndex, '(');
                fractionPart.Append(')');
            }

            sb.Append(fractionPart.ToString());
            return sb.ToString();

        }

    }
}

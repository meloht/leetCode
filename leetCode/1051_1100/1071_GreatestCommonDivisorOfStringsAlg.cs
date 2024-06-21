using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1051_1100
{
    public class _1071_GreatestCommonDivisorOfStringsAlg
    {
        public string GcdOfStrings(string str1, string str2)
        {
            if (str1 + str2 != str2 + str1)
                return "";
            int n = Gcd(str2.Length, str1.Length);

            return str1.Substring(0, n);
        }

        public int Gcd(int x, int y)
        {
            return x == 0 ? y : Gcd(y % x, x);
        }

    }
}

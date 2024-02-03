using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode
{
    internal class Utils
    {
        /// <summary>
        /// 1_000_000_007
        /// </summary>
        public static int Mod = 1_000_000_007;
        public static int gcd(int a, int b)
        {
            return b != 0 ? gcd(b, a % b) : a;
        }

        public static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int tmp = a % b;
                a = b;
                b = tmp;
            }
            return a;
        }

        public static string AddStrings(string num1, string num2)
        {
            int i = num1.Length - 1, j = num2.Length - 1, add = 0;
            List<int> ans = new List<int>();
            while (i >= 0 || j >= 0 || add != 0)
            {
                int x = i >= 0 ? num1[i] - '0' : 0;
                int y = j >= 0 ? num2[j] - '0' : 0;
                int result = x + y + add;
                ans.Add(result % 10);
                add = result / 10;
                i--;
                j--;
            }
            StringBuilder sb = new StringBuilder();
            for (int k = ans.Count - 1; k >= 0; k--)
            {
                sb.Append(ans[k]);
            }
            return sb.ToString();
        }


    }
}

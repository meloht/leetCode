using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2101_2150
{
    public class _2138_DivideAStringIntoGroupsOfSizeKAlg
    {
        public string[] DivideString(string s, int k, char fill)
        {
            int n = s.Length;
            string[] ans = new string[(n + k - 1) / k];
            for (int i = 0; i < n; i += k)
            {
                if (i + k <= n)
                {
                    ans[i / k] = s.Substring(i, k);
                }
                else
                {
                    ans[i / k] = s.Substring(i).PadRight(k, fill);
                }
            }
            return ans;

        }
    }
}

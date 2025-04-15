using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0901_0950
{
    public class _921_MinimumAddToMakeParenthesesValidAlg
    {
        public int MinAddToMakeValid(string s)
        {
            int n = 0;
            int ans = 0;
            foreach (var item in s)
            {
                if (item == '(')
                {
                    n++;
                }
                else
                {
                    if (n > 0)
                    {
                        n--;
                    }
                    else if (n == 0)
                    {
                        ans++;
                    }

                }
            }
            return ans + n;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace leetCode._1201_1250
{
    public class _1221_split_a_string_in_balanced_strings
    {
        public int BalancedStringSplit(string s)
        {
            int n1 = 0;
            int n2 = 0;
            int ans = 0;
            foreach (var item in s)
            {
                if (item == 'R')
                {
                    n1++;
                }
                else
                {
                    n2++;
                }
                if (n1 == n2)
                {
                    ans++;
                }
            }

            return ans;
        }
    }
}

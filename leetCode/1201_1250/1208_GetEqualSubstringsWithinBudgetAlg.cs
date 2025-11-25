using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1201_1250
{
    public class _1208_GetEqualSubstringsWithinBudgetAlg
    {
        public int EqualSubstring(string s, string t, int maxCost)
        {
            int n = s.Length;
            int[] diff = new int[n];
            for (int i = 0; i < n; i++)
            {
                diff[i] = Math.Abs(s[i] - t[i]);
            }
            int maxLength = 0;
            int start = 0, end = 0;
            int sum = 0;
            while (end < n)
            {
                sum += diff[end];
                while (sum > maxCost)
                {
                    sum -= diff[start];
                    start++;
                }
                maxLength = Math.Max(maxLength, end - start + 1);
                end++;
            }
            return maxLength;

        }
    }
}

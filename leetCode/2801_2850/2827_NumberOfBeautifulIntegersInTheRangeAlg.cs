using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2801_2850
{
    public class _2827_NumberOfBeautifulIntegersInTheRangeAlg
    {

        int[,,] dp;
        int K = 0;
        string begin;
        string end;
        public int NumberOfBeautifulIntegers(int low, int high, int k)
        {
            K = k;
            end = high.ToString();
            begin = low.ToString();
            begin = begin.PadLeft(end.Length, '0'); // 补前导零，和 num2 对齐
            int len = end.Length * 2 + 1;

            dp = new int[end.Length, k, len];
            for (int i = 0; i < end.Length; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    for (int m = 0; m < len; m++)
                    {
                        dp[i, j, m] = -1;
                    }
                }
            }

            int ans = Dfs(0, 0, end.Length, true, true, false);
            return ans;
        }

        private int Dfs(int i, int num, int diff, bool limitLow, bool limitHigh, bool isNum)
        {
            if (i == end.Length)
            {
                if (isNum && diff == end.Length && num == 0)
                {
                    return 1;
                }
                return 0;
            }
            if (!limitLow && !limitHigh && isNum && dp[i, num, diff] != -1)
            {
                return dp[i, num, diff];
            }

            int res = 0;
            if (!isNum && begin[i] == '0')
            {
                res = Dfs(i + 1, num, diff, true, false, false);
            }
            int low = limitLow ? begin[i] - '0' : 0;
            int high = limitHigh ? end[i] - '0' : 9;

            int d = isNum ? 0 : 1;
            int nn = Math.Max(d, low);
            for (int j = nn; j <= high; j++)
            {
                System.Diagnostics.Debug.Write(j);
                res += Dfs(i + 1, (num * 10 + j) % K, diff + j % 2 * 2 - 1, limitLow && j == low, limitHigh && j == high, true);
            }
            System.Diagnostics.Debug.WriteLine("");
            if (!limitHigh && !limitLow && isNum)
            {
                dp[i, num, diff] = res;
            }
            return res;
        }
    }
}

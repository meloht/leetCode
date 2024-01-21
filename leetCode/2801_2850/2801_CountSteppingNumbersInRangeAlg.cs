using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2801_2850
{
    public class _2801_CountSteppingNumbersInRangeAlg
    {
        int Mod = 1_000_000_007;
        int[,] dp;

        string begin;
        string end;
        public int CountSteppingNumbers(string low, string high)
        {
            end = high;
            begin = low;
            begin = begin.PadLeft(end.Length, '0'); // 补前导零，和 num2 对齐
            dp = new int[end.Length, 11];

            for (int i = 0; i < end.Length; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    dp[i, j] = -1;
                }

            }
            int ans = Dfs(0, 10, true, true, false);
            return ans;
        }

        private int Dfs(int i, int prev, bool limitLow, bool limitHigh, bool isNum)
        {
            if (i == end.Length)
            {
                if (isNum)
                {
                    return 1;
                }
                return 0;
            }
            if (!limitLow && !limitHigh && isNum && dp[i, prev] != -1)
            {
                return dp[i, prev];
            }

            int res = 0;
            if (!isNum && begin[i] == '0')
            {
                res = Dfs(i + 1, prev, true, false, false);
            }
            int low = limitLow ? begin[i] - '0' : 0;
            int high = limitHigh ? end[i] - '0' : 9;

            int d = isNum ? 0 : 1;
            int nn = Math.Max(d, low);
            for (int j = nn; j <= high; j++)
            {
                if (prev == 10 || Math.Abs(prev - j) == 1)
                {
                    res = (res + Dfs(i + 1, j, limitLow && j == low, limitHigh && j == high, true)) % Mod;
                }
            }

            if (!limitHigh && !limitLow && isNum)
            {
                dp[i, prev] = res;
            }
            return res;
        }
    }
}

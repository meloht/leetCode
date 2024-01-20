using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2901_3000
{
    public class _2999_CountTheNumberOfPowerfulIntegersAlg
    {
        long[] memo;
        string endStr;
        public long NumberOfPowerfulInt(long start, long finish, int limit, string s)
        {
            endStr = s;
            string end = finish.ToString();
            string begin = start.ToString();
            begin = begin.PadLeft(end.Length, '0'); // 补前导零，和 num2 对齐

            memo = new long[end.Length];
            for (int i = 0; i < end.Length; i++)
            {
                memo[i] = -1;
            }

            return Dfs(0,  true, true, begin, end, limit);
        }

        private long Dfs(int i, bool limitLow, bool limitHigh, string begin, string end, int limit)
        {
            if (i == end.Length)
            {
                return 1;
            }
            if (!limitLow && !limitHigh && memo[i] != -1)
            {
                return memo[i];
            }

            long res = 0;


            int low = limitLow ? begin[i] - '0' : 0;
            int high = limitHigh ? end[i] - '0' : 9;
            int endIndex = end.Length - endStr.Length;
            if (i < endIndex)
            {
                for (int j = low; j <= high && j <= limit; j++)
                {
                    res += Dfs(i + 1, limitLow && j == low, limitHigh && j == high, begin, end, limit);
                }
            }
            else
            {
                int num = endStr[i - endIndex] - '0';
                if (low <= num && num <= high && num <= limit)
                {
                    res += Dfs(i + 1, limitLow && num == low, limitHigh && num == high, begin, end, limit);
                }

            }


            if (!limitHigh && !limitLow)
            {
                memo[i] = res;
            }
            return res;
        }
    }
}

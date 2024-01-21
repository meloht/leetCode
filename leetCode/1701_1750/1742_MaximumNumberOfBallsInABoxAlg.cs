using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1701_1750
{
    public class _1742_MaximumNumberOfBallsInABoxAlg
    {
        string begin;
        string end;
        int[,] dp;
        public int CountBalls(int lowLimit, int highLimit)
        {
            begin = lowLimit.ToString();
            end = highLimit.ToString();
            begin = begin.PadLeft(end.Length, '0'); // 补前导零，和 num2 对齐
            int n = end.Length;
            int m = (n - 1) * 9 + (end[0] - '0') + 1;

            int MaxNum = 0;
            for (int i = 0; i < m; i++)
            {
                InitDp(n, m);
                int dd = Dfs(0, i, true, true, false);
                MaxNum = Math.Max(MaxNum, dd);
            }

            return MaxNum;
        }
        private void InitDp(int n, int m)
        {
            dp = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    dp[i, j] = -1;
                }
            }
        }

        private int Dfs(int i, int num, bool limitLow, bool limitHigh, bool isNum)
        {
            if (num < 0)
            {
                return 0;
            }
            if (i == end.Length)
            {
                if (num == 0)
                {
                    return 1;
                }
                return 0;
            }
            if (!limitLow && !limitHigh && isNum && dp[i, num] != -1)
            {
                return dp[i, num];
            }

            int res = 0;
            if (!isNum && begin[i] == '0')
            {
                res = Dfs(i + 1, num, true, false, false);
            }
            int low = limitLow ? begin[i] - '0' : 0;
            int high = limitHigh ? end[i] - '0' : 9;

            int d = isNum ? 0 : 1;
            int nn = Math.Max(d, low);

            for (int j = nn; j <= high; j++)
            {
                res += Dfs(i + 1, num - j, limitLow && j == low, limitHigh && j == high, true);
            }

            if (!limitHigh && !limitLow && isNum)
            {
                dp[i, num] = res;
            }

            return res;
        }


        public int CountBalls1(int lowLimit, int highLimit)
        {
            int n = highLimit.ToString().Length;
            int[] arr = new int[n * 9 + 1];
            int max = 0;
            for (int i = lowLimit; i <= highLimit; i++)
            {
                int sum = i % 10;
                int num = i;
                while (num > 0)
                {
                    num = num / 10;
                    sum += num % 10;
                }
                arr[sum]++;
                max = Math.Max(max, arr[sum]);
            }
            return max;
        }
    }
}

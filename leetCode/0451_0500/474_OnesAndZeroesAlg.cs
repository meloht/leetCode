using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0451_0500
{
    public class _474_OnesAndZeroesAlg
    {
        int[,,] dp;
        int Num0 = 0;
        int Num1 = 0;
        string[] Arr;
        public int FindMaxForm(string[] strs, int m, int n)
        {
            this.Num0 = m;
            this.Num1 = n;
            this.Arr = strs;
            dp = new int[m + 1, n + 1, strs.Length];
            for (int i = 0; i <= m; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    for (int k = 0; k < strs.Length; k++)
                    {
                        dp[i, j, k] = -1;
                    }
                }
            }
            int ans = Dfs(0, 0, 0, 0);
            return ans;
        }

        private int Dfs(int num0, int num1, int index, int count)
        {
            if (num1 > this.Num1 || num0 > this.Num0)
                return 0;

            if (index >= this.Arr.Length)
            {
                return count;
            }

            if (dp[num0, num1, index] != -1)
                return dp[num0, num1, index];


            int skip = Dfs(num0, num1, index + 1, count);

            var str = this.Arr[index];

            int n0 = str.Count(p => p == '0');
            int n1 = str.Length - n0;

            int choose = Dfs(num0 + n0, num1 + n1, index + 1, count + 1);

            int ans = Math.Max(choose, skip);

            dp[num0, num1, index] = ans;
            return ans;
        }


    }
}

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

        public int FindMaxForm(string[] strs, int m, int n)
        {
            int[,,] dp = new int[strs.Length, m + 1, n + 1];

            for (int k = 0; k < strs.Length; k++)
            {
                for (int i = 0; i <= m; i++)
                {
                    for (int j = 0; j <= n; j++)
                    {
                        dp[k, i, j] = -1;
                    }
                }
            }
            int ans = Dfs(m, n, 0, dp, strs);
            return ans;
        }

        private int Dfs(int num0, int num1, int index, int[,,] dp, string[] strs)
        {
            if (num1 < 0 || num0 < 0)
            {
                return 0;
            }

            if (index >= strs.Length)
            {
                return 0;
            }

            if (dp[index, num0, num1] != -1)
            {
                return dp[index, num0, num1];
            }
            int ans = Dfs(num0, num1, index + 1, dp, strs);

            var str = strs[index];

            int n0 = str.Count(p => p == '0');
            int n1 = str.Length - n0;

            if (num0 >= n0 && num1 >= n1)
            {
                int choose = Dfs(num0 - n0, num1 - n1, index + 1, dp, strs) + 1;
                ans = Math.Max(choose, ans);
            }

            dp[index, num0, num1] = ans;
            return ans;
        }


        public int FindMaxForm2(string[] strs, int m, int n)
        {
            int len = strs.Length;

            int[,,] dp = new int[strs.Length + 1, m + 1, n + 1];
            for (int i = 1; i <= len; i++)
            {
                string s = strs[i - 1];
                int zeros = s.Count(p => p == '0');
                int ones = s.Length - zeros;

                for (int j = 0; j <= m; j++)
                {
                    for (int k = 0; k <= n; k++)
                    {
                        dp[i, j, k] = dp[i - 1, j, k];
                        if (j >= zeros && k >= ones)
                        {
                            dp[i, j, k] = Math.Max(dp[i, j, k], dp[i - 1, j - zeros, k - ones] + 1);
                        }
                    }
                }
            }
            return dp[len, m, n];

        }

        public int FindMaxForm3(string[] strs, int m, int n)
        {
            int len = strs.Length;

            var dp = new int[m + 1, n + 1];
            for (int i = 0; i < len; i++)
            {
                string s = strs[i];
                int zeros = s.Count(p => p == '0');
                int ones = s.Length - zeros;

                for (int j = m; j >= 0; j--)
                {
                    for (int k = n; k >= 0; k--)
                    {
                        if (j >= zeros && k >= ones)
                        {
                            dp[j, k] = Math.Max(dp[j, k], dp[j - zeros, k - ones] + 1);
                        }
                    }
                }
            }
            return dp[m, n];

        }

    }
}

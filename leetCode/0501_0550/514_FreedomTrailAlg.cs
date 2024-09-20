using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0501_0550
{
    public class _514_FreedomTrailAlg
    {
        public int FindRotateSteps(string ring, string key)
        {
            int n = ring.Length;
            int m=key.Length;
            List<int>[] list =new List<int>[26];

            for (int i = 0; i < 26; i++)
            {
                list[i] = new List<int>();
            }
            for (int i = 0; i < n; i++)
            {
                list[ring[i] - 'a'].Add(i);
            }

            int[][] dp = new int[m][];
            for (int i = 0; i < m; i++)
            {
                dp[i] = new int[n];
                Array.Fill(dp[i], 0x3f3f3f);
            }
            foreach (var item in list[key[0]-'a'])
            {
                dp[0][item] = Math.Min(item, n - item) + 1;
            }
            for (int i = 1; i < m; ++i)
            {
                foreach (int j in list[key[i] - 'a'])
                {
                    foreach (int k in list[key[i - 1] - 'a'])
                    {
                        dp[i][j] = Math.Min(dp[i][j], dp[i - 1][k] + Math.Min(Math.Abs(j - k), n - Math.Abs(j - k)) + 1);
                    }
                }
            }


            return dp[m-1].Min();
        }
    }
}

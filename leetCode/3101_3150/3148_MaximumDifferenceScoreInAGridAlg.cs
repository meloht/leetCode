using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3101_3150
{

    public class _3148_MaximumDifferenceScoreInAGridAlg
    {
        public int MaxScore(IList<IList<int>> grid)
        {
            int m = grid.Count;
            int n = grid[0].Count;

            int[][] dp = new int[grid.Count][];
            for (int i = 0; i < m; i++)
            {
                dp[i] = new int[n];
                Array.Fill(dp[i], int.MinValue);
            }
            int ans = int.MinValue;
            dp[m - 1][n - 1] = grid[m - 1][n - 1];
            for (int i = n - 2; i >= 0; i--)
            {
                ans = Math.Max(ans, dp[m - 1][i + 1] - grid[m - 1][i]);
                dp[m - 1][i] = Math.Max(dp[m - 1][i + 1], grid[m - 1][i]);
            }

            for (int i = m - 2; i >= 0; i--)
            {
                ans = Math.Max(ans, dp[i + 1][n - 1] - grid[i][n - 1]);
                dp[i][n - 1] = Math.Max(dp[i + 1][n - 1], grid[i][n - 1]);
            }

            for (int i = m - 2; i >= 0; i--)
            {
                for (int j = n - 2; j >= 0; j--)
                {
                    ans = Math.Max(ans, dp[i + 1][j] - grid[i][j]);
                    ans = Math.Max(ans, dp[i][j + 1] - grid[i][j]);
                    dp[i][j] = Math.Max(dp[i + 1][j], grid[i][j]);
                    dp[i][j] = Math.Max(dp[i][j + 1], dp[i][j]);
                }
            }

            return ans;
        }
    }
}

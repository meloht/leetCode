using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0151_0200
{
    public class _174_DungeonGameAlg
    {
        public int CalculateMinimumHP(int[][] dungeon)
        {
            int m = dungeon.Length;
            int n = dungeon[0].Length;
            int[,] dp = new int[m + 1, n + 1];
            for (int i = 0; i <= m; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    dp[i, j] = int.MaxValue;
                }
            }

            dp[m, n - 1] = 1;
            dp[m - 1, n] = 1;
            for (int i = m - 1; i >= 0; --i)
            {
                for (int j = n - 1; j >= 0; --j)
                {
                    int minn = Math.Min(dp[i + 1, j], dp[i, j + 1]);
                    dp[i, j] = Math.Max(minn - dungeon[i][j], 1);
                }
            }
            return dp[0, 0];


        }

    }
}

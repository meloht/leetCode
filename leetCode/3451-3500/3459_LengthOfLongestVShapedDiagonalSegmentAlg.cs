using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._3451_3500
{
    public class _3459_LengthOfLongestVShapedDiagonalSegmentAlg
    {
        private static int[][] DIRS = [[1, 1], [1, -1], [-1, -1], [-1, 1]];

        public int LenOfVDiagonal(int[][] grid)
        {
            int m = grid.Length;
            int n = grid[0].Length;
            int[,,] memo = new int[m, n, 4];
            int ans = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (grid[i][j] != 1)
                    {
                        continue;
                    }
                    int[] maxs = { m - i, j + 1, i + 1, n - j }; // 理论最大值（走到底）
                    for (int k = 0; k < 4; k++)
                    { // 枚举起始方向
                      // 优化一：如果理论最大值没有超过 ans，那么不递归
                        if (maxs[k] > ans)
                        {
                            ans = Math.Max(ans, dfs(i, j, k, true, 2, grid, memo) + 1);
                        }
                    }
                }
            }
            return ans;

        }

        private int dfs(int i, int j, int k, bool canTurn, int target, int[][] grid, int[,,] memo)
        {
            i += DIRS[k][0];
            j += DIRS[k][1];
            if (i < 0 || i >= grid.Length || j < 0 || j >= grid[i].Length || grid[i][j] != target)
            {
                return 0;
            }
            // 只在 canTurn=false 时读取和写入 memo
            if (!canTurn && memo[i,j,k] > 0)
            {
                return memo[i, j, k];
            }
            int res = dfs(i, j, k, canTurn, 2 - target, grid, memo) + 1;
            if (!canTurn)
            {
                return memo[i, j, k] = res;
            }
            int[] maxs = { grid.Length - i, j + 1, i + 1, grid[i].Length - j }; // 理论最大值（走到底）
            k = (k + 1) % 4;
            // 优化二：如果理论最大值没有超过 res，那么不递归
            if (Math.Min(maxs[k], maxs[(k + 3) % 4]) > res)
            {
                res = Math.Max(res, dfs(i, j, k, false, 2 - target, grid, memo) + 1);
            }
            return res;
        }


    }
}

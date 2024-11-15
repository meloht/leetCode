using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3201_3250
{
    public class _3239_MinimumNumberOfFlipsToMakeBinaryGridPalindromicIAlg
    {
        public int MinFlips(int[][] grid)
        {
            int rows = grid.Length;
            int cols = grid[0].Length;
            int ans = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0, k = cols - 1; j < k; j++, k--)
                {
                    if (grid[i][j] != grid[i][k])
                    {
                        ans++;
                    }
                }
            }
            int ans2 = 0;
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0, k = rows - 1; j < k; j++, k--)
                {
                    if (grid[j][i] != grid[k][i])
                    {
                        ans2++;
                    }
                }
            }
            return Math.Min(ans, ans2);
        }
    }
}

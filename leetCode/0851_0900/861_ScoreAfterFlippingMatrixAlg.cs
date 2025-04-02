using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0851_0900
{
    public class _861_ScoreAfterFlippingMatrixAlg
    {
        public int MatrixScore(int[][] grid)
        {
            int m = grid.Length;
            int n = grid[0].Length;

            for (int i = 0; i < m; i++)
            {
                if (grid[i][0] == 0)
                {
                    for (int j = 0; j < n; j++)
                    {
                        grid[i][j] = grid[i][j] == 0 ? 1 : 0;
                    }
                }
            }
            for (int i = 1; i < n; i++)
            {
                int zero = 0;
                int one = 0;
                for (int j = 0; j < m; j++)
                {
                    if (grid[j][i] == 0)
                    {
                        zero++;
                    }
                    else
                    {
                        one++;
                    }
                }
                if (zero > one)
                {
                    for (int j = 0; j < m; j++)
                    {
                        grid[j][i] = grid[j][i] == 0 ? 1 : 0;
                    }
                }
            }
            int ans = 0;
            for (int i = 0; i < m; i++)
            {
                int power = n - 1;
                int num = 0;
                for (int j = 0; j < n; j++)
                {
                    num = (num << 1) | grid[i][j];
                }
                ans += num;
            }

            return ans;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0801_0850
{
    public class _840_MagicSquaresInGridAlg
    {
        public int NumMagicSquaresInside(int[][] grid)
        {
            if (grid.Length < 3 || grid[0].Length < 3)
                return 0;

            int ans = 0;
            for (int i = 0; i + 2 < grid.Length; i++)
            {
                for (int j = 0; j + 2 < grid[0].Length; j++)
                {
                    if (IsGrid(i, i + 2, j, j + 2, grid))
                    {
                        ans++;
                    }
                }
            }

            return ans;
        }

        private bool IsGrid(int r1, int r2, int c1, int c2, int[][] grid)
        {
            int sum = 0;
            int[] arr = new int[10];

            for (int i = r1, j = c1; i <= r2; i++, j++)
            {
                sum += grid[i][j];
            }

            int num = 0;
            for (int i = r1; i <= r2; i++)
            {
                num = 0;
                for (int j = c1; j <= c2; j++)
                {
                    num += grid[i][j];
                    if (grid[i][j] > 9 || grid[i][j] < 1)
                        return false;
                    arr[grid[i][j]] = 1;


                }
                if (sum == -1)
                {
                    sum = num;
                }
                if (sum != num)
                {
                    return false;
                }
            }
            if (arr.Count(p => p == 1) != 9)
                return false;

            for (int i = c1; i <= c2; i++)
            {
                num = 0;
                for (int j = r1; j <= r2; j++)
                {
                    num += grid[j][i];
                }
                if (sum != num)
                {
                    return false;
                }
            }
            num = 0;

            for (int i = r1, j = c2; i <= r2; i++, j--)
            {
                num += grid[i][j];
            }
            if (sum != num)
            {
                return false;
            }

            return true;
        }
    }
}

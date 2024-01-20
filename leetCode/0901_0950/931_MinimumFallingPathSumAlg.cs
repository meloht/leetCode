using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0901_0950
{
    public class _931_MinimumFallingPathSumAlg
    {
        public int MinFallingPathSum(int[][] matrix)
        {
            int n = matrix.Length;

            int[,] dp = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                dp[0, i] = matrix[0][i];
            }
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int num = dp[i - 1, j];

                    if (j + 1 < n)
                    {
                        num = Math.Min(num, dp[i - 1, j + 1]);
                    }
                    if (j - 1 >= 0)
                    {
                        num = Math.Min(num, dp[i - 1, j - 1]);
                    }
                    dp[i, j] = num + matrix[i][j];
                }
            }
            int min = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                min = Math.Min(min, dp[n - 1, i]);
            }
            return min;
        }
    }
}

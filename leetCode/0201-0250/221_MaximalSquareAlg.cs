using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0201_0250
{
    public class _221_MaximalSquareAlg
    {
        public int MaximalSquare(char[][] matrix)
        {
            int m = matrix.Length;
            int n = matrix[0].Length;
            int[,] dp = new int[m, n];
            int max = 0;
            for (int i = 0; i < n; i++)
            {
                dp[0, i] = matrix[0][i] - '0';
                max = Math.Max(max, dp[0, i]);
            }
            for (int i = 0; i < m; i++)
            {
                dp[i, 0] = matrix[i][0] - '0';
                max = Math.Max(max, dp[i, 0]);
            }

            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    if (matrix[i][j] == '1')
                    {
                        int num = Math.Min(dp[i - 1, j], dp[i - 1, j - 1]);
                        num = Math.Min(num, dp[i, j - 1]);
                        dp[i, j] = num + 1;
                        max = Math.Max(max, dp[i, j]);
                    }
                }
            }

            return max * max;
        }
    }
}

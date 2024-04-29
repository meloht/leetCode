using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0301_0350
{
    public class _329_LongestIncreasingPathInAMatrixAlg
    {
        int[][] dir = [[0, 1], [0, -1], [1, 0], [-1, 0]];

        public int LongestIncreasingPath(int[][] matrix)
        {
            int m = matrix.Length;
            int n = matrix[0].Length;
            int ans = 0;
            int[,] memo = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    ans = Math.Max(ans, Dfs(matrix, memo, i, j));
                }
            }
            return ans;
        }
        private int Dfs(int[][] matrix, int[,] memo, int i, int j)
        {
            if (memo[i, j] != 0)
                return memo[i, j];

            memo[i, j]++;

            foreach (var item in dir)
            {
                int x = i + item[0];
                int y = j + item[1];
                if (InRange(x, y, matrix) == false)
                {
                    continue;
                }
                if (matrix[x][y] > matrix[i][j])
                {
                    memo[i, j] = Math.Max(Dfs(matrix, memo, x, y) + 1, memo[i, j]);
                }

            }

            return memo[i, j];

        }
        private bool InRange(int i, int j, int[][] matrix)
        {
            if (i >= matrix.Length || i < 0 || j >= matrix[0].Length || j < 0)
            {
                return false;
            }
            return true;
        }

    }
}

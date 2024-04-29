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
        int ans = 0;
        public int LongestIncreasingPath(int[][] matrix)
        {
          
            int m = matrix.Length;
            int n = matrix[0].Length;
           
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    bool[,] vis = new bool[m, n];
                    Dfs(matrix, -1, 0, vis, i, j);
                }
            }
            return ans;
        }
        private void Dfs(int[][] matrix, int prev,int len, bool[,] vis, int i, int j)
        {
            if (InRange(i, j, matrix) == false)
            {
                return;
            }
            if (vis[i, j])
                return;
            if (matrix[i][j] <= prev)
                return;
            vis[i, j] = true;

          
            len++;
            ans = Math.Max(ans, len);
            foreach (var item in dir)
            {
                int x = i + item[0];
                int y = j + item[1];
                if (InRange(x, y, matrix) == false)
                {
                    continue;
                }
                Dfs(matrix, matrix[i][j], len, vis, x, y);
            }

            vis[i, j] = false;

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

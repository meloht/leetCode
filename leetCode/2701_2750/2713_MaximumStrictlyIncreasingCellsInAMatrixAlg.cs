using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2701_2750
{
    public class _2713_MaximumStrictlyIncreasingCellsInAMatrixAlg
    {
        int m = 0;
        int n = 0;
        public int MaxIncreasingCells(int[][] mat)
        {
            m = mat.Length;
            n = mat[0].Length;
            int[,] dp = new int[m, n];

            int ans = 0;

            int[] rowMin = new int[m];
            int[] colMin = new int[n];
            int[] rowMax = new int[m];
            int[] colMax = new int[n];
            for (int i = 0; i < m; i++)
            {
                int min = mat[i][0];
                int idx = 0;
                rowMax[i] = mat[i].Max();

                for (int j = 1; j < n; j++)
                {
                    if (mat[i][j] < min)
                    {
                        min = mat[i][j];
                        idx = j;
                    }
                }
                rowMin[i] = idx;
            }
            for (int i = 0; i < n; i++)
            {
                int max = mat[0][i];
                int min = mat[0][i];
                int idx = 0;
                for (int j = 1; j < m; j++)
                {
                    if (mat[j][i] < min)
                    {
                        min = mat[j][i];
                        idx = j;
                    }
                    max=Math.Max(max, mat[j][i]);
                }
                colMin[i] = idx;
                colMax[i] = max;
            }

            for (int i = 0; i < m; i++)
            {
                ans = Math.Max(Dfs(mat, i, rowMin[i], dp), ans);
            }
            for (int i = 0; i < n; i++)
            {
                ans = Math.Max(Dfs(mat, colMin[i], i, dp), ans);
            }
            return ans;
        }


        private int Dfs(int[][] mat, int row, int col, int[,] dp)
        {
            if (dp[row, col] != 0)
                return dp[row, col];
            int ans = 1;
            for (int i = 0; i < m; i++)
            {
                if (mat[i][col] > mat[row][col])
                {
                    ans = Math.Max(Dfs(mat, i, col, dp) + 1, ans);
                }
               
            }
            for (int i = 0; i < n; i++)
            {
                if (mat[row][i] > mat[row][col])
                {
                    ans = Math.Max(Dfs(mat, row, i, dp) + 1, ans);
                }
               
            }
            dp[row, col] = ans;
            return ans;
        }
    }
}

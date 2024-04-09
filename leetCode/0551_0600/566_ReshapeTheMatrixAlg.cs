using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0551_0600
{
    public class _566_ReshapeTheMatrixAlg
    {
        public int[][] MatrixReshape(int[][] mat, int r, int c)
        {
            int n = mat.Length;
            int m = mat[0].Length;

            if (n * m != r * c)
                return mat;
            int[][] grid = new int[r][];
            int col = 0;
            int row = 0;
            grid[row] = new int[c];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (col > 0 && col % c == 0)
                    {
                        row++;
                        grid[row] = new int[c];
                        col = 0;
                    }
                    grid[row][col] = mat[i][j];

                    col++;
                }
            }

            return grid;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3001_3050
{
    public class _3033_ModifyTheMatrixAlg
    {
        public int[][] ModifiedMatrix(int[][] matrix)
        {
            int n = matrix.Length;
            int m = matrix[0].Length;
            int[] maxCol = new int[m];

            for (int i = 0; i < m; i++)
            {
                int max = int.MinValue;
                for (int j = 0; j < n; j++)
                {
                    max = Math.Max(max, matrix[j][i]);
                }
                maxCol[i] = max;
            }
            int[][] ans = new int[n][];

            for (int i = 0; i < n; i++)
            {
                ans[i] = new int[m];
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i][j] == -1)
                    {
                        ans[i][j] = maxCol[j];
                    }
                    else
                    {
                        ans[i][j]=matrix[i][j];
                    }
                }
            }

            return ans;
        }
    }
}

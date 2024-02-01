using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0851_0900
{
    public class _867_TransposeMatrixAlg
    {
        public int[][] Transpose(int[][] matrix)
        {
            int n = matrix.Length;
            int m = matrix[0].Length;
            int[][] arr = new int[m][];
            for (int i = 0; i < m; i++)
            {
                arr[i] = new int[n];
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[j][i] = matrix[i][j];
                }
            }
            return arr;
        }
    }
}

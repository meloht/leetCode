using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0751_0800
{
    public class _766_ToeplitzMatrixAlg
    {
        public bool IsToeplitzMatrix(int[][] matrix)
        {
            int m = matrix.Length;
            int n = matrix[0].Length;
            for (int i = 0; i < n; i++)
            {
                int num = matrix[0][i];
                for (int k = 1, j = i + 1; j < n && k < m; j++, k++)
                {
                    if (num != matrix[k][j])
                        return false;
                }
            }
            for (int i = 1; i < m; i++)
            {
                int num = matrix[i][0];
                for (int k = i + 1, j = 1; j < n && k < m; j++, k++)
                {
                    if (num != matrix[k][j])
                        return false;
                }
            }
            return true;
        }
    }
}

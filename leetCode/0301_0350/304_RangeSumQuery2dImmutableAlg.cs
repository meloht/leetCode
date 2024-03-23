using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0301_0350
{
    public class _304_RangeSumQuery2dImmutableAlg
    {
        public class NumMatrix
        {

            int[,] sumMatrix;
            public NumMatrix(int[][] matrix)
            {
                int len = matrix[0].Length;
                sumMatrix = new int[matrix.Length + 1, len + 1];

                for (int i = 0; i < matrix.Length; i++)
                {
                    for (int j = 0; j < len; j++)
                    {
                        sumMatrix[i + 1, j + 1] = matrix[i][j] - sumMatrix[i, j] + sumMatrix[i, j + 1] + sumMatrix[i + 1, j];
                    }
                }

            }

            public int SumRegion(int row1, int col1, int row2, int col2)
            {
                int sum = sumMatrix[row2 + 1, col2 + 1] - sumMatrix[row2 + 1, col1] - sumMatrix[row1, col2 + 1] + sumMatrix[row1, col1];

                return sum;
            }
        }
    }
}

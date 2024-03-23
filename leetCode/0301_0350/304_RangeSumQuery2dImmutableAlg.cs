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
                sumMatrix = new int[matrix.Length, len];
                sumMatrix[0, 0] = matrix[0][0];
                for (int i = 1; i < len; i++)
                {
                    sumMatrix[0, i] = sumMatrix[0, i - 1] + matrix[0][i];
                }
                for (int i = 1; i < matrix.Length; i++)
                {
                    sumMatrix[i, 0] = sumMatrix[i - 1, 0] + matrix[i][0];
                }

                for (int i = 1; i < matrix.Length; i++)
                {
                    for (int j = 1; j < len; j++)
                    {
                        sumMatrix[i, j] = matrix[i][j] - sumMatrix[i - 1, j - 1] + sumMatrix[i - 1, j] + sumMatrix[i, j - 1];
                    }
                }

            }

            public int SumRegion(int row1, int col1, int row2, int col2)
            {
                int sum = sumMatrix[row2, col2];
                if (col1 - 1 >= 0)
                {
                    sum -= sumMatrix[row2, col1 - 1];
                }
                if (row1 - 1 >= 0)
                {
                    sum -= sumMatrix[row1 - 1, col2];
                }
                if (col1 - 1 >= 0 && row1 - 1 >= 0)
                {
                    sum += sumMatrix[row1 - 1, col1 - 1];
                }
                return sum;
            }
        }
    }
}

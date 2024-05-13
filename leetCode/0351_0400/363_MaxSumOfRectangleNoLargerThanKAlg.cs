using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0351_0400
{
    public class _363_MaxSumOfRectangleNoLargerThanKAlg
    {
        public int MaxSumSubmatrix(int[][] matrix, int k)
        {
            int m = matrix.Length;
            int n = matrix[0].Length;

            int[,] sumMat = new int[m, n];

            sumMat[0, 0] = matrix[0][0];

            for (int i = 1; i < m; i++)
            {
                sumMat[i, 0] = sumMat[i - 1, 0] + matrix[i][0];
            }
            for (int i = 1; i < n; i++)
            {
                sumMat[0, i] = sumMat[0, i - 1] + matrix[0][i];
            }

            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    sumMat[i, j] = sumMat[i - 1, j] + sumMat[i, j - 1] + matrix[i][j] - sumMat[i - 1, j - 1];
                }
            }

            int ans = int.MinValue;
            for (int i = 0; i < m; i++)
            {
                for (int j = m - 1; j >= i; j--)
                {
                    for (int col1 = 0; col1 < n; col1++)
                    {
                        for (int col2 = n - 1; col2 >= col1; col2--)
                        {
                            int sum = sumMat[j, col2];
                            if (i > 0)
                            {
                                sum -= sumMat[i - 1, col2];
                            }
                            if (col1 > 0)
                            {
                                sum -= sumMat[j, col1 - 1];
                            }
                            if (i > 0 && col1 > 0)
                            {
                                sum += sumMat[i - 1, col1 - 1];
                            }

                            if (sum == k)
                                return k;
                            if (sum < k)
                            {
                                ans = Math.Max(ans, sum);
                            }

                        }
                    }
                }
            }
            return ans;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1_50
{
    public class _48_RotateImageAlg
    {
        public void Rotate2(int[][] matrix)
        {
            int len = matrix.Length;
            List<List<int>> list = new List<List<int>>();
            for (int i = 0; i < len; i++)
            {
                List<int> arr = new List<int>();
                for (int j = 0; j < len; j++)
                {
                    arr.Add(matrix[i][j]);
                }
                list.Add(arr);
            }

            for (int i = 0; i < len ; i++)
            {
                for (int j = 0, n = len - 1; j < len && n >= 0; j++, n--)
                {
                    matrix[i][j] = list[n][i];
                }

            }

        }

        public void Rotate(int[][] matrix)
        {
            int n = matrix.Length;
            for (int i = 0; i < n / 2; ++i)
            {
                for (int j = 0; j < (n + 1) / 2; ++j)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[n - j - 1][i];
                    matrix[n - j - 1][i] = matrix[n - i - 1][n - j - 1];
                    matrix[n - i - 1][n - j - 1] = matrix[j][n - i - 1];
                    matrix[j][n - i - 1] = temp;
                }
            }
        }

    }
}

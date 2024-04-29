using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1301_1350
{
    public class _1329_SortTheMatrixDiagonallyAlg
    {
        public int[][] DiagonalSort(int[][] mat)
        {
            int m = mat.Length;
            int n = mat[0].Length;
            for (int i = 0; i < m; i++)
            {
                List<int> list = new List<int>();
                for (int j = 0, k = i; j < n && k < m; j++, k++)
                {
                    list.Add(mat[k][j]);
                }
                list.Sort();
                for (int j = 0, k = i; j < n && k < m; j++, k++)
                {
                    mat[k][j] = list[j];
                }
            }

            for (int j = 0; j < n; j++)
            {
                List<int> list = new List<int>();
                for (int i = 0, k = j; i < m && k < n; i++, k++)
                {
                    list.Add(mat[i][k]);
                }
                list.Sort();
                for (int i = 0, k = j; i < m && k < n; i++, k++)
                {
                    mat[i][k] = list[i];
                }
            }
            return mat;
        }
    }
}

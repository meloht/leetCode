using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0201_0250
{
    public class _240_SearchA2dMatrixIIAlg
    {
        private int t = 0;
        private int[][] mat;

        public bool SearchMatrix1(int[][] matrix, int target)
        {
            int m = matrix.Length;
            int n = matrix[0].Length;
            mat = matrix;
            t = target;

            if (m > n)
            {
                for (int i = 0; i < n; i++)
                {
                    var row = GetBinarySearch(i, m, true);
                    if (row.Item1)
                        return true;
                }
            }
            else
            {
                for (int i = 0; i < m; i++)
                {
                    var row = GetBinarySearch(i, n, false);
                    if (row.Item1)
                        return true;
                }
            }
           

            return false;
        }
        private int GetArr(int i, int j, bool isCol)
        {
            if (isCol)
            {
                return mat[i][j];// col
            }
            else
            {
                return mat[j][i];//row
            }

        }
        private Tuple<bool, int> GetBinarySearch(int col, int len, bool isCol)
        {
            int low = 0;
            int high = len - 1;
            while (low <= high)
            {
                int mid = (high - low) / 2 + low;
                int val = GetArr(mid, col, isCol);
                if (t > val)
                {
                    if (low == high)
                    {
                        return new Tuple<bool, int>(false, low);
                    }
                    if (mid == high)
                    {
                        return new Tuple<bool, int>(false, mid);
                    }
                    low = mid + 1;

                }
                else if (t < val)
                {
                    if (low == high)
                    {
                        int i = low - 1;
                        if (i < 0)
                        {
                            i = 0;
                        }
                        return new Tuple<bool, int>(false, i);
                    }
                    if (mid == 0)
                    {
                        return new Tuple<bool, int>(false, 0);
                    }
                    high = mid - 1;


                }
                else
                {
                    return new Tuple<bool, int>(true, mid);
                }
            }

            return new Tuple<bool, int>(false, Math.Min(high, low));
        }


        public bool SearchMatrix(int[][] matrix, int target)
        {
            int m = matrix.Length, n = matrix[0].Length;
            int x = 0, y = n - 1;
            while (x < m && y >= 0)
            {
                if (matrix[x][y] == target)
                {
                    return true;
                }
                if (matrix[x][y] > target)
                {
                    --y;
                }
                else
                {
                    ++x;
                }
            }
            return false;
        }

    }
}

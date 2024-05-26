﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1701_1750
{
    public class _1738_FindKthLargestXorCoordinateValueAlg
    {
        public int KthLargestValue(int[][] matrix, int k)
        {
            int m = matrix.Length, n = matrix[0].Length;
            int[,] pre = new int[m + 1, n + 1];
            List<int> results = new List<int>();
            for (int i = 1; i <= m; ++i)
            {
                for (int j = 1; j <= n; ++j)
                {
                    pre[i, j] = pre[i - 1, j] ^ pre[i, j - 1] ^ pre[i - 1, j - 1] ^ matrix[i - 1][j - 1];
                    results.Add(pre[i, j]);
                }
            }

            results.Sort((x, y) => y.CompareTo(x));

            return results[k - 1];

        }
    }
}

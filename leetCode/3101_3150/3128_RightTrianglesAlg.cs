using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3101_3150
{

    public class _3128_RightTrianglesAlg
    {
        public long NumberOfRightTriangles(int[][] grid)
        {
          
            int m = grid[0].Length;
            long ans = 0;
            int[] colSum = new int[m];
            Array.Fill(colSum, -1);
            foreach (int[] row in grid)
            {
                for (int i = 0; i < m; i++)
                {
                    colSum[i] += row[i];
                }
            }
            foreach (int[] row in grid)
            {
                int rowSum = -1;
                foreach (int item in row)
                {
                    rowSum += item;
                }
                for (int i = 0; i < m; i++)
                {
                    if (row[i] == 1)
                    {
                        ans += rowSum * colSum[i];
                    }
                }
            }

            return ans;
        }
    }
}

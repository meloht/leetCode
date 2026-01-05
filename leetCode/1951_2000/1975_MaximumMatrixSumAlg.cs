using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1951_2000
{
    public class _1975_MaximumMatrixSumAlg
    {
        public long MaxMatrixSum(int[][] matrix)
        {
            long total = 0;
            int negCnt = 0;
            int mn = int.MaxValue;
            foreach (int[] row in matrix)
            {
                foreach (int xx in row)
                {
                    int x = xx;
                    if (x < 0)
                    {
                        negCnt++;
                        x = -x; // 先把负数都变成正数
                    }
                    mn = Math.Min(mn, x);
                    total += x;
                }
            }

            if (negCnt % 2 > 0)
            {
                total -= mn * 2; // 给绝对值最小的数添加负号
            }
            return total;


        }
    }
}

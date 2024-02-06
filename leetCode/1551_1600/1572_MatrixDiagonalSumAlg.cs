using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1551_1600
{
    public class _1572_MatrixDiagonalSumAlg
    {
        public int DiagonalSum(int[][] mat)
        {
            int ans = 0;
            int len = mat.Length;
            for (int i = 0, m = len - 1; i < len; i++, m--)
            {
                ans += mat[i][i];
                if (i != m)
                {
                    ans += mat[i][m];
                }
            }
            return ans;
        }
    }
}

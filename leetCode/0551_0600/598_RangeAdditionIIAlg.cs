using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0551_0600
{
    public class _598_RangeAdditionIIAlg
    {
        public int MaxCount(int m, int n, int[][] ops)
        {
            int xx = m;
            int yy = n;
            for (int i = 0; i < ops.Length; i++)
            {
                xx = Math.Min(ops[i][0], xx);
                yy = Math.Min(ops[i][1], yy);

            }
            int count = xx * yy;

            return count;
        }
    }
}

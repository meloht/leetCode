using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0951_1000
{
    public class _0973_KClosestPointsToOriginAlg
    {
        public int[][] KClosest(int[][] points, int k)
        {
            if(points.Length==k)
                return points;

            Array.Sort(points, Dis);
            int[][] ans = new int[k][];
            for (int i = 0; i < k; i++)
            {
                ans[i] = points[i];
            }

            return ans;
        }

        private int Dis(int[] x, int[] y)
        {
            long d1 = (long)x[0] * (long)x[0] + (long)x[1] * (long)x[1];
            long d2 = (long)y[0] * (long)y[0] + (long)y[1] * (long)y[1];
            return d1.CompareTo(d2);
        }
    }
}

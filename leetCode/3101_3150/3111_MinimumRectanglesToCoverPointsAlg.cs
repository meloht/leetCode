using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._3101_3150
{
    public class _3111_MinimumRectanglesToCoverPointsAlg
    {
        public int MinRectanglesToCoverPoints(int[][] points, int w)
        {
            Array.Sort(points, (x, y) => x[0].CompareTo(y[0]));

            int bound = -1;
            int ans = 0;
            for (int i = 0; i < points.Length; i++)
            {
                var x = points[i][0];
                if (x > bound)
                {
                    bound = x + w;
                    ans++;
                }

            }

            return ans;
        }
    }
}

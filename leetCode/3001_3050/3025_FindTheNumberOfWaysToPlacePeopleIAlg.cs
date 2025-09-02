using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3001_3050
{
    public class _3025_FindTheNumberOfWaysToPlacePeopleIAlg
    {
        public int NumberOfPairs(int[][] points)
        {

            Array.Sort(points, (x, y) =>
            {
                if (x[0] == y[0])
                    return y[1] - x[1];
                return x[0] - y[0];
            });
            int ans = 0;
            for (int i = 0; i < points.Length; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    if (points[i][1] < points[j][1])
                    {
                        continue;
                    }
                    bool bl = true;
                    for (int k = i + 1; k < j; k++)
                    {
                        if (points[k][1] <= points[i][1] && points[k][1] >= points[j][1])
                        {
                            bl = false;
                            break;
                        }
                    }
                    if (bl)
                    {
                        ans++;
                    }
                }
            }

            return ans;
        }
    }
}

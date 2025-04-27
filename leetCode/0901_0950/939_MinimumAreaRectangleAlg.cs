using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0901_0950
{
    public class _939_MinimumAreaRectangleAlg
    {
        public int MinAreaRect(int[][] points)
        {
            Array.Sort(points, (x, y) => x[0] - y[0]);
            int ans = int.MaxValue;
            Dictionary<int, HashSet<int>> dict = [];
            foreach (var p in points)
            {
                if (dict.ContainsKey(p[0]))
                {
                    dict[p[0]].Add(p[1]);
                }
                else
                {
                    dict.Add(p[0], [p[1]]);
                }
            }
            Dictionary<int, int> lastX = [];
            foreach (var item in dict)
            {
                int x1 = item.Key;
                var ylist = item.Value.ToArray();
                Array.Sort(ylist);
                for (int i = 0; i < ylist.Length; i++)
                {
               
                    for (int j = i + 1; j < ylist.Length; j++)
                    {
                        int y1 = ylist[i];
                        int y2 = ylist[j];

                        int code = 40001 * y1 + y2;
                        if (lastX.ContainsKey(code))
                        {
                            int x2 = lastX[code];
                            ans = Math.Min(ans, Math.Abs(x1 - x2) * Math.Abs(y1 - y2));
                        }
                        if (lastX.ContainsKey(code))
                        {
                            lastX[code] = x1;
                        }
                        else
                        {
                            lastX.Add(code, x1);
                        }
                       
                    }
                }
            }
            return ans == int.MaxValue ? 0 : ans;
        }
    }
}

using leetCode._3051_3100;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3101_3150
{
    public class _3102_MinimizeManhattanDistancesAlg
    {
        public int MinimumDistance(int[][] points)
        {
            SortedList<int, int> xs = new SortedList<int, int>();
            SortedList<int, int> ys = new SortedList<int, int>();


            foreach (var item in points)
            {
                int x = item[0] + item[1];
                int y = item[1] - item[0];
               
                if (xs.ContainsKey(x))
                {
                    xs[x]++;
                }
                else
                {
                    xs.Add(x, 1);
                }

                if (ys.ContainsKey(y))
                {
                    ys[y]++;
                }
                else
                {
                    ys.Add(y, 1);
                }
            }


            int ans = int.MaxValue;
            foreach (var item in points)
            {
                int x = item[0] + item[1];
                int y = item[1] - item[0];
                xs[x]--;
                if (xs[x] == 0)
                {
                    xs.Remove(x);
                }
                ys[y]--;
                if (ys[y] == 0)
                {
                    ys.Remove(y);
                }

                ans = Math.Min(ans, Math.Max(xs.Last().Key - xs.First().Key, ys.Last().Key - ys.First().Key));
              

                if (xs.ContainsKey(x))
                {
                    xs[x]++;
                }
                else
                {
                    xs.Add(x, 1);
                }

                if (ys.ContainsKey(y))
                {
                    ys[y]++;
                }
                else
                {
                    ys.Add(y, 1);
                }
            }

            return ans;
        }
    }
}

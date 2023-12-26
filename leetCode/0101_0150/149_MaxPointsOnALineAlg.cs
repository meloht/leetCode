using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0101_0150
{
    public class _149_MaxPointsOnALineAlg
    {
        public int MaxPoints(int[][] points)
        {
            if (points.Length == 1)
                return 1;
            Dictionary<string, HashSet<string>> dict = new Dictionary<string, HashSet<string>>();

            Queue<int[]> queue = new Queue<int[]>();
            foreach (int[] point in points)
            {
                queue.Enqueue(point);
            }
            int count = 0;
            while (queue.Count > 0)
            {
                var x1 = queue.Dequeue();
                foreach (int[] x2 in queue)
                {
                    var k = GetK(x1, x2);
                    var b = GetB(x1, x2);

                    string p1 = $"{x1[0]}-{x1[1]}";
                    string p2 = $"{x2[0]}-{x2[1]}";

                    string key = $"{k}_{b}";

                    if (k == double.MinValue)
                    {
                        key = $"NaN_{x1[0]}";
                    }

                    if (!dict.ContainsKey(key))
                    {
                        var data = new HashSet<string>();
                        dict.Add(key, data);
                        data.Add(p1);
                        data.Add(p2);
                        count = Math.Max(data.Count, count);
                    }
                    else
                    {
                        var data = dict[key];
                        data.Add(p1);
                        data.Add(p2);
                        count = Math.Max(data.Count, count);
                    }


                }
            }

            return count;
        }
   
        private double GetK(int[] x1, int[] x2)
        {
            double y = x2[1] - x1[1];
            double x = x2[0] - x1[0];
            if (x == 0)
            {
                return double.MinValue;
            }
            double k = Math.Round(y / x, 4);
            return k;
        }
        private double GetB(int[] x1, int[] x2)
        {
            double y = x2[0] * x1[1] - x1[0] * x2[1];
            double x = x2[0] - x1[0];
            if (x == 0)
            {
                return double.MinValue;
            }
            double b = Math.Round(y / x, 4);
            return b;
        }



    }
}

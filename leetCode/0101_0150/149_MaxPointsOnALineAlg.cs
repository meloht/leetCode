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


        public int MaxPoints1(int[][] points)
        {
            int n = points.Length;
            if (n <= 2)
            {
                return n;
            }
            int ret = 0;
            for (int i = 0; i < n; i++)
            {
                if (ret >= n - i || ret > n / 2)
                {
                    break;
                }
                Dictionary<int, int> dictionary = new Dictionary<int, int>();
                for (int j = i + 1; j < n; j++)
                {
                    int x = points[i][0] - points[j][0];
                    int y = points[i][1] - points[j][1];
                    if (x == 0)
                    {
                        y = 1;
                    }
                    else if (y == 0)
                    {
                        x = 1;
                    }
                    else
                    {
                        if (y < 0)
                        {
                            x = -x;
                            y = -y;
                        }
                        int gcdXY = gcd(Math.Abs(x), Math.Abs(y));
                        x /= gcdXY;
                        y /= gcdXY;
                    }
                    int key = y + x * 20001;
                    if (!dictionary.ContainsKey(key))
                    {
                        dictionary.Add(key, 1);
                    }
                    else
                    {
                        dictionary[key]++;
                    }
                }
                int maxn = 0;
                foreach (int num in dictionary.Values)
                {
                    maxn = Math.Max(maxn, num + 1);
                }
                ret = Math.Max(ret, maxn);
            }
            return ret;
        }

        public int gcd(int a, int b)
        {
            return b != 0 ? gcd(b, a % b) : a;
        }



    }
}

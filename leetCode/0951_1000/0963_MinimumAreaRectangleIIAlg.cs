using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0951_1000
{
    public class _0963_MinimumAreaRectangleIIAlg
    {
        public struct LineData
        {
            public int[] pointX;
            public int[] pointY;
            public LineData(int[] x, int[] y)
            {
                pointX = x;
                pointY = y;
            }
        }
        public double MinAreaFreeRect(int[][] points)
        {
            int n = points.Length;
            Dictionary<long, List<LineData>> dict = new Dictionary<long, List<LineData>>();
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    var dis = GetDistance(points[i], points[j]);
                    if (dict.ContainsKey(dis))
                    {
                        dict[dis].Add(new LineData(points[i], points[j]));
                    }
                    else
                    {
                        List<LineData> ls = new List<LineData>();
                        ls.Add(new LineData(points[i], points[j]));
                        dict.Add(dis, ls);
                    }
                }
            }
            double ans = double.MaxValue;
            foreach (var item in dict)
            {
                if (item.Key == 0)
                    continue;

                for (int i = 0; i < item.Value.Count; i++)
                {
                    int[] p1 = item.Value[i].pointX;
                    int[] p2 = item.Value[i].pointY;
                    for (int j = i + 1; j < item.Value.Count; j++)
                    {
                        int[] pp1 = item.Value[j].pointX;
                        int[] pp2 = item.Value[j].pointY;

                        var d11 = GetDistance(p1, pp1);
                        var d12 = GetDistance(p2, pp2);
                        if (d11 != d12)
                        {
                            continue;
                        }
                        var d21 = GetDistance(p1, pp2);
                        var d22 = GetDistance(p2, pp1);

                        if (d21 == d22)
                        {
                            if (!IsRect(item.Key,d11,d22))
                            {
                                continue;
                            }
                            if (!IsRect(item.Key, d12, d21))
                            {
                                continue;
                            }
                            long sum = item.Key + d12 + d21;
                            long max = Math.Max(item.Key, Math.Max(d12, d21));
                            long min = Math.Min(item.Key, Math.Min(d12, d21));
                            long mid = sum - max - min;
                            if (ans > 0)
                            {
                                ans = Math.Min(ans, Math.Round(Math.Sqrt((double)mid) * Math.Sqrt((double)min), 5));
                            }

                        }
                    }
                }

            }

            return ans == double.MaxValue ? 0 : ans;
        }
        private long GetDistance(int[] a, int[] b)
        {
            long dis = (long)(a[0] - b[0]) * (long)(a[0] - b[0]) + (long)(a[1] - b[1]) * (long)(a[1] - b[1]);
            return dis;
        }
        public bool IsRect(long a, long b, long c)
        {
            long sum = a + b + c;
            long max = Math.Max(a, Math.Max(b, c));
            if (max != sum - max)
            {
                return false;
            }
            return true;
        }
    }
}

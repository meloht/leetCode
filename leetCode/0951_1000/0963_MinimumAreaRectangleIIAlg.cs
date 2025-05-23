using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0951_1000
{
    public class _0963_MinimumAreaRectangleIIAlg
    {
        public double MinAreaFreeRect(int[][] points)
        {
            Array.Sort(points, (x, y) => x[0].CompareTo(y[0]));
            int n = points.Length;
            Dictionary<double, List<int[][]>> dict = new Dictionary<double, List<int[][]>>();
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    double dis = GetDistance(points[i], points[j]);
                    if (dict.ContainsKey(dis))
                    {
                        dict[dis].Add([points[i], points[j]]);
                    }
                    else
                    {
                        List<int[][]> ls = new List<int[][]>();
                        ls.Add([points[i], points[j]]);
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
                    int[] p1 = item.Value[i][0];
                    int[] p2 = item.Value[i][1];
                    for (int j = i + 1; j < item.Value.Count; j++)
                    {
                        int[] pp1 = item.Value[j][0];
                        int[] pp2 = item.Value[j][1];

                        double d11 = GetDistance(p1, pp1);
                        double d12 = GetDistance(p2, pp2);
                        if (d11 != d12)
                        {
                            continue;
                        }
                        double d21 = GetDistance(p1, pp2);
                        double d22 = GetDistance(p2, pp1);

                        if (d21 == d22)
                        {
                            double[] arr = [item.Key, d11, d22];
                            Array.Sort(arr);
                            if (arr[0] + arr[1] != arr[2])
                            {
                                continue;
                            }
                            double[] arr1 = [item.Key, d12, d21];
                            Array.Sort(arr1);
                            if (arr1[0] + arr1[1] != arr1[2])
                            {
                                continue;
                            }
                            if (ans > 0)
                            {
                                ans = Math.Min(ans, Math.Round(arr[0] * arr[1], 5));
                            }

                        }
                    }
                }

            }

            return ans == double.MaxValue ? 0 : ans;
        }

        private double GetDistance(int[] a, int[] b)
        {

            
            long dis = (long)(a[0] - b[0]) * (long)(a[0] - b[0]) + (long)(a[1] - b[1]) * (long)(a[1] - b[1]);
            return Math.Round(Math.Sqrt(dis), 5);
        }
    }
}

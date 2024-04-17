using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0801_0850
{
    public class _812_LargestTriangleAreaAlg
    {
        public double LargestTriangleArea(int[][] points)
        {
            double max = 0;

            for (int i = 0; i < points.Length; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    for (int k = j + 1; k < points.Length; k++)
                    {
                        double res = GetArea(points[i], points[j], points[k]);
                        if (res == 0)
                            continue;
                        max = Math.Max(max, res);
                    }
                }
            }

            return Math.Round(max, 5);
        }

        private double GetArea(int[] a, int[] b, int[] c)
        {
            double x = GetLine(a, b);
            double y = GetLine(a, c);
            double z = GetLine(b, c);

            if (x + y <= z || x + z <= y || y + z <= x)
            {
                return 0;
            }

            double p = (x + y + z) / 2;

            double area = p * (p - x) * (p - y) * (p - z);
            return Math.Sqrt(area);
        }
        private double GetLine(int[] a, int[] b)
        {
            double num = (a[0] - b[0]) * (a[0] - b[0]) + (a[1] - b[1]) * (a[1] - b[1]);
            if (num == 0)
                return 0;
            return Math.Sqrt(num);
        }
    }
}

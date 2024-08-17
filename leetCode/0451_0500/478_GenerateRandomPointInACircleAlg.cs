using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0451_0500
{
    public class _478_GenerateRandomPointInACircleAlg
    {
        public class Solution1
        {
            Random random;
            double xc, yc, r;
            public Solution1(double radius, double x_center, double y_center)
            {
                random = new Random();
                xc = x_center;
                yc = y_center;
                r = radius;

            }

            public double[] RandPoint()
            {
                while (true)
                {
                    double x = random.NextDouble() * (2 * r) - r;
                    double y = random.NextDouble() * (2 * r) - r;
                    if (x * x + y * y <= r * r)
                    {
                        return new double[] { xc + x, yc + y };
                    }
                }


            }
        }

        public class Solution
        {
            double r, x, y;
            Random random = new Random();
            public Solution(double _r, double _x, double _y)
            {
                r = _r; x = _x; y = _y;
            }
            public double[] RandPoint()
            {
                double u = random.NextDouble();
                double theta = random.NextDouble() * 2 * Math.PI;
                double r = Math.Sqrt(u);
                return new double[] { x + r * Math.Cos(theta) * this.r, y + r * Math.Sin(theta) * this.r };


            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1_50
{
    public class _50_PowxNAlg
    {
        public double MyPow(double x, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else if (n > 0)
            {
                double sum = Compute(x, n);
                return Math.Round(sum, 5);
            }
            else
            {

                int count = 1;
                double sum = 1d;
                if (n == int.MinValue)
                {
                    count = -(n + 1);
                    sum = x;
                }
                else
                {
                    count = -n;
                }
                sum = sum * Compute(x, count);
                sum = 1d / sum;
                return Math.Round(sum, 5);
            }
        }


        private double Compute(double x, int n)
        {
            if (n == 1)
            {
                return x;
            }
            if (n == 2)
            {
                return x * x;
            }
            double sum = 1;
            int count = n;
            if (n % 2 == 1)//奇数
            {
                sum = x;
                count = n - 1;

            }
            int num = count / 2;
            double dd = Compute(x, num);
            sum = sum * dd * dd;
            return sum;
        }

    }
}

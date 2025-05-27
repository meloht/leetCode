using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0951_1000
{
    public class _2894_DivisibleAndNonDivisibleSumsDifferenceAlg
    {
        public int DifferenceOfSums(int n, int m)
        {
            int num1 = 0;
            int num2 = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % m == 0)
                {
                    num2 += i;
                }
                else
                {
                    num1 += i;
                }
            }

            return num1-num2;
        }

        public int DifferenceOfSums1(int n, int m)
        {
            int k = n / m;
            return n * (n + 1) / 2 - k * (k + 1) * m;
        }


    }
}

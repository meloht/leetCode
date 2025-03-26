using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2801_2850
{
    public class _2829_DetermineTheMinimumSumOfAKAvoidingArrayAlg
    {
        public int MinimumSum1(int n, int k)
        {
            int sum = 0;
            HashSet<int> set = new HashSet<int>();
            for (int i = 0, j = 1; i < n; i++)
            {
                if (j < k)
                {
                    while (set.Contains(k - j))
                    {
                        j++;
                    }

                }

                sum += j;
                set.Add(j);
                j++;
            }

            return sum;
        }

        public int MinimumSum(int n, int k)
        {
            if (n <= k / 2)
            {
                return ArithmeticSeriesSum(1, 1, n);
            }
            else
            {
                return ArithmeticSeriesSum(1, 1, k / 2) + ArithmeticSeriesSum(k, 1, n - k / 2);
            }
        }

        private int ArithmeticSeriesSum(int a1, int d, int n)
        {
            return (a1 + a1 + (n - 1) * d) * n / 2;
        }


    }
}

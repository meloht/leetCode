using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0501_0550
{
    public class _528_RandomPickWithWeightAlg
    {
        public class Solution
        {
            Random random = new Random();
            int[] sums;
            int max = 0;
            public Solution(int[] w)
            {
                sums = new int[w.Length];
                sums[0] = w[0];
                for (int i = 1; i < w.Length; i++)
                {
                    sums[i] = sums[i - 1] + w[i];
                }

                max = sums[w.Length - 1] + 1;
            }

            public int PickIndex()
            {
                int num = random.Next(1, max);
                int left = 0;
                int right = sums.Length - 1;
                while (left <= right)
                {
                    int mid = left + (right - left) / 2;
                    if (sums[mid] < num)
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
                return left;
            }
        }
    }
}

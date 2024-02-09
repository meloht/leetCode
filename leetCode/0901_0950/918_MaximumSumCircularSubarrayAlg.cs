using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0901_0950
{
    public class _918_MaximumSumCircularSubarrayAlg
    {
        public int MaxSubarraySumCircular(int[] nums)
        {
            int maxS = int.MinValue;
            int minS = 0;
            int maxPrev = 0;
            int minPrev = 0;
            int sum = 0;
            foreach (int item in nums)
            {
                maxPrev = Math.Max(maxPrev, 0) + item;
                maxS = Math.Max(maxS, maxPrev);

                minPrev = Math.Min(minPrev, 0) + item;
                minS = Math.Min(minS, minPrev);
                sum += item;
            }
            if (sum == minS)
            {
                return maxS;
            }
            return Math.Max(maxS, sum - minS);
        }


    }
}

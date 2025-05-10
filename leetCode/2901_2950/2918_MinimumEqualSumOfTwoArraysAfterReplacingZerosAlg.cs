using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2901_2950
{
    public class _2918_MinimumEqualSumOfTwoArraysAfterReplacingZerosAlg
    {
        public long MinSum(int[] nums1, int[] nums2)
        {
            long sum1 = 0;
            long sum2 = 0;
            int z1 = 0;
            int z2 = 0;

            foreach (var item in nums1)
            {
                sum1 += item;
                if (item == 0)
                {
                    z1++;
                }
            }
            foreach (var item in nums2)
            {
                sum2 += item;
                if (item == 0)
                {
                    z2++;
                }
            }
            if (z1 == 0 && z2 == 0)
            {
                if (sum1 == sum2)
                    return sum2;
                return -1;
            }
            else if (z1 == 0)
            {
                if (sum1 < sum2 + z2)
                    return -1;

                return sum1;
            }
            else if (z2 == 0)
            {
                if (sum2 < sum1 + z1)
                    return -1;

                return sum2;
            }
            else
            {
                long min1 = sum1 + z1;
                long min2 = sum2 + z2;
                return Math.Max(min1, min2);
            }

        }
    }
}

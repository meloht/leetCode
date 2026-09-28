using System;
using System.Collections.Generic;
using System.Text;

namespace leetCode._1251_1300
{
    public class _1283_find_the_smallest_divisor_given_a_threshold
    {
        public int SmallestDivisor(int[] nums, int threshold)
        {
            int left = 1;
            int right = nums.Max();
            int ans = 0;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                int val = CheckVal(mid, nums);
                if (val <= threshold)
                {
                    ans = mid;
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return ans;
        }
        private int CheckVal(int val, int[] nums)
        {
            int sum = 0;
            foreach (var item in nums)
            {
                sum += CeilDiv(item, val);
            }
            return sum;
        }

        public static int CeilDiv(int a, int b)
        {
            return (a + b - 1) / b;
        }
    }
}

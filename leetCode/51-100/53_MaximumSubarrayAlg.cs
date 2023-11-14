using leetCode._1_50;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._51_100
{
    public class _53_MaximumSubarrayAlg
    {
        public int MaxSubArray(int[] nums)
        {
            int max = nums.Max();
            int sum = nums.Sum();
            if (sum > max)
            {
                max = sum;
            }
            int len = nums.Length;
            int index = 0;
            for (int i = 2; i <= len - 1; i++)
            {
                index = 0;
                while (index < len)
                {
                    int count = index + i;
                    sum = 0;
                    for (int j = index; j < count && j < len; j++)
                    {
                        sum += nums[j];
                    }
                    if (sum > max)
                    {
                        max = sum;
                    }
                    index++;
                }
            }

            return max;
        }
    }
}

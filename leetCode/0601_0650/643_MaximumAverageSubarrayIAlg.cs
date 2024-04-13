using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0601_0650
{
    public class _643_MaximumAverageSubarrayIAlg
    {
        public double FindMaxAverage(int[] nums, int k)
        {
            double max = double.MinValue;
            int first = 0;

            int sum = 0;
            for (int i = 0; i < k; i++)
            {
                sum += nums[i];
            }
            max = sum;
            for (int i = k; i < nums.Length; i++)
            {
                sum = sum + nums[i] - nums[first];
                first++;
                max = Math.Max(sum, max);
            }
            return Math.Round((double)max / k, 5);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3151_4000
{
    public class _3194_MinimumAverageOfSmallestAndLargestElementsAlg
    {
        public double MinimumAverage(int[] nums)
        {
            Array.Sort(nums);
            double min = int.MaxValue;
            for (int i = 0, j = nums.Length - 1, n = nums.Length / 2; i < j && n > 0; i++, j--, n--)
            {
                double a = ((double)nums[i] + (double)nums[j]) / 2.0;
                min=Math.Min(min, a);
            }
            return min;
        }
    }
}

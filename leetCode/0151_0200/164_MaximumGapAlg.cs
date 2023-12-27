using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0151_0200
{
    public class _164_MaximumGapAlg
    {
        public int MaximumGap(int[] nums)
        {
            if (nums.Length < 2)
                return 0;
            int max = 0;
            Array.Sort(nums);
            int len = nums.Length - 1;
            for (int i = 0; i < len; i++)
            {
                int curr = nums[i];
                int next = nums[i + 1];
                max = Math.Max(max, next - curr);
            }


            return max;
        }
    }
}

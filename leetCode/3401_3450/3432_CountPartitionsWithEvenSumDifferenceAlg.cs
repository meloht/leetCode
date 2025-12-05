using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3401_3450
{
    public class _3432_CountPartitionsWithEvenSumDifferenceAlg
    {
        public int CountPartitions(int[] nums)
        {
            int ans = 0;
            int left = nums[0]; int right = 0;
            int total = nums.Sum();
            for (int i = 1; i < nums.Length; i++)
            {
                left += nums[i];
                right = total - left;
                if (Math.Abs(left - right) % 2 == 0)
                {
                    ans++;
                }
            }
            return ans;
        }
    }
}

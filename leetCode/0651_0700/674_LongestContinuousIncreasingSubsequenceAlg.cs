using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0651_0700
{
    public class _674_LongestContinuousIncreasingSubsequenceAlg
    {
        public int FindLengthOfLCIS(int[] nums)
        {
            if (nums.Length < 2)
                return 1;
            int ans = 1;
            int count = 1;
            int len = nums.Length;

            for (int i = 1; i < len; i++)
            {
                if (nums[i - 1] < nums[i])
                {
                    count++;
                    ans = Math.Max(ans, count);
                }
                else
                {
                    count = 1;
                }
            }
            return ans;
        }
    }
}

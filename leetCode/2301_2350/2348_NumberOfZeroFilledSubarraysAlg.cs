using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2301_2350
{
    public class _2348_NumberOfZeroFilledSubarraysAlg
    {
        public long ZeroFilledSubarray(int[] nums)
        {
            long ans = 0;
            int len = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    len++;
                    ans += len;
                }
                else
                {
                    len = 0;
                }
            }

            return ans;
        }
    }
}

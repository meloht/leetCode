using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3101_3150
{
    public class _3101_CountAlternatingSubarraysAlg
    {
        public long CountAlternatingSubarrays(int[] nums)
        {
            long ans = 1;
            long len = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    len++;
                }
                else
                {
                    len = 1;
                }
                ans += len;
            }
            return ans;
        }
    }
}

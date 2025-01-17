using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3201_3250
{
    public class _3209_NumberOfSubarraysWithAndValueOfKAlg
    {
        public long CountSubarrays(int[] nums, int k)
        {
            int n = nums.Length;
            long ans = 0;
            long count = 0;
            for (int i = 0; i < n; i++)
            {
                if (nums[i] == k)
                {
                    count++;
                }

                for (int j = i - 1; j >= 0 && (nums[j] & nums[i]) != nums[j]; j--)
                {
                    if (nums[j] == k)
                    {
                        count--;
                    }
                    nums[j] &= nums[i];
                    if (nums[j] == k)
                    {
                        count++;
                    }
                }
                ans += count;
            }

            return ans;
        }


    }
}

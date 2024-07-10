using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2951_3000
{
    public class _2970_CountTheNumberOfIncremovableSubarraysIAlg
    {
        public int IncremovableSubarrayCount(int[] nums)
        {

            int n = nums.Length;
            int i = 0;
            while (i < n - 1 && nums[i] < nums[i + 1])
            {
                i++;
            }
            if (i == n - 1)
            {
                return n * (n + 1) / 2;
            }
            int ans = i + 2;
            for (int j = n - 1; j == n - 1 || nums[j] < nums[j + 1]; j--)
            {
                while (i >= 0 && nums[i] >= nums[j])
                {
                    i--;
                }
                ans += i + 2;
            }

            return ans;
        }
    }
}

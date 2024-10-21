using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._0901_0950
{
    public class _910_SmallestRangeIIAlg
    {
        public int SmallestRangeII(int[] nums, int k)
        {
            Array.Sort(nums);
            int n = nums.Length;
            int ans = nums[n - 1] - nums[0];
            for (int i = 1; i < n; i++)
            {
                int mx = Math.Max(nums[i - 1] + k, nums[n - 1] - k);
                int mn = Math.Min(nums[0] + k, nums[i] - k);
                ans = Math.Min(ans, mx - mn);
            }
            return ans;

        }
    }
}

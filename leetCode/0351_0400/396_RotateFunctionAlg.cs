using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0351_0400
{
    public class _396_RotateFunctionAlg
    {
        public int MaxRotateFunction(int[] nums)
        {
            int f = 0;
            int sum = nums.Sum();
            int n = nums.Length;
            for (int i = 0; i < n; i++)
            {
                f += i * nums[i];
            }
            int ans = f;
            for (int i = n - 1; i > 0; i--)
            {
                f += sum - n * nums[i];
                ans = Math.Max(ans, f);
            }

            return ans;
        }
    }
}

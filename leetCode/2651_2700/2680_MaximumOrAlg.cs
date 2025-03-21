using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2651_2700
{
    public class _2680_MaximumOrAlg
    {
        public long MaximumOr1(int[] nums, int k)
        {
            int n = nums.Length;
            int[] suf = new int[n];

            for (int i = n - 2; i >= 0; i--)
            {
                suf[i] = suf[i + 1] | nums[i + 1];
            }

            long ans = 0;
            int pre = 0;
            for (int i = 0; i < n; i++)
            {
                ans = Math.Max(ans, pre | ((long)nums[i] << k) | suf[i]);
                pre |= nums[i];
            }

            return ans;
        }

        public long MaximumOr(int[] nums, int k)
        {
            int allOr = 0;
            int fixedVal = 0;
            foreach (int x in nums)
            {
                // 如果在计算 allOr |= x 之前，allOr 和 x 有公共的 1
                // 那就意味着有多个 nums[i] 在这些比特位上都是 1
                fixedVal |= allOr & x; // 把公共的 1 记录到 fixed 中
                allOr |= x; // 所有数的 OR
            }

            long ans = 0;
            foreach (int x in nums)
            {
                ans = Math.Max(ans, (allOr ^ x) | fixedVal | ((long)x << k));
            }
            return ans;
        }

    }
}

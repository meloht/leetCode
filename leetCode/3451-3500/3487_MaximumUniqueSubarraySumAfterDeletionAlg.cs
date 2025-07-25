using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3451_3500
{
    public class _3487_MaximumUniqueSubarraySumAfterDeletionAlg
    {
        public int MaxSum(int[] nums)
        {
            int ans = 0;
            HashSet<int> set = new HashSet<int>();
            int max = int.MinValue;
            foreach (var item in nums)
            {
                if (item > 0 && set.Add(item))
                {
                    ans += item;
                }
                max = Math.Max(max, item);
            }
            if (max > 0)
            {
                return ans;
            }
            return max;
        }
    }
}

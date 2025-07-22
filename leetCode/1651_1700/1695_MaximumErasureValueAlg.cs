using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1651_1700
{
    public class _1695_MaximumErasureValueAlg
    {
        public int MaximumUniqueSubarray(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();
            int ans = 0;
            int total = 0;
            for (int i = 0, j = 0; i < nums.Length; i++)
            {
                while (!set.Add(nums[i]))
                {
                    set.Remove(nums[j]);
                    total -= nums[j];
                    j++;
                }
                total += nums[i];

                ans = Math.Max(total, ans);
            }

            return ans;
        }
    }
}

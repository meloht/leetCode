using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1851_1900
{
    public class _1863_SumOfAllSubsetXorTotalsAlg
    {
        int ans = 0;
        public int SubsetXORSum(int[] nums)
        {
            Dfs(nums, 0, 0);
            return ans;
        }

        private void Dfs(int[] nums, int val, int idx)
        {
            if (idx == nums.Length)
            {
                ans += val;
                return;
            }

            Dfs(nums, val ^ nums[idx], idx + 1);
            Dfs(nums, val, idx + 1);
        }
    }
}

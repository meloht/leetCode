using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0551_0600
{
    public class _565_ArrayNestingAlg
    {

        public int ArrayNesting(int[] nums)
        {
            int ans = 0;

            int[] memo = new int[nums.Length];
            foreach (var item in nums)
            {
                ans = Math.Max(Dfs(nums, item, new HashSet<int>(), memo), ans);
            }
            return ans;
        }

        private int Dfs(int[] nums, int index, HashSet<int> set, int[] memo)
        {

            if (set.Contains(index))
            {
                return 0;
            }
            if (memo[index]!=0)
            {
                return memo[index];
            }
            set.Add(index);
            int len = Dfs(nums, nums[index], set, memo) + 1;
            
            memo[index] = len;
            return len;

        }
    }
}

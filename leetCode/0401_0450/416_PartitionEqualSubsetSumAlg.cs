using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0401_0450
{
    public class _416_PartitionEqualSubsetSumAlg
    {

        public bool CanPartition(int[] nums)
        {
            if (nums.Length < 2)
                return false;
            int t = nums.Sum();
            if (t % 2 > 0)
                return false;
            int num = t / 2;

            int[] used = new int[nums.Length];

            bool bl = Dfs(num, used, nums);

            return bl;
        }
        private bool Dfs(int sum, int[] used, int[] nums)
        {
            if (sum == 0)
                return true;

            if (sum < 0)
                return false;

            for (int j = 0; j < nums.Length; j++)
            {
                if (used[j] == 1)
                {
                    continue;
                }
                used[j] = 1;
                int rr = sum - nums[j];
                if (rr < 0)
                    break;
                bool bl = Dfs(rr, used, nums);
                used[j] = 0;
                if (bl)
                    return true;

            }

            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0451_0500
{
    public class _486_PredictTheWinnerAlg
    {
        public bool PredictTheWinner(int[] nums)
        {
            return Dfs(nums, 0, nums.Length - 1, 0, 0, true);
        }

        private bool Dfs(int[] nums, int i, int j, int a, int b, bool flag)
        {
            if (i > j)
            {
                return a >= b;
            }
            if (flag)
            {
                bool bl = Dfs(nums, i + 1, j, a + nums[i], b, false);
                if (bl)
                {
                    return true;
                }
                return Dfs(nums, i, j - 1, a + nums[j], b, false);
            }
            else
            {
                bool bl = Dfs(nums, i + 1, j, a, b + nums[i], true);
                if (!bl)
                {
                    return false;
                }
                return Dfs(nums, i, j - 1, a, b + nums[j], true);
            }

        }
    }
}

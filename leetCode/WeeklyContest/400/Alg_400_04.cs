using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode.WeeklyContest._400
{
    public class Alg_400_04
    {
        public int MinimumDifference(int[] nums, int k)
        {
            int ans = int.MaxValue;
            for (int i = 0; i < nums.Length; i++)
            {
                int x = nums[i];
                ans = Math.Min(ans, Math.Abs(x - k));
                for (int j = i - 1; j >= 0 && (nums[j] & x) != nums[j]; j--)
                {
                    nums[j] &= x;
                    ans = Math.Min(ans, Math.Abs(nums[j] - k));
                }
            }

            return ans;
        }
    }
}

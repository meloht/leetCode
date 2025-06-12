using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3401_3450
{
    public class _3423_MaximumDifferenceBetweenAdjacentElementsInACircularArrayAlg
    {
        public int MaxAdjacentDistance(int[] nums)
        {
            int ans = Math.Abs(nums[0] - nums[nums.Length - 1]);
            for (int i = 1; i < nums.Length; i++)
            {
                ans = Math.Max(Math.Abs(nums[i - 1] - nums[i]), ans);

            }
            return ans;
        }
    }
}

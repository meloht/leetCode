using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1101_1150
{
    public class _1144_DecreaseElementsToMakeArrayZigzagAlg
    {
        public int MovesToMakeZigzag(int[] nums)
        {
            int[] s = new int[2];
            for (int i = 0, n = nums.Length; i < n; ++i)
            {
                int left = i > 0 ? nums[i - 1] : int.MaxValue;
                int right = i < n - 1 ? nums[i + 1] : int.MaxValue;
                s[i % 2] += Math.Max(nums[i] - Math.Min(left, right) + 1, 0);
            }
            return Math.Min(s[0], s[1]);

        }
    }
}

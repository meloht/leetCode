using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0351_0400
{
    public class _376_WiggleSubsequenceAlg
    {
        public int WiggleMaxLength(int[] nums)
        {
            int n = nums.Length;
            if (n < 2)
            {
                return n;
            }
            int up = 1, down = 1;
            for (int i = 1; i < n; i++)
            {
                if (nums[i] > nums[i - 1])
                {
                    up = down + 1;
                }
                else if (nums[i] < nums[i - 1])
                {
                    down = up + 1;
                }
            }
            return Math.Max(up, down);
        }
    }
}

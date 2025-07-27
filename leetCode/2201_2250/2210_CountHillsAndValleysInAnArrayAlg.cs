using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2201_2250
{
    public class _2210_CountHillsAndValleysInAnArrayAlg
    {
        public int CountHillValley(int[] nums)
        {
            int ans = 0;
            int pre = nums[0];
            for (int i = 1; i < nums.Length - 1; i++)
            {
                int cur = nums[i];
                int nxt = nums[i + 1];
                if (cur == nxt)
                {
                    continue;
                }
                if (pre != cur && (pre < cur == cur > nxt))
                {
                    ans++;
                }
                pre = cur;
            }
            return ans;
        }
    }
}

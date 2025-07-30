using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2401_2450
{
    public class _2419_LongestSubarrayWithMaximumBitwiseAndAlg
    {
        public int LongestSubarray(int[] nums)
        {
            int ans = 0;
            int mx = 0;
            int cnt = 0;
            foreach (int x in nums)
            {
                if (x > mx)
                {
                    // 发现新的 mx，重新统计所有内容
                    mx = x;
                    cnt = 1;
                    ans = 1;
                }
                else if (x == mx)
                {
                    cnt++;
                    ans = Math.Max(ans, cnt);
                }
                else
                {
                    cnt = 0; // 连续 mx 断开了，重新统计
                }
            }
            return ans;


        }
    }
}

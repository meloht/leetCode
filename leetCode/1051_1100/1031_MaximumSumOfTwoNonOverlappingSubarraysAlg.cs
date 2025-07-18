using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1051_1100
{
    public class _1031_MaximumSumOfTwoNonOverlappingSubarraysAlg
    {
        public int MaxSumTwoNoOverlap(int[] nums, int firstLen, int secondLen)
        {
            int n = nums.Length;
            int[] s = new int[n + 1];
            for (int i = 0; i < n; i++) 
            {
                s[i + 1] = s[i] + nums[i]; // 计算 nums 的前缀和
            }
               
            return Math.Max(f(s, firstLen, secondLen), f(s, secondLen, firstLen));
        }

        private int f(int[] s, int firstLen, int secondLen)
        {
            int maxSumA = 0, res = 0;
            for (int i = firstLen + secondLen; i < s.Length; ++i)
            {
                maxSumA = Math.Max(maxSumA, s[i - secondLen] - s[i - secondLen - firstLen]);
                res = Math.Max(res, maxSumA + s[i] - s[i - secondLen]);
            }
            return res;
        }


    }
}

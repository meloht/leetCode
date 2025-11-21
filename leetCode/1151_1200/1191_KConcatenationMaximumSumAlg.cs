using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1151_1200
{
    public class _1191_KConcatenationMaximumSumAlg
    {
        public int KConcatenationMaxSum(int[] arr, int k)
        {
            if (k == 1)
            {
                return maxSubArray(arr, 1);
            }
            long ans = maxSubArray(arr, 2); // arr+arr 的最大子数组和
            int s = 0;
            foreach (int x in arr)
            {
                s += x;
            }
            ans += (long)Math.Max(s, 0) * (k - 2);
            return (int)(ans % 1_000_000_007);


        }
        // 53. 最大子数组和（repeat 表示重复次数）
        private int maxSubArray(int[] nums, int repeat)
        {
            int n = nums.Length;
            int ans = 0; // 本题允许子数组为空，ans 可以初始化成 0
            int f = 0;
            for (int i = 0; i < n * repeat; i++)
            {
                f = Math.Max(f, 0) + nums[i % n];
                ans = Math.Max(ans, f);
            }
            return ans;
        }


    }
}

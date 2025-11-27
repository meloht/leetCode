using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._3351_3400
{
    public class _3381_MaximumSubarraySumWithLengthDivisibleByKAlg
    {
        public long MaxSubarraySum(int[] nums, int k)
        {
            int n = nums.Length;
            long[] sum = new long[n + 1];
            for (int i = 0; i < n; i++)
            {
                sum[i + 1] = sum[i] + nums[i];
            }

            long[] minS = new long[k];
            Array.Fill(minS, long.MaxValue / 2); // 防止下面减法溢出

            long ans = long.MinValue;
            for (int j = 0; j < sum.Length; j++)
            {
                int i = j % k;
                ans = Math.Max(ans, sum[j] - minS[i]);
                minS[i] = Math.Min(minS[i], sum[j]);
            }
            return ans;


        }

        public long MaxSubarraySum1(int[] nums, int k)
        {
            long[] minS = new long[k];
            Array.Fill(minS, long.MaxValue / 2); // 防止下面减法溢出
            minS[k - 1] = 0;
            long ans = long.MinValue;
            long s = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                s += nums[j];
                int i = j % k;
                ans = Math.Max(ans, s - minS[i]);
                minS[i] = Math.Min(minS[i], s);
            }
            return ans;
        }

    }
}

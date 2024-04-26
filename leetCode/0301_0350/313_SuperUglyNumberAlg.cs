using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0301_0350
{
    public class _313_SuperUglyNumberAlg
    {
        public int NthSuperUglyNumber(int n, int[] primes)
        {
            if (n == 1)
                return 1;

            long[] dp = new long[n + 1];
            dp[1] = 1;
            int[] arr = new int[primes.Length];
            long[] nums = new long[primes.Length];
            Array.Fill(nums, 1);
          

            for (int i = 1; i <= n; i++)
            {
                long minNum = nums.Min();
                dp[i] = minNum;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (nums[j] == minNum)
                    {
                        arr[j]++;
                        nums[j] = dp[arr[j]] * primes[j];
                    }
                }

            }
            return (int)dp[n];
        }
    }
}

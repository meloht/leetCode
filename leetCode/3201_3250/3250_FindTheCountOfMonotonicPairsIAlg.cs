﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3201_3250
{
    public class _3250_FindTheCountOfMonotonicPairsIAlg
    {
        public int CountOfPairs(int[] nums)
        {
            int n = nums.Length;
            int m = nums.Max();
            int mod = (int)(1e9 + 7);
            int[][] dp = new int[n][];
            for (int i = 0; i < n; i++)
            {
                dp[i] = new int[m + 1];
            }
            for (int a = 0; a <= nums[0]; a++)
            {
                dp[0][a] = 1;
            }
            for (int i = 1; i < n; i++)
            {
                int d = Math.Max(0, nums[i] - nums[i - 1]);
                for (int j = d; j <= nums[i]; j++)
                {
                    if (j == 0)
                    {
                        dp[i][j] = dp[i - 1][j - d];
                    }
                    else
                    {
                        dp[i][j] = (dp[i][j - 1] + dp[i - 1][j - d]) % mod;
                    }
                }
            }
            int res = 0;
            foreach (int num in dp[n - 1])
            {
                res = (res + num) % mod;
            }
            return res;
        }
    }
}

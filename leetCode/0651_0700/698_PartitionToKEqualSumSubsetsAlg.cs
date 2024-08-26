﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0651_0700
{
    public class _698_PartitionToKEqualSumSubsetsAlg
    {
        public bool CanPartitionKSubsets(int[] nums, int k)
        {
            int all = nums.Sum();
            if (all % k != 0)
            {
                return false;
            }
            int per = all / k;
            Array.Sort(nums);
            int n = nums.Length;
            if (nums[n - 1] > per)
            {
                return false;
            }
            bool[] dp = new bool[1 << n];
            int[] curSum = new int[1 << n];
            dp[0] = true;
            for (int i = 0; i < 1 << n; i++)
            {
                if (!dp[i])
                {
                    continue;
                }
                for (int j = 0; j < n; j++)
                {
                    if (curSum[i] + nums[j] > per)
                    {
                        break;
                    }
                    if (((i >> j) & 1) == 0)
                    {
                        int next = i | (1 << j);
                        if (!dp[next])
                        {
                            curSum[next] = (curSum[i] + nums[j]) % per;
                            dp[next] = true;
                        }
                    }
                }
            }
            return dp[(1 << n) - 1];
        }

    }
}

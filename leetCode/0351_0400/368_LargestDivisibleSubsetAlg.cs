using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._0351_0400
{
    public class _368_LargestDivisibleSubsetAlg
    {
        public IList<int> LargestDivisibleSubset(int[] nums)
        {
            if (nums.Length < 2)
                return nums;
            Array.Sort(nums);

            int n = nums.Length;
            int[] memo = new int[n];
            int[] from = new int[n];
            Array.Fill(from, -1);
            int maxf = 0;
            int maxi = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int f = Dfs(nums, i, memo, from);
                if (f > maxf)
                {
                    maxf = f;
                    maxi = i;
                }
              
            }
            List<int> ans = new List<int>();
            for (int i = maxi; i >=0; i = from[i])
            {
                ans.Add(nums[i]);
            }
            return ans;
        }



        private int Dfs(int[] nums, int i, int[] memo, int[] from)
        {
            if (memo[i] > 0)
                return memo[i];

            int res = 0;
            for (int j = 0; j < i; j++)
            {
                if (nums[i] % nums[j] != 0)
                    continue;

                int f = Dfs(nums, j, memo, from);
                if (f > res)
                {
                    res = f;
                    from[i] = j;
                }
            }
            return memo[i] = res + 1;

        }



        public IList<int> LargestDivisibleSubset2(int[] nums)
        {
            int len = nums.Length;
            Array.Sort(nums);

            // 第 1 步：动态规划找出最大子集的个数、最大子集中的最大整数
            int[] dp = new int[len];
            Array.Fill(dp, 1);
            int maxSize = 1;
            int maxVal = dp[0];
            for (int i = 1; i < len; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    // 题目中说「没有重复元素」很重要
                    if (nums[i] % nums[j] == 0)
                    {
                        dp[i] = Math.Max(dp[i], dp[j] + 1);
                    }
                }

                if (dp[i] > maxSize)
                {
                    maxSize = dp[i];
                    maxVal = nums[i];
                }
            }

            // 第 2 步：倒推获得最大子集
            List<int> res = new List<int>();
            if (maxSize == 1)
            {
                res.Add(nums[0]);
                return res;
            }

            for (int i = len - 1; i >= 0 && maxSize > 0; i--)
            {
                if (dp[i] == maxSize && maxVal % nums[i] == 0)
                {
                    res.Add(nums[i]);
                    maxVal = nums[i];
                    maxSize--;
                }
            }
            return res;


        }


    }
}

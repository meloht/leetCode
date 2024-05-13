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
        int[] ans = [];
        public IList<int> LargestDivisibleSubset1(int[] nums)
        {
            if (nums.Length < 2)
                return nums;
            Array.Sort(nums);
          
            for (int i = 0; i < nums.Length; i++)
            {
                List<int> list = new List<int>();
                list.Add(nums[i]);
                Dfs(nums, nums[i], i + 1, list);
            }
            if (ans.Length == 0)
            {
                return [nums[0]];
            }
            return ans;
        }

        private void Dfs(int[] nums, int prev, int index, List<int> list)
        {
            if (index == nums.Length)
            {
                if (list.Count > 1)
                {
                    if (ans == null)
                    {
                        ans = list.ToArray();
                    }
                    else
                    {
                        if (ans.Length < list.Count)
                        {
                            ans = list.ToArray();
                        }
                    }
                }
                return;
            }

            if (nums[index] % prev == 0)
            {
                list.Add(nums[index]);
                Dfs(nums, nums[index], index + 1, list);
                list.Remove(nums[index]);
                Dfs(nums, prev, index + 1, list);
            }
            else
            {
                Dfs(nums, prev, index + 1, list);
            }

        }

        public IList<int> LargestDivisibleSubset(int[] nums)
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

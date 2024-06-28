using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCodeTemplates.动态规划
{
    public class DPTemplate
    {
        /// <summary>
        /// 最长上升子序列（LIS）
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        static int LongestIncreasingSubsequenceLength(int[] nums)
        {
            int n = nums.Length;
            int[] dp = new int[n];
            int max = 0;

            for (int i = 0; i < n; i++)
            {
                dp[i] = 1; // 每个元素默认以自己作为最长上升子序列的结尾
                for (int j = 0; j < i; j++)
                {
                    if (nums[j] < nums[i])
                        dp[i] = Math.Max(dp[i], dp[j] + 1);
                }
                max = Math.Max(max, dp[i]); // 更新最大长度
            }

            return max;
        }

        /// <summary>
        /// Function to solve the 0-1 Knapsack problem 0-1背包
        /// </summary>
        /// <param name="weights">物品的重量数组</param>
        /// <param name="values">物品的价值数组</param>
        /// <param name="capacity">背包的容量</param>
        /// <returns></returns>
        public static int KnapsackDP(int[] weights, int[] values, int capacity)
        {
            int n = weights.Length;
            // dp[i][j] will be the maximum value that can be attained with weight less than or equal to j using items up to i
            int[,] dp = new int[n + 1, capacity + 1];

            // Build table dp[][] in bottom up manner
            for (int i = 0; i <= n; i++)
            {
                for (int w = 0; w <= capacity; w++)
                {
                    if (i == 0 || w == 0)
                    {
                        dp[i, w] = 0;
                    }
                    else if (weights[i - 1] <= w)
                    {
                        dp[i, w] = Math.Max(values[i - 1] + dp[i - 1, w - weights[i - 1]], dp[i - 1, w]);
                    }
                    else
                    {
                        dp[i, w] = dp[i - 1, w];
                    }
                }
            }

            // dp[n][capacity] contains the maximum value that can be attained with the given capacity
            return dp[n, capacity];
        }
    }
}

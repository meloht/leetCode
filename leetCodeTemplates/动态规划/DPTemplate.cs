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
    }
}

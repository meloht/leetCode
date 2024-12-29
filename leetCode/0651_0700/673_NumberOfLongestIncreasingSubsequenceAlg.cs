using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0651_0700
{
    public class _673_NumberOfLongestIncreasingSubsequenceAlg
    {
        public int FindNumberOfLIS(int[] nums)
        {
            int n = nums.Length;

            int[] dp = new int[n];
            dp[0] = 1;
            int max = 0;
            int ans = 0;
            int[] cnt = new int[n];
            for (int i = 0; i < n; i++)
            {
                dp[i] = 1;
                cnt[i] = 1;
                for (int j = 0; j < i; j++)
                {
                    if (nums[j] < nums[i])
                    {
                        if (dp[j] + 1 > dp[i])
                        {
                            dp[i] = dp[j] + 1;
                            cnt[i] = cnt[j];
                        }
                        else if (dp[j] + 1 == dp[i])
                        {
                            cnt[i] += cnt[j];
                        }

                    }
                }
                if (dp[i] > max)
                {
                    max = dp[i];
                    ans = cnt[i];
                }
                else if (dp[i] == max)
                {
                    ans += cnt[i];
                }

            }

            return ans;
        }
    }
}

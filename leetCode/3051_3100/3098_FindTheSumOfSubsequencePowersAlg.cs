using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3051_3100
{
    public class _3098_FindTheSumOfSubsequencePowersAlg
    {
        const int MOD = 1000000007;
        private int[] nums = new int[1];
        public int SumOfPowers(int[] nums1, int k)
        {
            this.nums = nums1;
            int n = nums.Length;
            Array.Sort(nums);
            long ans = 0;
            Dictionary<int, int>[,] memo = new Dictionary<int, int>[n + 1, k + 1];
            for (int i = k - 1; i < n; i++)
            {
                var dict = Dfs(i, k, memo);
                foreach ((int diff, int cnt) in dict)
                {
                    long nn = cnt % MOD;
                    ans = (ans + (diff * nn) % MOD) % MOD;
                }
            }
            return (int)ans;
        }

        private Dictionary<int, int> Dfs(int root, int length, Dictionary<int, int>[,] memo)
        {
            if (memo[root, length] != null)
            {
                return memo[root, length];
            }

            Dictionary<int, int> cnt = new Dictionary<int, int>();
            if (length == 2)
            {
                for (int i = 0; i < root; i++)
                {
                    int diff = nums[root] - nums[i];
                    if (cnt.ContainsKey(diff))
                    {
                        cnt[diff] = (cnt[diff] + 1) % MOD;
                    }
                    else
                    {
                        cnt.Add(diff, 1);
                    }
                }
            }
            else
            {
                for (int i = length - 2; i < root; i++)
                {
                    int diff = nums[root] - nums[i];
                    var dict = Dfs(i, length - 1, memo);

                    foreach ((int lastDiff, int lastCnt) in dict)
                    {
                        if (lastDiff < diff)
                        {

                            if (cnt.ContainsKey(lastDiff))
                            {
                                cnt[lastDiff] = (lastCnt + cnt[lastDiff]) % MOD;
                            }
                            else
                            {
                                cnt.Add(lastDiff, lastCnt);
                            }
                        }
                        else
                        {
                            if (cnt.ContainsKey(diff))
                            {
                                cnt[diff] = (cnt[diff] + lastCnt) % MOD;
                            }
                            else
                            {
                                cnt.Add(diff, lastCnt);
                            }
                        }
                    }
                }
            }

            memo[root, length] = cnt;

            return cnt;

        }
    }
}

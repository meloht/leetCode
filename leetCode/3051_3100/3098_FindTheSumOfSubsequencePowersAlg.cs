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
        private int[] nums;
        public int SumOfPowers(int[] nums, int k)
        {
            this.nums = nums;
            int n = nums.Length;
            Array.Sort(nums);
            int ans = 0;
            Dictionary<int, int>[,] memo = new Dictionary<int, int>[n + 1, k + 1];
            for (int i = k - 1; i < n; i++)
            {

                var dict = Dfs(i, k, memo);
                foreach (var item in dict)
                {
                    ans = (ans + (item.Key * item.Value) % MOD) % MOD;
                }
            }
            return ans;
        }

        private Dictionary<int, int> Dfs(int root, int length, Dictionary<int, int>[,] memo)
        {
            if (memo[root, length] != null)
                return memo[root, length];
            Dictionary<int, int> cnt = new Dictionary<int, int>();
            if (length == 2)
            {
                for (int i = 0; i < root; i++)
                {
                    int diff = nums[root] - nums[i];
                    if (cnt.ContainsKey(diff))
                    {
                        cnt[diff]++;
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

                    foreach (var item in dict)
                    {
                        if (item.Key < diff)
                        {

                            if (cnt.ContainsKey(item.Key))
                            {
                                cnt[item.Key] += item.Value;
                            }
                            else
                            {
                                cnt.Add(item.Key, item.Value);
                            }
                        }
                        else
                        {
                            if (cnt.ContainsKey(diff))
                            {
                                cnt[diff] += item.Value;
                            }
                            else
                            {
                                cnt.Add(diff, item.Value);
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

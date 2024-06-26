using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace leetCode._2701_2750
{
    public class _2741_SpecialPermutationsAlg
    {
        int Mod = 1_000_000_007;
        public int SpecialPerm(int[] nums)
        {
            Dictionary<int, HashSet<int>> dict = new Dictionary<int, HashSet<int>>();
            HashSet<int> sets = new HashSet<int>();

            int ans = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                HashSet<int> set = new HashSet<int>();
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    if (nums[i] % nums[j] == 0)
                    {
                        set.Add(j);
                    }
                    else if (nums[j] % nums[i] == 0)
                    {
                        set.Add(j);
                    }
                }
                dict.Add(i, set);
            }
            int[][] dp = new int[nums.Length + 1][];
            for (int i = 0; i < nums.Length + 1; i++)
            {
                dp[i] = new int[nums.Length];
                Array.Fill(dp[i], -1);
            }
            for (int i = 0; i < nums.Length; i++)
            {
                sets.Add(i);
                ans = (ans + Dfs(i,  sets, dict, dp) % Mod) % Mod;
                sets.Remove(i);
            }


            return ans;
        }
        private int Dfs(int pre,  HashSet<int> sets, Dictionary<int, HashSet<int>> dict, int[][] dp)
        {
            if (sets.Count == dict.Count)
                return 1;

            if (dp[sets.Count][pre] != -1)
                return dp[sets.Count][pre];
            int ans = 0;
            var list = dict[pre];
            foreach (var item in list)
            {
                if (sets.Contains(item))
                    continue;
                sets.Add(item);

                ans = (ans + Dfs(item, sets, dict, dp) % Mod) % Mod;
                sets.Remove(item);
            }
            dp[sets.Count][pre] = ans;
            return ans;
        }
    }
}

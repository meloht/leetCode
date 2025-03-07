using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2551_2600
{
    public class _2597_TheNumberOfBeautifulSubsetsAlg
    {
        private int ans = -1;
        public int BeautifulSubsets(int[] nums, int k)
        {
            Dictionary<int, int> cnt = new Dictionary<int, int>();
            Dfs(0, nums, k, cnt);
            return ans;
        }

        private void Dfs(int i, int[] nums, int k, Dictionary<int, int> cnt)
        {
            if (nums.Length == i)
            {
                ans++;
                return;
            }
            Dfs(i + 1, nums, k, cnt);
            int x = nums[i];
            if (cnt.GetValueOrDefault(x - k, 0) == 0 && cnt.GetValueOrDefault(x + k, 0) == 0)
            {
                if (cnt.ContainsKey(x))
                {
                    cnt[x]++;
                }
                else
                {
                    cnt.Add(x, 1);
                }
               
                Dfs(i + 1, nums, k, cnt);
                cnt[x]--;
            }
        }
    }
}

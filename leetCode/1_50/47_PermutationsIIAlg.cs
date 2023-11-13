using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._1_50
{
    public class _47_PermutationsIIAlg
    {

        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            var ans = new List<IList<int>>();
            List<int> perm = new List<int>();
            bool[] vis = new bool[nums.Length];
            Array.Sort(nums);
            Backtrack(nums, ans, perm, vis);
            return ans;

        }
        public void Backtrack(int[] nums, List<IList<int>> ans, List<int> perm, bool[] vis)
        {
            if (perm.Count == nums.Length)
            {
                ans.Add(new List<int>(perm));
                return;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (vis[i] || (i > 0 && nums[i] == nums[i - 1] && !vis[i - 1]))
                {
                    continue;
                }
                perm.Add(nums[i]);
                vis[i] = true;
                Backtrack(nums, ans, perm, vis);
                vis[i] = false;
                perm.RemoveAt(perm.Count - 1);
            }
        }

        public IList<IList<int>> PermuteUnique1(int[] nums)
        {
            var res = new List<IList<int>>();
            if (nums.Length == 0)
            {
                res.Add(new List<int>(nums));
                return res;
            }
            Array.Sort(nums);
            HashSet<string> set = new HashSet<string>();
            List<int> current = new List<int>();
            bool[] used = new bool[nums.Length];
            Permute(nums, set, current, res, used);
            return res;
        }

        private static void Permute(int[] candidates, HashSet<string> set, List<int> current, IList<IList<int>> result, bool[] used)
        {
            if (current.Count == candidates.Length)
            {
                var dd = new List<int>(current);
                string res = string.Join(",", dd);
                if (!set.Contains(res))
                {
                    result.Add(dd);
                    set.Add(res);
                }

                return;
            }
            for (int i = 0; i < candidates.Length; i++)
            {
                if (used[i] || (i > 0 && candidates[i] == candidates[i - 1] && !used[i - 1]))
                {
                    continue;
                }

                used[i] = true;
                current.Add(candidates[i]);
                Permute(candidates, set, current, result, used);
                used[i] = false;
                current.RemoveAt(current.Count - 1);


            }
        }
    }
}

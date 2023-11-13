using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1_50
{
    public class _47_PermutationsIIAlg
    {
        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            var res = new List<IList<int>>();
            if (nums.Length == 0)
            {
                res.Add(new List<int>(nums));
                return res;
            }
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
                if (used[i])
                {
                    continue; // 跳过重复元素
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

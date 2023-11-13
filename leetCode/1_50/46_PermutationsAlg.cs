using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1_50
{
    public class _46_PermutationsAlg
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            var res = new List<IList<int>>();
            if (nums.Length == 0)
            {
                res.Add(new List<int>(nums));
                return res;
            }

            List<int> current = new List<int>();
            bool[] used = new bool[nums.Length];
            Permute(nums, current, res, used);
            return res;
        }


        private static void Permute(int[] candidates, List<int> current, IList<IList<int>> result, bool[] used)
        {
            if (current.Count == candidates.Length)
            {
                result.Add(new List<int>(current));
                return;
            }

            for (int i = 0; i < candidates.Length; i++)
            {
                if (used[i] || (i > 0 && candidates[i] == candidates[i - 1] && !used[i - 1]))
                {
                    continue; // 跳过重复元素
                }

                used[i] = true;
                current.Add(candidates[i]);
                Permute(candidates, current, result, used);
                used[i] = false;
                current.RemoveAt(current.Count - 1);
            }
        }


    }
}

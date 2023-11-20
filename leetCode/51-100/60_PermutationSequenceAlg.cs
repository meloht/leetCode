using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._51_100
{
    public class _60_PermutationSequenceAlg
    {
        public string GetPermutation(int n, int k)
        {
            List<int> ints = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                ints.Add(i);
            }
            var nums = ints.ToArray();
            var res = new List<IList<int>>();
            if (nums.Length == 1)
            {
                return "1";
            }

            List<int> current = new List<int>();
            bool[] used = new bool[nums.Length];
            Permute(nums, current, res, used, k);
            string ss = string.Join("", res[res.Count-1]);
            return ss;
        }


        private static void Permute(int[] candidates, List<int> current, IList<IList<int>> result, bool[] used, int k)
        {
            if (current.Count == candidates.Length && result.Count < k)
            {
                result.Add(new List<int>(current));
                return;
            }

            for (int i = 0; i < candidates.Length; i++)
            {
                if (result.Count == k)
                    return;

                if (used[i])
                {
                    continue;
                }

                used[i] = true;
                current.Add(candidates[i]);
                Permute(candidates, current, result, used, k);
                used[i] = false;
                current.RemoveAt(current.Count - 1);

            }
        }
    }
}

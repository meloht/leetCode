using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._51_100
{
    public class _60_PermutationSequenceAlg
    {
        int count = 0;
        string res = "";
        public string GetPermutation(int n, int k)
        {
            List<int> ints = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                ints.Add(i);
            }
            var nums = ints.ToArray();
          
            if (nums.Length == 1)
            {
                return "1";
            }
            List<int> current = new List<int>();
            bool[] used = new bool[nums.Length];
            Permute(nums, current, used, k);
            return res;
        }


        private void Permute(int[] candidates, List<int> current, bool[] used, int k)
        {
            if (current.Count == candidates.Length)
            {
                count++;
                if (count == k)
                {
                    res = string.Join("", current);
                }

                return;
            }

            for (int i = 0; i < candidates.Length; i++)
            {
                if (count == k)
                    return;

                if (used[i])
                {
                    continue;
                }

                used[i] = true;
                current.Add(candidates[i]);
                Permute(candidates, current, used, k);
                used[i] = false;
                current.RemoveAt(current.Count - 1);

            }
        }
    }
}

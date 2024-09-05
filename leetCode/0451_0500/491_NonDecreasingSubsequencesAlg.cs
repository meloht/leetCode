using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0451_0500
{
    public class _491_NonDecreasingSubsequencesAlg
    {
        public IList<IList<int>> FindSubsequences1(int[] nums)
        {
            List<IList<int>> res = new List<IList<int>>();
            bool[] used = new bool[nums.Length];
            Dfs(0, -101, nums, used, res);
            return res;
        }
        private void Dfs(int index, int prev, int[] nums, bool[] used, List<IList<int>> res)
        {
            if (index >= nums.Length)
            {
                if (prev == -101)
                    return;
                List<int> ls = new List<int>();
                for (int i = 0; i < used.Length; i++)
                {
                    if (used[i])
                    {
                        ls.Add(nums[i]);
                    }
                }

                if (ls.Count > 1)
                {
                    res.Add(ls);
                }

                return;
            }

            if (nums[index] >= prev)
            {
                used[index] = true;
                Dfs(index + 1, nums[index], nums, used, res);
                used[index] = false;
            }
            if (nums[index] != prev)
            {
                used[index] = false;
                Dfs(index + 1, prev, nums, used, res);
            }

        }

        public IList<IList<int>> FindSubsequences(int[] nums)
        {
            List<IList<int>> res = new List<IList<int>>();
            bool[] used = new bool[nums.Length];
            Dfs1(0, -101, nums, new List<int>(), res);
            return res;
        }
        private void Dfs1(int index, int prev, int[] nums, List<int> list, List<IList<int>> res)
        {
            if (index >= nums.Length)
            {
                if (prev == -101)
                    return;

                if (list.Count > 1)
                {
                    res.Add(list.ToArray());
                }

                return;
            }

            if (nums[index] >= prev)
            {
                list.Add(nums[index]);
                Dfs1(index + 1, nums[index], nums, list, res);
                list.RemoveAt(list.Count - 1);
            }

            if (nums[index] != prev)
            {
                Dfs1(index + 1, prev, nums, list, res);
            }

        }
    }
}

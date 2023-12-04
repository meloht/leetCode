using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._51_100
{
    public class _90_SubsetsIIAlg
    {
        public IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            List<IList<int>> res = new List<IList<int>>();
            res.Add(new int[] { });
            Array.Sort(nums);
            HashSet<string> set = new HashSet<string>();
            List<int> ls = new List<int>();
            for (int i = 1; i <= nums.Length; i++)
            {
                CombineList(res, set, 0, i, ls.ToArray(), nums);
            }
            return res;
        }

        private void CombineList(List<IList<int>> res, HashSet<string> set, int begin, int k, int[] arr, int[] nums)
        {
            if (arr.Length == k)
            {
                string ss = string.Join(",", arr);
                if (!set.Contains(ss))
                {
                    res.Add(arr.ToList());
                    set.Add(ss);
                }
                return;
            }
            List<int> ls = arr.ToList();
            for (int i = begin; i < nums.Length; i++)
            {
                ls.Add(nums[i]);
                CombineList(res, set, i + 1, k, ls.ToArray(), nums);
                ls.RemoveAt(ls.Count - 1);
            }
        }

    }
}

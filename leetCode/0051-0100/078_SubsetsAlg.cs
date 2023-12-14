using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._51_100
{
    public class _78_SubsetsAlg
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
            List<IList<int>> res = new List<IList<int>>();
            res.Add(new int[] { });

            List<int> ls = new List<int>();
            for (int i = 1; i <= nums.Length; i++)
            {
                CombineList(res, 0, i, ls.ToArray(), nums);
            }

            return res;
        }

        private void CombineList(List<IList<int>> res, int begin, int k, int[] arr, int[] nums)
        {
            if (arr.Length == k)
            {
                res.Add(arr.ToList());
                return;
            }
            List<int> ls = arr.ToList();
            for (int i = begin; i < nums.Length; i++)
            {
                ls.Add(nums[i]);
                CombineList(res, i + 1, k, ls.ToArray(), nums);
                ls.RemoveAt(ls.Count - 1);
            }
        }
    }
}

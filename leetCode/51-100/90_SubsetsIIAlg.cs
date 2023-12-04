using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._51_100
{
    public class _90_SubsetsIIAlg
    {
        HashSet<string> set = new HashSet<string>();
        List<IList<int>> res = new List<IList<int>>();
        List<int> tlist = new List<int>();
        public IList<IList<int>> SubsetsWithDup2(int[] nums)
        {

            res.Add(new int[] { });
            Array.Sort(nums);

            List<int> ls = new List<int>();
            for (int i = 1; i <= nums.Length; i++)
            {
                CombineList(0, i, ls.ToArray(), nums);
            }
            return res;
        }

        private void CombineList(int begin, int k, int[] arr, int[] nums)
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
                CombineList(i + 1, k, ls.ToArray(), nums);
                ls.RemoveAt(ls.Count - 1);
            }
        }

        public List<IList<int>> SubsetsWithDup(int[] nums)
        {
            Array.Sort(nums);
            Dfs(false, 0, nums);
            return res;
        }

        public void Dfs(bool choosePre, int cur, int[] nums)
        {
            if (cur == nums.Length)
            {
                res.Add(new List<int>(tlist));
                System.Diagnostics.Debug.WriteLine(string.Join(",", tlist));
                return;
            }
            Dfs(false, cur + 1, nums);
            if (!choosePre && cur > 0 && nums[cur - 1] == nums[cur])
            {
                return;
            }
            tlist.Add(nums[cur]);
            Dfs(true, cur + 1, nums);
            tlist.RemoveAt(tlist.Count - 1);
        }


    }
}

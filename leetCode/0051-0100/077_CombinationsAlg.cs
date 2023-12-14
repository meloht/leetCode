using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._51_100
{
    public class _77_CombinationsAlg
    {
        public IList<IList<int>> Combine(int n, int k)
        {
            List<IList<int>> res = new List<IList<int>>();
            List<int> ls = new List<int>();
            CombineList(res, 1, n, k, ls.ToArray());
            return res;
        }
        private void CombineList(List<IList<int>> res, int begin, int n, int k, int[] arr)
        {
            if (arr.Length == k)
            {
                res.Add(arr.ToList());
                return;
            }
            List<int> ls = arr.ToList();
            for (int i = begin; i <= n; i++)
            {
                ls.Add(i);
                CombineList(res, i + 1, n, k, ls.ToArray());
                ls.RemoveAt(ls.Count - 1);
            }
        }



    }
}

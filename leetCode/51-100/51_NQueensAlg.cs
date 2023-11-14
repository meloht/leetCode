using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._51_100
{
    public class _51_NQueensAlg
    {
        public IList<IList<string>> SolveNQueens(int n)
        {
            IList<IList<string>> res = new List<IList<string>>();

            int[] arr = new int[n];
            Check(0, n, arr, res);

            return res;
        }

        private void Check(int n, int max, int[] arr, IList<IList<string>> res)
        {
            if (n == max)
            {
                AddResult(res, arr);
                return;
            }
            for (int i = 0; i < max; i++)
            {
                arr[n] = i;
                if (Judge(n, arr))
                {
                    Check(n + 1, max, arr, res);
                }
            }
        }
        private void AddResult(IList<IList<string>> res, int[] arr)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < arr.Length; i++)
            {
                int num = arr[i];
                string ss = "Q".PadLeft(num + 1, '.').PadRight(arr.Length, '.');
                list.Add(ss);
            }
            res.Add(list);
        }

        private bool Judge(int n, int[] arr)
        {
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == arr[n] || Math.Abs(n - i) == Math.Abs(arr[n] - arr[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}

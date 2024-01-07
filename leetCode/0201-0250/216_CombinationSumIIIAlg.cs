using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0201_0250
{
    public class _216_CombinationSumIIIAlg
    {
        int total = 0;
        public IList<IList<int>> CombinationSum3(int k, int n)
        {
            total = n;
            int[] arr = new int[9];
            for (int i = 1; i < 10; i++)
            {
                arr[i - 1] = i;
            }
            var list = GenerateCombinations(arr, k);
            return list;
        }

        private List<IList<int>> GenerateCombinations(int[] arr, int r)
        {
            List<IList<int>> res = new List<IList<int>>();
            int[] data = new int[r];
            GenerateCombinationsUtil(arr, data, 0, arr.Length - 1, 0, r, res);
            return res;
        }

        private void GenerateCombinationsUtil(int[] arr, int[] data, int start, int end, int index, int r, List<IList<int>> res)
        {
            if (index == r)
            {
                int nn = data.Sum();
                if (nn == total)
                {
                    int[] nums = new int[r];
                    Array.Copy(data, nums, r);
                    res.Add(nums);
                }
                return;
            }

            for (int i = start; i <= end && end - i + 1 >= r - index; i++)
            {
                data[index] = arr[i];
                GenerateCombinationsUtil(arr, data, i + 1, end, index + 1, r, res);
            }
        }


        IList<IList<int>> res = new List<IList<int>>();
        IList<int> list = new List<int>();
        int sum = 0;
        public IList<IList<int>> CombinationSum32(int k, int n)
        {
            Backtracking(k, n, 1);
            return res;
        }
        private void Backtracking(int k, int n, int startIndex)
        {
            if (sum > n)
            {
                return;
            }
            if (list.Count == k)
            {
                if (sum == n)
                {
                    res.Add(new List<int>(list));
                }
                return;
            }
            for (int i = startIndex; i <= 9 - (k - list.Count) + 1; i++)
            {
                list.Add(i);
                sum += i;
                Backtracking(k, n, i + 1);
                sum -= i;
                list.Remove(i);
            }
        }

    }
}

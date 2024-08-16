using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3101_3150
{
    public class _3117_MinimumSumOfValuesByDividingArrayAlg
    {
        public int MinimumValueSum(int[] nums, int[] andValues)
        {
            Dictionary<long, int> dict = new Dictionary<long, int>();
            int ans = Dfs(0, 0, -1, nums, andValues, dict);
            return ans < int.MaxValue / 2 ? ans : -1;
        }
        private int Dfs(int i, int j, int and, int[] nums, int[] andValues, Dictionary<long, int> dict)
        {
            int n = nums.Length;
            int m = andValues.Length;

            if (n - i < m - j)
            {
                return int.MaxValue / 2;
            }
            if (j == m)
            {
                return i == n ? 0 : int.MaxValue / 2;
            }

            and &= nums[i];

            long mask = (long)i << 36 | (long)j << 32 | and;
            if (dict.ContainsKey(mask))
            {
                return dict[mask];
            }

            int res = Dfs(i + 1, j, and, nums, andValues, dict);
            if (and == andValues[j])
            {
                res = Math.Min(res, Dfs(i + 1, j + 1, -1, nums, andValues, dict) + nums[i]);
            }
            dict.Add(mask, res);
            return res;
        }

    }
}

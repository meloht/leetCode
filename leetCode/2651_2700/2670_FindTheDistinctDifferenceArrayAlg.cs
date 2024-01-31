using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2651_2700
{
    public class _2670_FindTheDistinctDifferenceArrayAlg
    {
        public int[] DistinctDifferenceArray(int[] nums)
        {
            int[] res = new int[nums.Length];

            int[] suffix = new int[nums.Length];
            HashSet<int> set = new HashSet<int>();
            int len = nums.Length - 1;
            for (int i = len; i >= 1; i--)
            {
                set.Add(nums[i]);
                suffix[i - 1] = set.Count;
            }
            set.Clear();

            for (int i = 0; i <= len; i++)
            {
                set.Add(nums[i]);
                res[i] = set.Count - suffix[i];
            }
            return res;
        }
    }
}

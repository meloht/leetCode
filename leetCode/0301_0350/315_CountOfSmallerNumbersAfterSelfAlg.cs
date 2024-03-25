using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0301_0350
{
    public class _315_CountOfSmallerNumbersAfterSelfAlg
    {
        public IList<int> CountSmaller(int[] nums)
        {
            int[] arr = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                arr[i] = nums[i];
            }
            Array.Sort(arr);

            int[] res = new int[arr.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                int index = Array.BinarySearch(arr, nums[i]);
                int num = Math.Abs(i - index);
                res[index] = num;
            }

            return res;
        }

    }
}

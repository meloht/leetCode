using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0301_0350
{
    public class _303_RangeSumQueryImmutableAlg
    {
        public class NumArray
        {
            int[] arr;
            public NumArray(int[] nums)
            {
                arr = new int[nums.Length];
                arr[0] = nums[0];
                for (int i = 1; i < nums.Length; i++)
                {
                    arr[i] = arr[i - 1] + nums[i];
                }
            }

            public int SumRange(int left, int right)
            {
                if (left == 0)
                {
                    return arr[right];
                }
                int num = arr[right] - arr[left - 1];
                return num;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0151_0200
{
    public class _154_FindMinimumInRotatedSortedArrayIIAlg
    {
        public int FindMin1(int[] nums)
        {
            int min = int.MaxValue;
            foreach (int i in nums)
            {
                min = Math.Min(min, i);
            }
            return min;
        }

        public int FindMin(int[] nums)
        {
            int low = 0;
            int high = nums.Length - 1;
            while (low < high)
            {
                int pivot = low + (high - low) / 2;
                if (nums[pivot] < nums[high])
                {
                    high = pivot;
                }
                else if (nums[pivot] > nums[high])
                {
                    low = pivot + 1;
                }
                else
                {
                    high--;
                }
            }
            return nums[low];
        }
    }
}

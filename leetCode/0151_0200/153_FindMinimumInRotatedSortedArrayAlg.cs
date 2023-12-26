using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0151_0200
{
    public class _153_FindMinimumInRotatedSortedArrayAlg
    {
        public int FindMin1(int[] nums)
        {
            if (nums.Length == 1)
                return nums[0];
            if (nums[nums.Length - 1] > nums[0])
                return nums[0];

            int left = 0, right = nums.Length - 1;
            int len = nums.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                int l = mid - 1;
                int r = mid + 1;
                if (mid == len && l >= 0)
                {
                    if (nums[mid] < nums[l])
                        return nums[mid];
                }
                else if (l >= 0 && r <= len && nums[mid] < nums[l] && nums[mid] < nums[r])
                {
                    return nums[mid];
                }
                else if (l >= 0 && r <= len && nums[mid] > nums[l] && nums[mid] > nums[r])
                {
                    return nums[r];
                }
                else if (r == len && nums[mid] > nums[r])
                {
                    return nums[r];
                }

                if (nums[mid] >= nums[0])
                {
                    left = mid + 1;
                }
                else if (nums[mid] <= nums[len])
                {
                    right = mid - 1;
                }



            }
            return 0;
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
                else
                {
                    low = pivot + 1;
                }
            }
            return nums[low];
        }


    }
}

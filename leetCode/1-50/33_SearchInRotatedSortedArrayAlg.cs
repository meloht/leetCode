using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._1_50
{
    public class SearchInRotatedSortedArrayAlg
    {
        public int Search(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
                return -1;

            int left = 0; // 左边界
            int right = nums.Length - 1; // 右边界
   
            while (left <= right)
            {
                int mid = left + (right - left) / 2; // 中间索引

                if (nums[mid] == target)
                {
                    return mid;
                }

                if (nums[mid] > nums[right])
                {
                    if (target >= nums[left] && target < nums[mid])
                    {
                        int index = BinarySearch(nums, left, mid, target);
                        if (index != -1)
                        {
                            return index;
                        }
                    }

                    left = mid + 1;
                }
                else
                {
                    if (target > nums[mid] && target <= nums[right])
                    {
                        int index = BinarySearch(nums, mid, right, target);
                        if (index != -1)
                        {
                            return index;
                        }
                    }
                   
                    right = mid - 1;

                }



            }
            return -1;

        }


        public int BinarySearch(int[] array, int left, int right, int target)
        {
            while (left <= right)
            {
                int mid = (right + left) / 2; // 中间索引

                if (array[mid] == target)
                {
                    return mid; // 找到目标值，返回索引
                }
                else if (array[mid] < target)
                {
                    left = mid + 1; // 目标在右半部分
                }
                else
                {
                    right = mid - 1; // 目标在左半部分
                }
            }

            return -1; // 目标值不在数组中
        }

    }
}

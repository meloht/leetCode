using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._51_100
{
    public class _81_SearchInRotatedSortedArrayIIAlg
    {
        public bool Search(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
                return false;
            var list = nums.Distinct().ToArray();
            int left = 0; // 左边界
            int right = list.Length - 1; // 右边界

            while (left <= right)
            {
                int mid = left + (right - left) / 2; // 中间索引

                if (list[mid] == target)
                {
                    return true;
                }

                if (list[mid] > list[right])
                {
                    if (target >= list[left] && target < list[mid])
                    {
                        int index = BinarySearch(list, left, mid, target);
                        if (index != -1)
                        {
                            return true;
                        }
                    }

                    left = mid + 1;
                }
                else
                {
                    if (target > list[mid] && target <= list[right])
                    {
                        int index = BinarySearch(list, mid, right, target);
                        if (index != -1)
                        {
                            return true;
                        }
                    }

                    right = mid - 1;

                }
            }
            return false;

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

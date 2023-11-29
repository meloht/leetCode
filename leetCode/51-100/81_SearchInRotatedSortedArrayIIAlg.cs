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
            nums = nums.Distinct().ToArray();
            int left = 0; // 左边界
            int right = nums.Length - 1; // 右边界

            while (left <= right)
            {
                int mid = left + (right - left) / 2; // 中间索引

                if (nums[mid] == target)
                {
                    return true;
                }

                if (nums[mid] > nums[right])
                {
                    if (target >= nums[left] && target < nums[mid])
                    {
                        int index = BinarySearch(nums, left, mid, target);
                        if (index != -1)
                        {
                            return true;
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
        public bool Search2(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
                return false;

            int left = 0; // 左边界
            int right = nums.Length - 1; // 右边界

            bool bl = BinarySearchDi(nums, left, right, target);
            return bl;
        }

        private bool BinarySearchDi(int[] nums, int left, int right, int target)
        {
            if (left == right)
            {
                if (nums[left] == target)
                    return true;
                return false;
            }
            if (nums[left] == target || nums[right] == target)
            {
                return true;
            }
            int mid = (right + left) / 2;
            if (nums[mid] == target)
            {
                return true;
            }
            int midleft = GetLeftIndex(nums, left, mid);
            int newRight = GetRightIndex(nums, midleft, mid);

            bool bl = BinarySearchDi(nums, midleft, newRight, target);
            if (bl)
            {
                return true;
            }
            else
            {
                int midLeft2 = GetLeftIndex(nums, mid, right);
                int newRight2 = GetRightIndex(nums, midLeft2, right);
                bl = BinarySearchDi(nums, midLeft2, newRight2, target);
                if (bl)
                {
                    return true;
                }
            }
            return false;
        }

        private int GetLeftIndex(int[] nums, int left, int right)
        {
            int index = left;
            for (int i = left + 1; i <= right; i++)
            {
                if (nums[i] == nums[i - 1])
                {
                    index = i;
                }
                else
                {
                    break;
                }

            }
            return index;
        }
        private int GetRightIndex(int[] nums, int left, int right)
        {
            int index = right;
            for (int i = right - 1; i >= left; i--)
            {
                if (nums[i] == nums[i + 1])
                {
                    index = i;
                }
                else
                {
                    break;
                }

            }
            return index;
        }
    }
}

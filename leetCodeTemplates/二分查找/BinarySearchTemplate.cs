using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCodeTemplates.BinarySearch
{
    public class BinarySearchTemplate
    {
        public int BinarySearch(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            while (left <= right)
            {
                int mid = (right - left) / 2 + left;
                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }

            }

            return -1;
        }

        /// <summary>
        /// 大于target
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int BinarySearchLeft2(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            while (left < right)
            {
                int mid = (right - left) / 2 + left;
                if (nums[mid] <= target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }

            }

            return nums[right];
        }
        public int BinarySearchLeft(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            int ans = 0;
            while (left <= right)
            {
                int mid = (right - left) / 2 + left;
                if (nums[mid] <= target)
                {
                    left = mid + 1;
                }
                else
                {
                    ans = nums[mid];
                    right = mid - 1;
                }

            }

            return ans;
        }

        /// <summary>
        /// 小于target
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int BinarySearchRight(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            int ans = 0;
            while (left <= right)
            {
                int mid = (right - left) / 2 + left;
                if (nums[mid] < target)
                {
                    left = mid + 1;
                    ans = nums[mid];
                }
                else
                {
                    right = mid - 1;
                }

            }

            return ans;
        }


        /// <summary>
        /// 返回<=target  [981]
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>

        private int BinarySearch1(int[] nums, int target)
        {
            int low = 0, high = nums.Length - 1;
            if (high < 0 || target > nums[high])
            {
                return high + 1;
            }
            while (low < high)
            {
                int mid = (high - low) / 2 + low;
                int val = nums[mid];
                if (val <= target)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid;
                }
            }
            return low;
        }

        /// <summary>
        /// 返回最小满足num[i]>=target 的i， 如果不存在，返回len(nums)  循环结束后right+1 =left
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>

        public int BinarySearchLowerBound(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                int mid = (right - left) / 2 + left;

                if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return nums[left];
        }

        public int BinarySearchLowerBound1(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left < right)
            {
                int mid = (right - left) / 2 + left;

                if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }
            return nums[left];
        }



        /// <summary>
        /// 大于target的最小值
        /// </summary>
        /// <param name="list"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        private int LeftBinarySearch(List<int> list, int target)
        {
            int left = 0;
            int right = list.Count - 1;
            int ans = list.Count;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (list[mid] <= target)
                {
                    left = mid + 1;
                }
                else
                {
                    ans = mid;
                    right = mid - 1;
                }
            }
            return ans;
        }
        /// <summary>
        /// 小于target的最大值
        /// </summary>
        /// <param name="list"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        private int RightBinarySearch(List<int> list, int target)
        {
            int left = 0;
            int right = list.Count - 1;
            int ans = 0;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (list[mid] < target)
                {
                    ans = mid;
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return ans;
        }

        /// <summary>
        /// 通过调整二分查找条件，记录最后一次满足 nums[mid] <= target 的位置。
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int FindLastLessOrEqual(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            int result = -1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] <= target)
                {
                    result = mid;    // 记录候选位置
                    left = mid + 1;  // 继续向右查找更靠后的可能值
                }
                else
                {
                    right = mid - 1; // 中间值过大，向左缩小范围
                }
            }
            return result;
        }
        /// <summary>
        /// UpperBound 函数（第一个大于目标值的位置），其减一即为最后一个小于等于的位置。
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int UpperBound(int[] nums, int target)
        {
            int left = 0, right = nums.Length;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] <= target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }
            return left; // 返回第一个大于target的位置
        }

        // 通过UpperBound计算最后一个<=target的位置
        public int FindLastLessOrEqual11(int[] nums, int target)
        {
            int upper = UpperBound(nums, target);
            return upper - 1; // 第一个大于的位置减一即为最后一个<=的位置
        }

        // 实现 low bound，返回第一个不小于 target 的元素的索引
        public static int LowerBound11(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length;

            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (arr[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }
            return left;
        }

        // 实现 upper bound，返回第一个大于 target 的元素的索引
        public static int UpperBound11(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length;

            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (arr[mid] <= target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }
            return left;
        }
    }
}

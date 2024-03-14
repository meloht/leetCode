﻿using System;
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


    }
}

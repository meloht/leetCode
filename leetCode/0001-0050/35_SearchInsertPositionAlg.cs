using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._1_50
{
    public class SearchInsertPositionAlg
    {
        public int SearchInsert(int[] nums, int target)
        {
            int left = 0; // 左边界
            int right = nums.Length - 1; // 右边界

            bool isLeft = false;
            while (left <= right)
            {
                int mid = (right + left) / 2; // 中间索引

                if (nums[mid] == target)
                {
                    return mid; // 找到目标值，返回索引
                }
                else if (nums[mid] < target)
                {
                    left = mid + 1; // 目标在右半部分

                    isLeft = true;
                }
                else
                {
                    right = mid - 1; // 目标在左半部分

                    isLeft = false;
                }
            }
            if (isLeft == false)
            {
                return right + 1;
            }
            else
            {
                return left;
            }
        }

        public int SearchInsert1(int[] nums, int target)
        {
            int n = nums.Length;
            int left = 0, right = n - 1, ans = n;
            while (left <= right)
            {
                int mid = ((right - left) >> 1) + left;
                if (target <= nums[mid])
                {
                    ans = mid;
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return ans;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1_50
{
    public class FindFirstAndLastPositionOfElementInSortedArrayAlg
    {
        public int[] SearchRange(int[] nums, int target)
        {
            int[] result = { -1, -1 };

            // 查找目标值的起始位置
            int left = 0, right = nums.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] == target)
                {
                    result[0] = mid;
                    right = mid - 1; // 继续查找左边的子数组
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

            // 如果起始位置没找到，说明目标值不存在
            if (result[0] == -1)
            {
                return result;
            }

            // 查找目标值的结束位置
            left = result[0];
            right = nums.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] == target)
                {
                    result[1] = mid;
                    left = mid + 1; // 继续查找右边的子数组
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

            return result;
        }
    }
}

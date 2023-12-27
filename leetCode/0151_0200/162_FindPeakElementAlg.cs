using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0151_0200
{
    public class _162_FindPeakElementAlg
    {
        public int FindPeakElement1(int[] nums)
        {
            if (nums.Length == 1)
                return 0;

            int len = nums.Length - 1;
            for (int i = 1; i < len; i++)
            {
                int prev = nums[i - 1];
                int curr = nums[i];
                int next = nums[i + 1];
                if (curr > prev && curr > next)
                {
                    return i;
                }
            }
            if (nums[0] > nums[len])
            {
                return 0;
            }
            return len;
        }

        public int FindPeakElement(int[] nums)
        {
            int n = nums.Length;
            int left = 0, right = n - 1, ans = -1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (Compare(nums, mid - 1, mid) < 0 && Compare(nums, mid, mid + 1) > 0)
                {
                    ans = mid;
                    break;
                }
                if (Compare(nums, mid, mid + 1) < 0)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return ans;
        }

        // 辅助函数，输入下标 i，返回一个二元组 (0/1, nums[i])
        // 方便处理 nums[-1] 以及 nums[n] 的边界情况
        public int[] Get(int[] nums, int idx)
        {
            if (idx == -1 || idx == nums.Length)
            {
                return new int[] { 0, 0 };
            }
            return new int[] { 1, nums[idx] };
        }

        public int Compare(int[] nums, int idx1, int idx2)
        {
            int[] num1 = Get(nums, idx1);
            int[] num2 = Get(nums, idx2);
            if (num1[0] != num2[0])
            {
                return num1[0] > num2[0] ? 1 : -1;
            }
            if (num1[1] == num2[1])
            {
                return 0;
            }
            return num1[1] > num2[1] ? 1 : -1;
        }

        public int FindPeakElement3(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] < nums[mid + 1])
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0251_0300
{
    public class _287_FindTheDuplicateNumberAlg
    {
        public int FindDuplicate1(int[] nums)
        {
            Array.Sort(nums);
            for (int i = 1; i < nums.Length; i++)
            {
                int prev = nums[i - 1];
                int curr = nums[i];
                if (prev == curr)
                    return prev;
            }
            return 0;
        }

        public int FindDuplicate3(int[] nums)
        {
            int left = 1;
            int right = nums.Length - 1;
            while (left < right)
            {
                int mid = (right - left) / 2 + left;
                int count = nums.Count(p => p <= mid);
                if (count <= mid)
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

        public int FindDuplicate(int[] nums)
        {
            int left = 1;
            int right = nums.Length - 1;
            int res = -1;
            while (left <= right)
            {
                int mid = (right - left) / 2 + left;

                res = mid;
                int count = nums.Count(p => p <= mid);
                if (count <= mid)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }

            }
            return left;
        }

        public int FindDuplicate2(int[] nums)
        {
            int slow = 0;
            int fast = 0;
            slow = nums[slow];
            fast = nums[nums[fast]];
            while (slow != fast)
            {
                slow = nums[slow];
                fast = nums[nums[fast]];
            }
            slow = 0;
            while (slow != fast)
            {
                slow = nums[slow];
                fast = nums[fast];
            }
            return slow;
        }
    }
}

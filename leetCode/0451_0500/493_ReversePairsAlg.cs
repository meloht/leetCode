using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0451_0500
{
    public class _493_ReversePairsAlg
    {
        public int ReversePairs(int[] nums)
        {
            Array.Sort(nums);
            int ans = 0;

            for (int i = 0; i < nums.Length - 2; i++)
            {
                int target = nums[i] * 2;
                if (target >= nums[nums.Length - 1])
                {
                    return ans;
                }
                int idx = BinarySearch(nums, i + 1, target);
                if (nums[idx] > nums[i] * 2)
                {
                    ans += (nums.Length - idx);
                }
            }

            return ans;
        }

        private int BinarySearch(int[] nums, int left, int target)
        {
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
            return right;
        }
    }
}

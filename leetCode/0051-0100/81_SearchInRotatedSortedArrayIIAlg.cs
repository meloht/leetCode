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
            int n = nums.Length;
            if (n == 0)
            {
                return false;
            }
            if (n == 1)
            {
                return nums[0] == target;
            }
            int l = 0, r = n - 1;
            while (l <= r)
            {
                if (nums[l] != target)
                {
                    l = GetLeftIndex(nums, l, r);
                }
                else
                {
                    return true;
                }
                if (nums[r] != target)
                {
                    r = GetRightIndex(nums, l, r);
                }
                else
                {
                    return true;
                }
                int mid = (l + r) / 2;
                if (nums[mid] == target)
                {
                    return true;
                }
                if (nums[0] <= nums[mid])
                {
                    if (nums[0] <= target && target < nums[mid])
                    {
                        int temp = GetRightIndex(nums, l, mid);
                        r = temp - 1;
                    }
                    else
                    {
                        int temp = GetLeftIndex(nums, mid, r);
                        l = temp + 1;
                    }
                }
                else
                {
                    if (nums[mid] < target && target <= nums[n - 1])
                    {
                        int temp = GetLeftIndex(nums, mid, r);
                        l = temp + 1;
                    }
                    else
                    {
                        int temp = GetRightIndex(nums, l, mid);
                        r = temp - 1;
                    }
                }
            }
            return false;
        }

        private int GetLeftIndex(int[] nums, int left, int right)
        {
            int index = left;
            for (int i = left + 1; i <= right; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    index = i - 1;
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
                if (nums[i] != nums[i + 1])
                {
                    index = i + 1;
                    break;
                }
            }
            return index;
        }


    }
}

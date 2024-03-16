using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0501_0550
{
    public class _540_SingleElementInASortedArrayAlg
    {
        public int SingleNonDuplicate(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;
            while (left <= right)
            {
                int mid = (right - left) / 2 + left;

                int low = mid - 1;
                int high = mid + 1;
                if (low >= 0 && nums[mid] == nums[low])
                {
                    if ((mid + 1) % 2 == 0)
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 2;
                    }
                }
                else if (high < nums.Length && nums[mid] == nums[high])
                {
                    if ((mid + 2) % 2 == 0)
                    {
                        left = mid + 2;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
                else
                {
                    return nums[mid];
                }
            }

            return -1;
        }

        /// <summary>
        /// mid是偶数 mid+1=mid^1，mid是奇数 mid-1=mid^1
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>

        public int SingleNonDuplicate1(int[] nums)
        {
            int low = 0, high = nums.Length - 1;
            while (low < high)
            {
                int mid = (high - low) / 2 + low;
                if (nums[mid] == nums[mid ^ 1])
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid;
                }
            }
            return nums[low];
        }

        /// <summary>
        ///  mid是偶数 mid&1=0，mid是奇数 mid&1=1
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int SingleNonDuplicate2(int[] nums)
        {
            int low = 0, high = nums.Length - 1;
            while (low < high)
            {
                int mid = (high - low) / 2 + low;
                mid -= mid & 1;
                if (nums[mid] == nums[mid + 1])
                {
                    low = mid + 2;
                }
                else
                {
                    high = mid;
                }
            }
            return nums[low];
        }


    }
}

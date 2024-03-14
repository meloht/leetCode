using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0401_0450
{
    public class _436_FindRightIntervalAlg
    {
        public int[] FindRightInterval(int[][] intervals)
        {
            int[][] nums = new int[intervals.Length][];
            for (int i = 0; i < intervals.Length; i++)
            {
                nums[i] = [intervals[i][0], intervals[i][1], i];
            }
            Array.Sort(nums, (x, y) => x[0].CompareTo(y[0]));

            int[] result = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {

                int left = i + 1;
                int begin = nums[i][0];
                int end = nums[i][1];
                int right = nums.Length - 1;
                int index = -1;
                while (left <= right)
                {
                    int mid = (left + right) / 2;
                    if (nums[mid][0] >= end)
                    {
                        right = mid - 1;

                        index = mid;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }

                if (index != -1)
                {
                    result[nums[i][2]] = nums[index][2];
                }
                else
                {
                    result[nums[i][2]] = -1;
                }

            }

            return result;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2551_2600
{
    public class _2563_CountTheNumberOfFairPairsAlg
    {
        public long CountFairPairs(int[] nums, int lower, int upper)
        {
            Array.Sort(nums);

            long ans = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int val = nums[i];
                int t1 = lower - val;
                int t2 = upper - val;
                int idx1 = GetIndex(nums, i + 1, t1);
                if (idx1 == -1)
                    continue;

                int idx2 = GetIndex2(nums, idx1, t2);
                if (idx2 == -1)
                    continue;

                ans += (idx2 - idx1 + 1);
            }

            return ans;
        }

        private int GetIndex(int[] nums, int left, int t)
        {
            int right = nums.Length - 1;
            int result = -1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] < t)
                {
                    left = mid + 1;  // 继续向右查找更靠后的可能值
                }
                else
                {
                    result = mid;
                    right = mid - 1; // 中间值过大，向左缩小范围
                }
            }
            return result;
        }

        private int GetIndex2(int[] nums, int left, int t)
        {
            int right = nums.Length - 1;
            int result = -1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] <= t)
                {
                    result = mid;
                    left = mid + 1;  // 继续向右查找更靠后的可能值
                }
                else
                {

                    right = mid - 1; // 中间值过大，向左缩小范围
                }
            }
            return result;
        }
    }
}

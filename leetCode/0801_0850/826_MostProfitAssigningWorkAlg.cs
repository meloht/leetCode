using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0801_0850
{
    public class _826_MostProfitAssigningWorkAlg
    {
        public int MaxProfitAssignment(int[] difficulty, int[] profit, int[] worker)
        {
            int ans = 0;
            int[][] nums = new int[difficulty.Length][];

            for (int i = 0; i < difficulty.Length; i++)
            {
                nums[i] = [difficulty[i], profit[i]];
            }
            Array.Sort(nums, (x, y) => x[0].CompareTo(y[0]));
            int max = nums[0][1];
            for (int i = 1; i < difficulty.Length; i++)
            {
                max = Math.Max(max, nums[i][1]);
                nums[i][1] = max;

            }

            foreach (var item in worker)
            {
                int index = BinarySearchRight(nums, item);
                ans += index;
            }
            return ans;
        }

        public int BinarySearchRight(int[][] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            if (target >= nums[right][0])
            {
                return nums[right][1];
            }
            if (target < nums[0][0])
            {
                return 0;
            }
            int ans = 0;
            while (left <= right)
            {
                int mid = (right - left) / 2 + left;
                if (nums[mid][0] <= target)
                {
                    left = mid + 1;
                    ans = nums[mid][1];
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

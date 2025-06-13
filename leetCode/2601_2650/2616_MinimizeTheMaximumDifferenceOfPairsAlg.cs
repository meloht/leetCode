using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._2601_2650
{
    public class _2616_MinimizeTheMaximumDifferenceOfPairsAlg
    {
        public int MinimizeMax(int[] nums, int p)
        {
            Array.Sort(nums);
            int left = -1;
            int right = nums[nums.Length - 1] - nums[0];
            while (left + 1 < right)
            {
                int mid = (left + right) >>> 1;
                if (check(mid, nums, p))
                {
                    right = mid;
                }
                else
                {
                    left = mid;
                }
            }
            return right;
        }

        private bool check(int mx, int[] nums, int p)
        {
            int cnt = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i + 1] - nums[i] <= mx)
                { // 选 nums[i] 和 nums[i+1]
                    cnt++;
                    i++;
                }
            }
            return cnt >= p;
        }


    }
}

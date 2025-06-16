using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2001_2050
{
    public class _2016_MaximumDifferenceBetweenIncreasingElementsAlg
    {
        public int MaximumDifference1(int[] nums)
        {
            int left = int.MaxValue;
            int right = 0;
            int[] arr = new int[nums.Length];

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                arr[i] = Math.Max(nums[i], right);
                right = arr[i];
            }
            int ans = -1;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                left = Math.Min(left, nums[i]);
                if (left < arr[i + 1])
                {
                    ans=Math.Max(ans, arr[i + 1]-left);
                }

            }

            return ans;
        }

        public int MaximumDifference(int[] nums)
        {
            int n = nums.Length;
            int ans = -1, premin = nums[0];
            for (int i = 1; i < n; ++i)
            {
                if (nums[i] > premin)
                {
                    ans = Math.Max(ans, nums[i] - premin);
                }
                else
                {
                    premin = nums[i];
                }
            }
            return ans;
        }


    }
}

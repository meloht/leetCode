using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2901_2950
{
    public class _2908_MinimumSumOfMountainTripletsIAlg
    {
        public int MinimumSum1(int[] nums)
        {
            int ans = int.MaxValue;

            for (int i = 0; i < nums.Length - 2; i++)
            {
                int c1 = nums[i];
                for (int j = i + 1; j < nums.Length - 1; j++)
                {
                    int c2 = nums[j];
                    if (c2 <= c1)
                        continue;
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        int c3 = nums[k];
                        if (c3 >= c2)
                            continue;
                        ans = Math.Min(c1 + c2 + c3, ans);
                    }
                }
            }
            if (ans == int.MaxValue)
                return -1;
            return ans;
        }

        public int MinimumSum(int[] nums)
        {
            int ans = int.MaxValue;
            int leftMin = int.MaxValue;
            int len = nums.Length;
            int[] left = new int[len];
            for (int i = 1; i < len; i++)
            {
                leftMin = Math.Min(nums[i - 1], leftMin);
                left[i] = leftMin;
            }
            int right = nums[len - 1];
            for (int i = len - 2; i > 0; i--)
            {
                if (left[i] < nums[i] && nums[i] > right)
                {
                    ans = Math.Min(ans, left[i] + nums[i] + right);
                }
                right = Math.Min(right, nums[i]);
            }
            if (ans == int.MaxValue)
                return -1;
            return ans;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0551_0600
{
    public class _581_ShortestUnsortedContinuousSubarrayAlg
    {
        public int FindUnsortedSubarray(int[] nums)
        {

            List<int> list = new List<int>(nums);
            list.Sort();
            int end = nums.Length - 1;
            for (int i = 0, j = end; i < j;)
            {
                if (nums[i] != list[i] && nums[j] != list[j])
                {
                    return j - i + 1;
                }
                if (nums[i] == list[i])
                {
                    i++;
                }
                if (nums[j] == list[j])
                {
                    j--;
                }
            }

            return 0;
        }

        public int FindUnsortedSubarray1(int[] nums)
        {
            int n = nums.Length;
            int maxn = int.MinValue, right = -1;
            int minn = int.MaxValue, left = -1;
            for (int i = 0; i < n; i++)
            {
                if (maxn > nums[i])
                {
                    right = i;
                }
                else
                {
                    maxn = nums[i];
                }
                if (minn < nums[n - i - 1])
                {
                    left = n - i - 1;
                }
                else
                {
                    minn = nums[n - i - 1];
                }
            }
            return right == -1 ? 0 : right - left + 1;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1_50
{
    internal class ThreeSumClosestAlg
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
                return 0;

            if (nums.Length < 3)
                return 0;

            int len = nums.Length;
            Array.Sort(nums);

            int result = 0;
            int abs = int.MaxValue;

            for (int i = 0; i < len; i++)
            {
                int left = i + 1;
                int right = len - 1;

                while (left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];
                    int res = sum - target;
                    int temp = Math.Abs(res);

                    if (temp < abs)
                    {
                        abs = temp;
                        result = sum;

                        if (res > 0)
                        {
                            right--;
                        }
                        else if (res < 0)
                        {
                            left++;
                        }
                        else if (res == 0)
                        {
                            break;
                        }

                    }
                    else
                    {
                        if (res > 0)
                        {
                            right--;
                        }
                        else if (res < 0)
                        {
                            left++;
                        }
                        else if (res == 0)
                        {
                            break;
                        }
                    }

                }
            }
            return result;
        }
    }
}

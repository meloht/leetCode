using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2751_2800
{
    public class _2765_LongestAlternatingSubarrayAlg
    {
        public int AlternatingSubarray(int[] nums)
        {
            int pre = int.MaxValue;
            int max = -1;
            int count = -1;
            for (int i = 1; i < nums.Length; i++)
            {
                int prev = nums[i - 1];
                int curr = nums[i];
                int diff = curr - prev;
                if (i == 1)
                {
                    if (diff == 1)
                    {
                        count = 2;
                        max = Math.Max(max, count);
                    }
                }
                else
                {
                    if (pre == 1)
                    {
                        if (diff == -1)
                        {
                            count++;
                            max = Math.Max(max, count);
                        }
                        else if (diff == 1)
                        {
                            count = 2;
                            max = Math.Max(max, count);
                        }
                        else
                        {
                            count = -1;
                        }
                    }
                    else if (pre == -1)
                    {
                        if (count > 0 && diff == 1)
                        {
                            count++;
                            max = Math.Max(max, count);
                        }
                        else if (diff == 1)
                        {
                            count = 2;
                            max = Math.Max(max, count);
                        }
                        else
                        {
                            count = -1;
                        }
                    }
                    else
                    {
                        if (diff == 1)
                        {
                            count = 2;
                            max = Math.Max(max, count);
                        }
                        else
                        {
                            count = -1;
                        }

                    }
                }

                pre = diff;
            }

            return max;
        }

        public int AlternatingSubarray1(int[] nums)
        {
            int res = -1;
            int n = nums.Length;
            int firstIndex = 0;
            for (int i = 1; i < n; i++)
            {
                int length = i - firstIndex + 1;
                if (nums[i] - nums[firstIndex] == (length - 1) % 2)
                {
                    res = Math.Max(res, length);
                }
                else
                {
                    if (nums[i] - nums[i - 1] == 1)
                    {
                        firstIndex = i - 1;
                        res = Math.Max(res, 2);
                    }
                    else
                    {
                        firstIndex = i;
                    }
                }
            }
            return res;
        }


    }
}

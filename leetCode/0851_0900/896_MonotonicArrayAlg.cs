using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0851_0900
{
    public class _896_MonotonicArrayAlg
    {
        public bool IsMonotonic1(int[] nums)
        {
            if (nums.Length <= 1)
                return true;
            int num = 0;
            if (nums[1] > nums[0])
            {
                num = 1;
            }
            else if (nums[1] < nums[0])
            {
                num = -1;
            }
            else
            {
                num = 0;
            }
            for (int i = 2; i < nums.Length; i++)
            {
                int prev = nums[i - 1];
                int curr = nums[i];
                if (num == 1)
                {
                    if (curr < prev)
                        return false;
                }
                else if (num == -1)
                {
                    if (curr > prev)
                        return false;
                }
                else
                {
                    if (curr > prev)
                    {
                        num = 1;
                    }
                    else if (curr < prev)
                    {
                        num = -1;
                    }
                    else
                    {
                        num = 0;
                    }

                }
            }
            return true;
        }

        public bool IsMonotonic(int[] nums)
        {
            if (nums.Length <= 1)
                return true;

            int n = nums.Length;
            bool bl = false;
            bool flag = false;
            for (int i = 1; i < n; i++)
            {
                int prev = nums[i - 1];
                int curr = nums[i];
                if (flag == false)
                {
                    if (curr > prev)
                    {
                        bl = true;
                        flag = true;
                    }
                    else if (curr < prev)
                    {
                        bl = false;
                        flag = true;
                    }
                }
                else
                {
                    if (bl)
                    {
                        if (curr < prev)
                            return false;
                    }
                    else
                    {
                        if (curr > prev)
                            return false;
                    }
                }
            }

            return true;
        }
    }
}

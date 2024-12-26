using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._0651_0700
{
    public class _665_NonDecreasingArrayAlg
    {
        public bool CheckPossibility(int[] nums)
        {
            int ans = 0;
            int idx = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i - 1] > nums[i])
                {
                    ans++;
                    idx = i;
                }
                if (ans > 1)
                {
                    return false;
                }
                
            }
           
            if (ans == 0)
            {
                return true;
            }

            if (idx == nums.Length - 1 || idx == 1)
                return true;

            if (nums[idx + 1] >= nums[idx - 1])
            {
                return true;
            }

            if (idx -2 >= 0 && nums[idx - 2] <= nums[idx])
            {
                return true;
            }
           

            return false;
        }

        public bool CheckPossibility1(int[] nums)
        {
            int n = nums.Length, cnt = 0;
            for (int i = 0; i < n - 1; ++i)
            {
                int x = nums[i], y = nums[i + 1];
                if (x > y)
                {
                    cnt++;
                    if (cnt > 1)
                    {
                        return false;
                    }
                    if (i > 0 && y < nums[i - 1])
                    {
                        nums[i + 1] = x;
                    }
                }
            }
            return true;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1401_1450
{
    public class _1437_CheckIfAll1sAreAtLeastLengthkPlacesAwayAlg
    {
        public bool KLengthApart(int[] nums, int k)
        {
            int cnt = 0;
            bool bl = true;
            for (int i = 0; i < nums.Length; i++)
            {
                if (bl && nums[i] == 1)
                {
                    bl = false;
                }
                else
                {
                    if (!bl)
                    {
                        if (nums[i] == 1)
                        {
                            if (cnt < k )
                                return false;
                            cnt = 0;
                        }
                        else
                        {
                            cnt++;
                        }
                    }
                  
                }
               
            }
            return true;
        }

        public bool KLengthApart1(int[] nums, int k)
        {
            int n = nums.Length;
            int prev = -1;
            for (int i = 0; i < n; ++i)
            {
                if (nums[i] == 1)
                {
                    if (prev != -1 && i - prev - 1 < k)
                    {
                        return false;
                    }
                    prev = i;
                }
            }
            return true;
        }

    }
}

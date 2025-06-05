using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1001_1050
{
    public class _1004_MaxConsecutiveOnesIIIAlg
    {
        public int LongestOnes(int[] nums, int k)
        {
            int cnt1 = 0;
            int cnt0 = 0;
            int ans = 0;
            for (int i = 0, j = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    cnt0++;
                }
                else
                {
                    cnt1++;
                }
                if (cnt0 > k)
                {
                    while (cnt0 > k && j < nums.Length)
                    {
                        if (nums[j] == 0)
                        {
                            cnt0--;
                        }
                        else
                        {
                            cnt1--;
                        }
                        j++;
                    }
                }
                ans = Math.Max(ans, cnt0 + cnt1);
            }
            return ans;
        }
    }
}

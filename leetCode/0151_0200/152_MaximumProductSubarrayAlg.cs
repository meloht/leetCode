using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0151_0200
{
    public class _152_MaximumProductSubarrayAlg
    {
        public int MaxProduct(int[] nums)
        {
            if (nums.Length == 1)
                return nums[0];
            int pre = nums[0];
            int max = pre;
            int len = nums.Length;
           
            int maxMinus = 0;
            if (nums[0] < 0)
            {
                maxMinus = nums[0];
            }
            for (int i = 1; i < len; i++)
            {
                int curr = nums[i];
                if (curr == 0)
                {
                    maxMinus = 0;
                    pre = 0;
                    max = Math.Max(max, pre);
                }
                else if (curr < 0)
                {
                    int newMinus = curr;
                    int numAdd = curr * pre;
                    if (pre > 0)
                    {
                        newMinus = numAdd;
                    }
                    if (maxMinus != 0)
                    {
                        int nn = maxMinus * curr;
                        pre = Math.Max(curr, numAdd);
                        pre = Math.Max(pre, nn);

                    }
                    else
                    {
                        pre = Math.Max(numAdd, curr);
                    }

                    max = Math.Max(max, pre);
                    maxMinus = newMinus;
                }
                else if (curr > 0)
                {
                    if (maxMinus != 0)
                    {
                        maxMinus = maxMinus * curr;
                    }
                    pre = Math.Max(curr, pre * curr);
                    max = Math.Max(max, pre);
                }

            }
            return max;
        }
    }
}

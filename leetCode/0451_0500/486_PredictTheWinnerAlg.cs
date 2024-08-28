using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0451_0500
{
    public class _486_PredictTheWinnerAlg
    {
        public bool PredictTheWinner(int[] nums)
        {
            int a = 0;
            int b = 0;
            bool flag = true;
            for (int i = 0, j = nums.Length - 1; i < j; )
            {
                if (flag)
                {
                    if (nums[i] > nums[j])
                    {
                        a += nums[i];
                        i++;
                    }
                    else
                    {
                        a += nums[j];
                        j--;
                    }
                    if (i == j)
                    {
                        b += nums[i];
                        break;
                    }
                }
                else
                {
                    if (nums[i] > nums[j])
                    {
                        b += nums[i];
                        i++;
                    }
                    else
                    {
                        b += nums[j];
                        j--;
                    }
                    if (i == j)
                    {
                        a += nums[i];
                        break;
                    }
                }
                flag = !flag;
            }
            

            return a > b || a == b;
        }
    }
}

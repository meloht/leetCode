using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0951_1000
{
    public class _0985_SumOfEvenNumbersAfterQueriesAlg
    {
        public int[] SumEvenAfterQueries(int[] nums, int[][] queries)
        {
            int sum = 0;
            foreach (var item in nums)
            {
                if (item % 2 == 0)
                {
                    sum += item;
                }
            }
            int[] ans= new int[nums.Length];
            int i = 0;
            foreach (var item in queries)
            {
                int idx = item[1];
                int val = item[0]+ nums[idx];
                bool bl = val % 2 == 0;
                if (nums[idx] % 2 == 0)
                {
                    if (bl)
                    {
                        sum += item[0];
                    }
                    else
                    {
                        sum -= nums[idx];
                    }
                }
                else
                {
                    if (bl)
                    {
                        sum += val;
                    }
                   
                }
                nums[idx] = val;
                ans[i]= sum;
                i++;
            }
            return ans;
        }
    }
}

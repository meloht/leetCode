using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2251_2300
{
    public class _2270_NumberOfWaysToSplitArrayAlg
    {
        public int WaysToSplitArray(int[] nums)
        {
            long total =0 ;
           
            for (int i = 0; i < nums.Length; i++)
            {
                total += nums[i];
            }
            int ans = 0;
            long sum = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                sum += nums[i];
                long right = total - sum;
                if (sum >= right)
                {
                    ans++;
                }
            }
            return ans;
        }
    }
}

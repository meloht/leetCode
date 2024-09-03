using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2701_2750
{
    public class _2708_MaximumStrengthOfAGroupAlg
    {



        public long MaxStrength(int[] nums)
        {
            long mn = nums[0];
            long mx = mn;
            for (int i = 1; i < nums.Length; i++)
            {
                long x = nums[i];
                long tmp = mn;
                mn = Math.Min(Math.Min(mn, x), Math.Min(mn * x, mx * x));
                mx = Math.Max(Math.Max(mx, x), Math.Max(tmp * x, mx * x));
            }
            return mx;



        }

    }
}

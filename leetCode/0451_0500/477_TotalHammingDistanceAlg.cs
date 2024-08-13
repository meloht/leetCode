using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0451_0500
{
    public class _477_TotalHammingDistanceAlg
    {
        public int TotalHammingDistance(int[] nums)
        {
            int ans = 0;

            for (int i = 0; i < 30; i++)
            {
                int c = 0;
                foreach (var item in nums)
                {
                    c += item >> i & 1;
                }
                ans += c * (nums.Length - c);
            }
            return ans;
        }
    }
}

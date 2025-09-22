using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3001_3050
{
    public class _3005_CountElementsWithMaximumFrequencyAlg
    {
        public int MaxFrequencyElements(int[] nums)
        {
            int[] map=new int[101];
            int max = 0;
            foreach (var item in nums)
            {
                map[item]++;
                max=Math.Max(max, map[item]);
            }
            int ans = map.Where(p => p == max).Sum();
         
            return ans;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1351_1400
{
    public class _1394_FindLuckyIntegerInAnArrayAlg
    {
        public int FindLucky(int[] arr)
        {
            var dict = arr.GroupBy(p => p).ToDictionary(p => p.Key, p => p.Count());
            int ans = -1;
            foreach (var item in dict)
            {
                if (item.Key == item.Value)
                {
                    ans = Math.Max(ans, item.Key);
                }
            }

            return ans;
        }
    }
}

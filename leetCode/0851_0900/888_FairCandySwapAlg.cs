using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0851_0900
{
    public class _888_FairCandySwapAlg
    {
        public int[] FairCandySwap(int[] aliceSizes, int[] bobSizes)
        {
            int sum1 = aliceSizes.Sum();
            int sum2 = bobSizes.Sum();
            int sum = sum1 + sum2;
            int avg = sum / 2;
          
            HashSet<int> set = new HashSet<int>(bobSizes);
            foreach (var item in aliceSizes)
            {
                int num = avg - (sum1 - item);
                if (set.Contains(num))
                {
                    return [item, num];
                }
            }
            return null;
        }
    }
}

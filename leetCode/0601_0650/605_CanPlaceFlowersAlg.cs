using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0601_0650
{
    public class _605_CanPlaceFlowersAlg
    {
        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            int count = 0;
            int m = flowerbed.Length;
            int prev = -1;
            for (int i = 0; i < m; i++)
            {
                if (flowerbed[i] == 1)
                {
                    if (prev < 0)
                    {
                        count += i / 2;
                    }
                    else
                    {
                        count += (i - prev - 2) / 2;
                    }
                    if (count >= n)
                    {
                        return true;
                    }
                    prev = i;
                }
            }
            if (prev < 0)
            {
                count += (m + 1) / 2;
            }
            else
            {
                count += (m - prev - 1) / 2;
            }
            return count >= n;

        }
    }
}

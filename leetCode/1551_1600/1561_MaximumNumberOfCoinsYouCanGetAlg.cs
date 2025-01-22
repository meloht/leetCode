using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1551_1600
{
    public class _1561_MaximumNumberOfCoinsYouCanGetAlg
    {
        public int MaxCoins(int[] piles)
        {
            Array.Sort(piles);
            int n = piles.Length / 3;
            int res = 0;
            for (int i = 0; i < n; i++)
            {
                res += piles[piles.Length - 2 * (i + 1)];
            }
            return res;
        }
    }
}

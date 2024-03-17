using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2301_2350
{
    public class _2300_SuccessfulPairsOfSpellsAndPotionsAlg
    {
        public int[] SuccessfulPairs(int[] spells, int[] potions, long success)
        {
            Array.Sort(potions);
            int[] ans = new int[spells.Length];
            for (int i = 0; i < spells.Length; i++)
            {
                var s = (long)spells[i];
                int left = 0;
                int right = potions.Length - 1;
                int nn = potions.Length;
                while (left <= right)
                {
                    int mid = (right - left) / 2 + left;
                    long num = s * (long)potions[mid];

                    if (num < success)
                    {
                        left = mid + 1;

                    }
                    else
                    {
                        nn = mid;
                        right = mid - 1;
                    }
                }
                ans[i] = potions.Length - nn;
            }
            return ans;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode.WeeklyContest
{
    public class Alg_374_MinimumAddedCoins
    {
        public int MinimumAddedCoins(int[] coins, int target)
        {
            Array.Sort(coins);
            int total = 1;
            int i = 0;
            int count = 0;
            while (total <= target)
            {
                if (i < coins.Length && coins[i] <= total)
                {
                    total += coins[i];
                    i++;
                }
                else
                {
                    total = total * 2;
                    count++;
                }
            }

            return count;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2451_2500
{
    public class _2483_MinimumPenaltyForAShopAlg
    {
        public int BestClosingTime(string customers)
        {
            int penalty = 0;
            int minPenalty = 0;
            int ans = 0;
            for (int i = 0; i < customers.Length; i++)
            {
                penalty += customers[i] == 'N' ? 1 : -1;
                if (penalty < minPenalty)
                {
                    minPenalty = penalty;
                    ans = i + 1;
                }
            }
            return ans;


        }
    }
}

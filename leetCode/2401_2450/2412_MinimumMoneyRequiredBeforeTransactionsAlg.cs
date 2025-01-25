using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2401_2450
{
    public class _2412_MinimumMoneyRequiredBeforeTransactionsAlg
    {
        public long MinimumMoney(int[][] transactions)
        {
            long sumS = 0;
            long maxCashback = 0;
            long maxCostNonLoss = 0;

            foreach (var trans in transactions)
            {
                long cost = trans[0];
                long cashback = trans[1];

                if (cost > cashback)
                {
                    sumS += cost - cashback;
                    if (cashback > maxCashback)
                    {
                        maxCashback = cashback;
                    }
                }
                else
                {
                    if (cost > maxCostNonLoss)
                    {
                        maxCostNonLoss = cost;
                    }
                }
            }

            return Math.Max(sumS + maxCashback, sumS + maxCostNonLoss);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2801_2850
{

    public class _2806_AccountBalanceAfterRoundedPurchaseAlg
    {
        public int AccountBalanceAfterPurchase(int purchaseAmount)
        {
            int count = purchaseAmount / 10;
            int dis = purchaseAmount % 10;
            int num = 0;
            if (count > 0)
            {
                num = 10 * count;
            }

            if (dis > 0)
            {
                int num1 = Math.Abs((num + 10) - purchaseAmount);
                int num2 = Math.Abs(num - purchaseAmount);

                if (num1 <= num2)
                {
                    num += 10;
                }

            }
            return 100 - num;
        }

        public int AccountBalanceAfterPurchase1(int purchaseAmount)
        {
            int r = purchaseAmount % 10;
            if (r < 5)
            {
                purchaseAmount -= r;
            }
            else
            {
                purchaseAmount += 10 - r;
            }
            return 100 - purchaseAmount;
        }

    }
}

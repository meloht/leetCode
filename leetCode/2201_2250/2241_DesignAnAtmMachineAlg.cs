using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2201_2250
{
    public class _2241_DesignAnAtmMachineAlg
    {
        public class ATM
        {
            int[] res = [-1];
            int[] cnt;
            int[] amounts = [20, 50, 100, 200, 500];
            public ATM()
            {
                cnt = new int[5];
            }

            public void Deposit(int[] banknotesCount)
            {
                for (int i = 0; i < banknotesCount.Length; i++)
                {
                    cnt[i] += banknotesCount[i];
                }
            }

            public int[] Withdraw(int amount)
            {
                int[] ans = new int[5];
                for (int i = 4; i >= 0; i--)
                {
                    if (amount >= amounts[i] && cnt[i] > 0)
                    {
                        int count = Math.Min(amount / amounts[i], cnt[i]);
                        ans[i] = count;
                        amount -= count * amounts[i];
                    }
                    if (amount == 0)
                    {
                        break;
                    }
                }
                if (amount == 0)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        cnt[i] -= ans[i];
                    }
                    return ans;
                }
                else
                {
                    return res;
                }
               
            }
        }

    }
}

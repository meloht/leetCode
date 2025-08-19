using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1051_1100
{
    public class _1052_GrumpyBookstoreOwnerAlg
    {
        public int MaxSatisfied(int[] customers, int[] grumpy, int minutes)
        {
            int ans = 0;
            int num = 0;
            int max = 0;
            for (int i = 0, j = 0; i < customers.Length; i++)
            {
                if (grumpy[i] == 0)
                {
                    ans += customers[i];
                }
                else
                {
                    num += customers[i];

                }
                if (i - j + 1 > minutes)
                {
                    if (grumpy[j] == 1)
                    {
                        num -= customers[j];
                    }
                   
                    j++;
                }
                max = Math.Max(max, num);
            }

            return ans + max;
        }
    }
}

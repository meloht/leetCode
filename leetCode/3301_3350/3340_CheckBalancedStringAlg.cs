using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3301_3350
{
    public class _3340_CheckBalancedStringAlg
    {
        public bool IsBalanced(string num)
        {
            int sum = 0;
            int sum2 = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sum += num[i] - '0';
                }
                else
                {
                    sum2 += num[i] - '0';
                }

            }
            return sum == sum2;
        }
    }
}

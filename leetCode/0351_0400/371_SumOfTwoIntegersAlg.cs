using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0351_0400
{
    public class _371_SumOfTwoIntegersAlg
    {
        public int GetSum(int a, int b)
        {
            while (b != 0)
            {
                int carry = (a & b) << 1;
                a = a ^ b;
                b = carry;
            }
            return a;

        }


    }
}

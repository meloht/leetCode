using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0601_0650
{
    public class _633_SumOfSquareNumbersAlg
    {
        public bool JudgeSquareSum(int c)
        {

            for (int a = 0; a * a <= c / 2; a++)
            {
                int b = (int)Math.Sqrt(c - a * a);
                if (a * a + b * b == c)
                {
                    return true;
                }
            }
            return false;
        }

    }
}

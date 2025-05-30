using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0951_1000
{
    public class _0991_BrokenCalculatorAlg
    {
        public int BrokenCalc(int startValue, int target)
        {
            if (startValue > target)
            {
                return target - startValue;
            }


            int ans = 0;

            while (target > startValue)
            {
                ans++;
                if (target % 2 == 1)
                {
                    target++;
                }
                else
                {
                    target /= 2;
                }
            }

            return ans + startValue - target;
        }
    }
}

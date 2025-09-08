using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1301_1350
{
    public class _1317_ConvertIntegerToTheSumOfRwoNoZeroIntegersAlg
    {
        public int[] GetNoZeroIntegers(int n)
        {
            int a = 0;
            int baseVal = 1; // 10^k
            for (int x = n; x > 1; x /= 10)
            {
                int d = x % 10;
                if (d <= 1)
                {
                    d += 10;
                    x -= 10; // 借位
                }
                // a 这一位填 d/2，比如百位数就是 d/2 * 100
                a += d / 2 * baseVal;
                baseVal *= 10;
            }
            return new int[] { a, n - a };


        }
    }
}

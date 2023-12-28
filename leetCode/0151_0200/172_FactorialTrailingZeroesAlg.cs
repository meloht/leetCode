using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0151_0200
{
    public class _172_FactorialTrailingZeroesAlg
    {
        public int TrailingZeroes(int n)
        {
            if (n < 5)
                return 0;
            int count = 0;

            for (int i = 5; i <= n; i++)
            {

                if (i % 5 == 0)
                {
                    int m = i;
                    while (m > 0)
                    {
                        if (m % 5 == 0)
                        {
                            count++;
                            m = m / 5;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

            return count;
        }

        public int TrailingZeroes2(int n)
        {
            int ans = 0;
            while (n != 0)
            {
                n /= 5;
                ans += n;
            }
            return ans;
        }


      
    }
}

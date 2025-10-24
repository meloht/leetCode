using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2001_2050
{
    public class _2048_NextGreaterNumericallyBalancedNumberAlg
    {
        public int NextBeautifulNumber(int n)
        {

            while (true)
            {
                n++;

                int[] cnt = new int[10];
                for (int x = n; x > 0; x /= 10)
                {
                    cnt[x % 10]++;
                }

                bool ok = true;
                for (int x = n; x > 0; x /= 10)
                {
                    if (cnt[x % 10] != x % 10)
                    {
                        ok = false;
                        break;
                    }
                }
                if (ok)
                {
                    return n;
                }
            }

        }
    }
}

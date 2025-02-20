using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2551_2600
{
    public class _2595_NumberOfEvenAndOddBitsAlg
    {
        public int[] EvenOddBit1(int n)
        {
            string nn = Convert.ToString(n, 2);
            int even = 0;
            int odd = 0;
            for (int i = 0, j = nn.Length - 1; i < nn.Length; i++, j--)
            {
                if (nn[j] == '1')
                {
                    if (i % 2 == 0)
                    {
                        even++;
                    }
                    else
                    {
                        odd++;
                    }
                }
            }

            return [even, odd];
        }

        public int[] EvenOddBit2(int n)
        {
            int even = 0;
            int odd = 0;

            int nn = n;
            int i = 0;
            while (nn > 0)
            {
                if (nn % 2 == 1)
                {
                    if (i % 2 == 0)
                    {
                        even++;
                    }
                    else
                    {
                        odd++;
                    }
                }
                nn = nn / 2;
                i++;
            }

            return [even, odd];
        }

        public int[] EvenOddBit(int n)
        {
            int[] res = new int[2];
            int i = 0;
            while (n > 0)
            {
                res[i] += n & 1;
                n >>= 1;
                i ^= 1;
            }
            return res;
        }


    }
}

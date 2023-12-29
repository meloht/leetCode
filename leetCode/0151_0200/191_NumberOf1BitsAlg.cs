using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0151_0200
{
    public class _191_NumberOf1BitsAlg
    {
        public int HammingWeight1(uint n)
        {
            int count = 0;

            for (; n > 0;)
            {
                if ((n & 1) == 1)
                {
                    count++;
                }
                n >>= 1;
            }

            return count;
        }

        public int HammingWeight(uint n)
        {
            int ret = 0;
            for (int i = 0; i < 32; i++)
            {
                if ((n & (1 << i)) != 0)
                {
                    ret++;
                }
            }
            return ret;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0301_0350
{
    public class _338_CountingBitsAlg
    {
        public int[] CountBits1(int n)
        {
          
            int[] res = new int[n + 1];

            for (int i = 0; i <= n; i++)
            {
                res[i] = Convert.ToString(i, 2).Count(p=>p=='1');
            }

            return res;
        }

        public int[] CountBits(int n)
        {
            int[] bits = new int[n + 1];
            for (int i = 0; i <= n; i++)
            {
                bits[i] = CountOnes(i);
            }
            return bits;
        }

        public int CountOnes(int x)
        {
            int ones = 0;
            while (x > 0)
            {
                x &= (x - 1);
                ones++;
            }
            return ones;
        }


    }
}

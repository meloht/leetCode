using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2651_2700
{
    public class _2683_NeighboringBitwiseXorAlg
    {
        public bool DoesValidArrayExist(int[] derived)
        {
            int xor = 0;
            foreach (int x in derived)
            {
                xor ^= x;
            }
            return xor == 0;

        }
    }
}

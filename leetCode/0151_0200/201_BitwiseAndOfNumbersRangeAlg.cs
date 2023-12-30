using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0151_0200
{
    public class _201_BitwiseAndOfNumbersRangeAlg
    {
        public int RangeBitwiseAnd(int left, int right)
        {
            ulong res = (ulong)left;
            ulong leftu = res;
            ulong rightu = (ulong)right;

            for (ulong i = leftu + 1; i <= rightu; i++)
            {
               
                res = res & i;
                if (res == 0)
                    return (int)res;

            }
            return (int)res;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0151_0200
{
    public class _201_BitwiseAndOfNumbersRangeAlg
    {
        public int RangeBitwiseAnd1(int left, int right)
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

        public int RangeBitwiseAnd2(int m, int n)
        {
            int shift = 0;
            // 找到公共前缀
            while (m < n)
            {
                m >>= 1;
                n >>= 1;
                ++shift;
            }
            return m << shift;
        }

        public int RangeBitwiseAnd3(int m, int n)
        {
            while (m < n)
            {
                // 抹去最右边的 1
                n = n & (n - 1);
            }
            return n;
        }

        public int RangeBitwiseAnd(int left, int right)
        {
            int res = 0;
            int k = 1;
            bool btAnd;
            BigInteger i;
            while (left > 0)
            {
                btAnd = true;
                for (i = left; i <= right; i++)
                {
                    if (1 != i % 2)
                    {
                        btAnd = false;
                        break;
                    }
                }
                if (btAnd)
                    res += k;
                left /= 2;
                right /= 2;
                k *= 2;
            }
            return res;
        }



    }
}

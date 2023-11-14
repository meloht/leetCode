using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1_50
{
    internal class ReverseIntegerAlg
    {
        public int Reverse(int x)
        {
            long rs = 0;
            while (x != 0)
            {
                rs = rs * 10 + x % 10;
                x /= 10;
            }
            return (rs < int.MinValue || rs > int.MaxValue) ? 0 : (int)rs;
        }
    }
}

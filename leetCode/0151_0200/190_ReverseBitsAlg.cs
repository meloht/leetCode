using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0151_0200
{
    public class _190_ReverseBitsAlg
    {
        public uint reverseBits1(uint n)
        {
            string ss = Convert.ToString(n, 2).PadLeft(32, '0');
            var res = ss.ToArray();
            Array.Reverse(res);
            string ress = new string(res);
          
            return Convert.ToUInt32(ress, 2);
        }

        public uint reverseBits2(uint n)
        {
            uint rev = 0;
            for (int i = 0; i < 32 && n > 0; ++i)
            {
                rev |= (n & 1) << (31 - i);
                n >>= 1;
            }
            return rev;

        }

        const uint M1 = 0x55555555; // 01010101010101010101010101010101
        const uint M2 = 0x33333333; // 00110011001100110011001100110011
        const uint M4 = 0x0f0f0f0f; // 00001111000011110000111100001111
        const uint M8 = 0x00ff00ff; // 00000000111111110000000011111111

        public uint reverseBits(uint n)
        {
            n = n >> 1 & M1 | (n & M1) << 1;
            n = n >> 2 & M2 | (n & M2) << 2;
            n = n >> 4 & M4 | (n & M4) << 4;
            n = n >> 8 & M8 | (n & M8) << 8;
            return n >> 16 | n << 16;

        }
    }
}

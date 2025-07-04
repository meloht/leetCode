using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3301_3350
{
    public class _3307_FindTheKThCharacterInStringGameIIAlg
    {
        public char KthCharacter(long k, int[] operations)
        {
            k--;
            long inc = 0;
            for (int i = 63 - (int)long.LeadingZeroCount(k); i >= 0; i--)
            {
                inc += k >> i & operations[i];
            }
            return (char)('a' + inc % 26);
        }
    }
}
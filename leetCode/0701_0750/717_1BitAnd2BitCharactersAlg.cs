using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0701_0750
{
    public class _717_1BitAnd2BitCharactersAlg
    {
        public bool IsOneBitCharacter1(int[] bits)
        {
            int i = 0;
            while (i < bits.Length)
            {
                if (bits[i] == 0)
                {
                    i++;
                }
                else if (bits[i] == 1)
                {
                    i += 2;
                    if (i == bits.Length)
                        return false;
                }
            }
            return true;
        }

        public bool IsOneBitCharacter(int[] bits)
        {
            int n = bits.Length, i = 0;
            while (i < n - 1)
            {
                i += bits[i] + 1;
            }
            return i == n - 1;
        }


    }
}

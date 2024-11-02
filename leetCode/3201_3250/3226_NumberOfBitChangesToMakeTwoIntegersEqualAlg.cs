using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3201_3250
{
    public class _3226_NumberOfBitChangesToMakeTwoIntegersEqualAlg
    {
        public int MinChanges(int n, int k)
        {
            return (n & k) != k ? -1 : int.PopCount(n ^ k);
        }
    }
}

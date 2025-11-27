using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1201_1250
{
    public class _1238_CircularPermutationInBinaryRepresentationAlg
    {
        public IList<int> CircularPermutation(int n, int start)
        {
            IList<int> ret = new List<int>();
            for (int i = 0; i < 1 << n; i++)
            {
                ret.Add((i >> 1) ^ i ^ start);
            }
            return ret;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2251_2300
{
    public class _2275_LargestCombinationWithBitwiseAndGreaterThanZeroAlg
    {
        public int LargestCombination(int[] candidates)
        {
            int[] dict = new int[32];
            foreach (int item in candidates)
            {
                int x = item;
                int i = 0;
                while (x != 0)
                {
                    dict[i] += (x & 1);

                    x >>= 1;
                    i++;
                }
            }
            Array.Sort(dict);
            int max = dict[31];
          
            return max;
        }


    }
}

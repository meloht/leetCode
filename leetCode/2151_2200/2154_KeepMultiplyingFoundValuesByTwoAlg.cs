using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2151_2200
{
    public class _2154_KeepMultiplyingFoundValuesByTwoAlg
    {
        public int FindFinalValue(int[] nums, int original)
        {
            HashSet<int> set = new HashSet<int>(nums);

            while (set.Contains(original))
            {
                original = original * 2;
            }

            return original;
        }
    }
}

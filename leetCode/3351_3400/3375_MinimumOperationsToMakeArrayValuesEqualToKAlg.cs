using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3351_3400
{
    public class _3375_MinimumOperationsToMakeArrayValuesEqualToKAlg
    {
        public int MinOperations(int[] nums, int k)
        {

            int min = int.MaxValue;
            HashSet<int> set = new HashSet<int>();
            foreach (var item in nums)
            {
                min = Math.Min(item, min);
                if (min < k)
                    return -1;
                if (item > k)
                {
                    set.Add(item);
                }
            }
          

            return set.Count;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0951_1000
{
    public class _0961_NRepeatedElementInSize2nArrayAlg
    {
        public int RepeatedNTimes(int[] nums)
        {
            HashSet<int> result = new HashSet<int>();
            foreach (var item in nums)
            {
                if(result.Add(item)==false)
                    return item;

            }
            return 0;
        }
    }
}

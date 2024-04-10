using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0551_0600
{
    public class _575_DistributeCandiesAlg
    {
        public int DistributeCandies(int[] candyType)
        {
            HashSet<int> set = new HashSet<int>(candyType);
            int n = candyType.Length / 2;
            if (n > set.Count)
            {
                return set.Count;
            }
            return n;
        }
    }
}

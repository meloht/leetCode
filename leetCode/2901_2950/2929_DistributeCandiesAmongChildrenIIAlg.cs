using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2901_2950
{
    public class _2929_DistributeCandiesAmongChildrenIIAlg
    {
        public long DistributeCandies(int n, int limit)
        {
            return C2(n + 2) - 3 * C2(n - limit + 1) + 3 * C2(n - 2 * limit) - C2(n - 3 * limit - 1);

        }
        private long C2(int n)
        {
            return n > 1 ? (long)n * (n - 1) / 2 : 0;
        }


    }
}

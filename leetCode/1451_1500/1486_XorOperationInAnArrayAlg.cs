using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1451_1500
{
    public class _1486_XorOperationInAnArrayAlg
    {
        public int XorOperation(int n, int start)
        {
            int ans = start;
            for (int i = 1; i < n; i++)
            {
                ans = ans ^ (start + 2 * i);
            }
            return ans;
        }
    }
}

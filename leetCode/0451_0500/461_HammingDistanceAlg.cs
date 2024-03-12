using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0451_0500
{

    public class _461_HammingDistanceAlg
    {
        public int HammingDistance(int x, int y)
        {
            var num = x ^ y;
            int ans = 0;
            while (num > 0)
            {
                num = num & (num - 1);
                ans++;
            }
            return ans;
        }
    }
}

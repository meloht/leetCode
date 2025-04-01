using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0851_0900
{
    public class _858_MirrorReflectionAlg
    {
        public int MirrorReflection(int p, int q)
        {
            int g = gcd(p, q);
            p /= g; p %= 2;
            q /= g; q %= 2;

            if (p == 1 && q == 1) return 1;
            return p == 1 ? 0 : 2;

        }

        public int gcd(int a, int b)
        {
            if (a == 0) return b;
            return gcd(b % a, a);
        }


    }
}

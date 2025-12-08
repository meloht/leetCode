using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1901_1950
{
    public class _1925_CountSquareSumTriplesAlg
    {
        public int CountTriples(int n)
        {
            int res = 0;

            for (int a = 1; a <= n; ++a)
            {
                for (int b = 1; b <= n; ++b)
                {
               
                    int c = (int)Math.Sqrt(a * a + b * b + 1.0);
                    if (c <= n && c * c == a * a + b * b)
                    {
                        ++res;
                    }
                }
            }
            return res;

        }
    }
}

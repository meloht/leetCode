using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0501_0550
{
    public class _509_FibonacciNumberAlg
    {
        public int Fib(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            int f1 = 0;
            int f2 = 1;

            for (int i = 2; i <= n; i++)
            {
                int tem2 = f2;
                f2 = f1 + f2;
                f1 = tem2;
            }
            return f2;
        }
    }
}

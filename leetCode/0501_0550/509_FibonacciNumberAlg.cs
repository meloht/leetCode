using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0501_0550
{
    public class _509_FibonacciNumberAlg
    {
        public int Fib1(int n)
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

        public int Fib(int n)
        {
            if (n < 2)
            {
                return n;
            }
            int[,] q = { { 1, 1 }, { 1, 0 } };
            int[,] res = pow(q, n - 1);
            return res[0, 0];
        }

        public int[,] pow(int[,] a, int n)
        {
            int[,] ret = { { 1, 0 }, { 0, 1 } };
            while (n > 0)
            {
                if ((n & 1) == 1)
                {
                    ret = multiply(ret, a);
                }
                n >>= 1;
                a = multiply(a, a);
            }
            return ret;
        }

        public int[,] multiply(int[,] a, int[,] b)
        {
            int[,] c = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    c[i, j] = a[i, 0] * b[0, j] + a[i, 1] * b[1, j];
                }
            }
            return c;
        }

    }
}

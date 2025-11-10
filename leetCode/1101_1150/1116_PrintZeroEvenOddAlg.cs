using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1101_1150
{
    public class _1116_PrintZeroEvenOddAlg
    {
        public class ZeroEvenOdd
        {
            private int n;
            private static System.Threading.AutoResetEvent ZeroAr = new System.Threading.AutoResetEvent(true);
            private static System.Threading.AutoResetEvent EvenAr = new System.Threading.AutoResetEvent(false);
            private static System.Threading.AutoResetEvent OddAr = new System.Threading.AutoResetEvent(false);
       
            public ZeroEvenOdd(int n)
            {
                this.n = n;
            }

            // printNumber(x) outputs "x", where x is an integer.
            public void Zero(Action<int> printNumber)
            {
                for (int i = 0; i < n; i++)
                {
                    ZeroAr.WaitOne();
                    printNumber(0);
                    if (i % 2 == 0)
                    {
                        OddAr.Set();
                    }
                    else
                    {
                        EvenAr.Set();
                    }
                }
            }


            public void Even(Action<int> printNumber)
            {
                for (int i = 2; i <= n; i += 2)
                {
                    EvenAr.WaitOne();

                    printNumber(i);

                    ZeroAr.Set();

                }

            }

            public void Odd(Action<int> printNumber)
            {
                for (int i = 1; i <= n; i += 2)
                {
                    OddAr.WaitOne();

                    printNumber(i);
                    ZeroAr.Set();


                }

            }
        }
    }
}

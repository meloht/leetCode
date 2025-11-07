using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace leetCode._1101_1150
{
    public class _1115_PrintFoobarAlternatelyAlg
    {
        public class FooBar1
        {
            private int n;
            bool foo;
            bool bar;
            object lockObj = new object();

            public FooBar1(int n)
            {
                this.n = n;
                bar = true;
                foo = false;
            }

            public void Foo(Action printFoo)
            {

                for (int i = 0; i < n;)
                {
                    lock (lockObj)
                    {
                        if (bar)
                        {
                            bar = false;
                            // printFoo() outputs "foo". Do not change or remove this line.
                            printFoo();
                            i++;
                            foo = true;

                        }
                    }

                    System.Threading.Thread.Sleep(1);

                }
            }

            public void Bar(Action printBar)
            {

                for (int i = 0; i < n;)
                {
                    lock (lockObj)
                    {
                        if (foo)
                        {
                            foo = false;
                            printBar();
                            i++;
                            bar = true;
                        }

                    }
                    System.Threading.Thread.Sleep(1);

                }
            }
        }

        public class FooBar
        {
            private int n;

            private static System.Threading.AutoResetEvent fooAr=new System.Threading.AutoResetEvent(true);
            private static System.Threading.AutoResetEvent barAr = new System.Threading.AutoResetEvent(false);

            public FooBar(int n)
            {
                this.n = n;
            }

            public void Foo(Action printFoo)
            {

                for (int i = 0; i < n;i++)
                {
                    fooAr.WaitOne();
                    printFoo();
                    barAr.Set();
                }
            }

            public void Bar(Action printBar)
            {

                for (int i = 0; i < n;)
                {
                    barAr.WaitOne();
                    printBar();
                    fooAr.Set();

                }
            }
        }
    }
}

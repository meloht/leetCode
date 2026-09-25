using System;
using System.Collections.Generic;
using System.Text;

namespace leetCode._1101_1150
{
    public class _1114_print_in_order
    {
        public class Foo
        {
            // 信号量，控制second能否执行，初始0（不可执行）
            private readonly System.Threading.SemaphoreSlim _semSecond = new System.Threading.SemaphoreSlim(0);
            // 信号量，控制third能否执行，初始0（不可执行）
            private readonly System.Threading.SemaphoreSlim _semThird = new System.Threading.SemaphoreSlim(0);

            public Foo()
            {

            }

            public void First(Action printFirst)
            {
           
                // printFirst() outputs "first". Do not change or remove this line.
                printFirst();
                _semSecond.Release();
            }

            public void Second(Action printSecond)
            {
                _semSecond.Wait();
                // printSecond() outputs "second". Do not change or remove this line.
                printSecond();
                _semThird.Release();
            }

            public void Third(Action printThird)
            {
                _semThird.Wait();
                // printThird() outputs "third". Do not change or remove this line.
                printThird();
            }
        }
    }
}

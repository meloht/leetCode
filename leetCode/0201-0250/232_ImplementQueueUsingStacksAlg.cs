using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0201_0250
{
    public class _232_ImplementQueueUsingStacksAlg
    {
        public class MyQueue
        {
            Stack<int> stack = new Stack<int>();
            Stack<int> queue = new Stack<int>();
            public MyQueue()
            {

            }

            public void Push(int x)
            {
                while (queue.Count > 0)
                {
                    stack.Push(queue.Pop());
                }
                stack.Push(x);
                while (stack.Count > 0)
                {
                    queue.Push(stack.Pop());
                }
            }

            public int Pop()
            {
                return queue.Pop();
            }

            public int Peek()
            {
                return queue.Peek();
            }

            public bool Empty()
            {
                return queue.Count == 0;
            }
        }

        public class MyQueue1
        {
            Stack<int> inStack;
            Stack<int> outStack;

            public MyQueue1()
            {
                inStack = new Stack<int>();
                outStack = new Stack<int>();
            }

            public void Push(int x)
            {
                inStack.Push(x);
            }

            public int Pop()
            {
                if (outStack.Count == 0)
                {
                    In2Out();
                }
                return outStack.Pop();
            }

            public int Peek()
            {
                if (outStack.Count == 0)
                {
                    In2Out();
                }
                return outStack.Peek();
            }

            public bool Empty()
            {
                return inStack.Count == 0 && outStack.Count == 0;
            }

            private void In2Out()
            {
                while (inStack.Count > 0)
                {
                    outStack.Push(inStack.Pop());
                }
            }
        }

    }
}

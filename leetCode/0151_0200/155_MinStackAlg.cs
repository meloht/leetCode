using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0151_0200
{
    public class _155_MinStackAlg
    {
        public class MinStack
        {
            Stack<int> stack;
            Stack<int> minStack;
            public MinStack()
            {
                stack = new Stack<int>();
                minStack = new Stack<int>();
            }

            public void Push(int val)
            {
                stack.Push(val);
                if (minStack.Count == 0 || minStack.Peek() >= val)
                {
                    minStack.Push(val);
                }
            }

            public void Pop()
            {
                if (minStack.Peek() == stack.Peek())
                {
                    minStack.Pop();
                }
                stack.Pop();
            }

            public int Top()
            {
                return stack.Peek();
            }

            public int GetMin()
            {
                return minStack.Peek();
            }
        }

    }
}

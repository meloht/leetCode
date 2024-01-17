using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0201_0250
{
    public class _225_ImplementStackUsingQueuesAlg
    {
        public class MyStack
        {
            Queue<int> queue1 = new Queue<int>();

            public MyStack()
            {

            }

            public void Push(int x)
            {
                int count = queue1.Count;

                queue1.Enqueue(x);
                for (int i = 0; i < count; i++)
                {
                    queue1.Enqueue(queue1.Dequeue());
                }
               
            }

            public int Pop()
            {
                return queue1.Dequeue();
            }

            public int Top()
            {
                return queue1.Peek();
            }

            public bool Empty()
            {
                return queue1.Count == 0;
            }
        }
    }
}

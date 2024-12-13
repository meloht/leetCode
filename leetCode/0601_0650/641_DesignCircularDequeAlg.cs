using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0601_0650
{
    public class _641_DesignCircularDequeAlg
    {
        public class MyCircularDeque
        {
            LinkedList<int> list;
            int size;
            int actualSize;
            public MyCircularDeque(int k)
            {
                size = k;
                actualSize = 0;
                list = new LinkedList<int>();

            }

            public bool InsertFront(int value)
            {
                if (actualSize == size)
                    return false;
                actualSize++;
                list.AddFirst(value);
                return true;
            }

            public bool InsertLast(int value)
            {
                if (actualSize == size)
                    return false;
                actualSize++;
                list.AddLast(value);
                return true;
            }

            public bool DeleteFront()
            {
                if (actualSize == 0)
                    return false;
                actualSize--;
                list.RemoveFirst();
                return true;
            }

            public bool DeleteLast()
            {
                if (actualSize == 0)
                    return false;
                actualSize--;
                list.RemoveLast();
                return true;
            }

            public int GetFront()
            {
                if (actualSize == 0)
                    return -1;
                return list.First.Value;
            }

            public int GetRear()
            {
                if (actualSize == 0)
                    return -1;
                return list.Last.Value;
            }

            public bool IsEmpty()
            {
                return actualSize==0;
            }

            public bool IsFull()
            {
                return actualSize==size;
            }
        }
    }
}

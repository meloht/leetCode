using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0601_0650
{
    public class _622_DesignCircularQueueAlg
    {
        public class MyCircularQueue
        {
            List<int> list;
            int max;
            public MyCircularQueue(int k)
            {
                max = k;
                list = new List<int>(k);
            }

            public bool EnQueue(int value)
            {
                if (IsFull())
                {
                    return false;
                }
                list.Add(value);
                return true;
            }

            public bool DeQueue()
            {
                if (IsEmpty())
                {
                    return false;
                }
                list.RemoveAt(0);
                return true;
            }

            public int Front()
            {
                if (IsEmpty())
                {
                    return -1;
                }
                return list[0];
            }

            public int Rear()
            {
                if (IsEmpty())
                {
                    return -1;
                }
                return list[list.Count - 1]; 
            }

            public bool IsEmpty()
            {

                return list.Count == 0;
            }

            public bool IsFull()
            {
                return list.Count >= max;
            }
        }


        public class MyCircularQueue1
        {
            private int front;
            private int rear;
            private int capacity;
            private int[] elements;

            public MyCircularQueue1(int k)
            {
                capacity = k + 1;
                elements = new int[capacity];
                rear = front = 0;
            }

            public bool EnQueue(int value)
            {
                if (IsFull())
                {
                    return false;
                }
                elements[rear] = value;
                rear = (rear + 1) % capacity;
                return true;
            }

            public bool DeQueue()
            {
                if (IsEmpty())
                {
                    return false;
                }
                front = (front + 1) % capacity;
                return true;
            }

            public int Front()
            {
                if (IsEmpty())
                {
                    return -1;
                }
                return elements[front];
            }

            public int Rear()
            {
                if (IsEmpty())
                {
                    return -1;
                }
                return elements[(rear - 1 + capacity) % capacity];
            }

            public bool IsEmpty()
            {
                return rear == front;
            }

            public bool IsFull()
            {
                return ((rear + 1) % capacity) == front;
            }
        }


        public class MyCircularQueue2
        {
            private ListNode head;
            private ListNode tail;
            private int capacity;
            private int size;

            public MyCircularQueue2(int k)
            {
                capacity = k;
                size = 0;
            }

            public bool EnQueue(int value)
            {
                if (IsFull())
                {
                    return false;
                }
                ListNode node = new ListNode(value);
                if (head == null)
                {
                    head = tail = node;
                }
                else
                {
                    tail.next = node;
                    tail = node;
                }
                size++;
                return true;
            }

            public bool DeQueue()
            {
                if (IsEmpty())
                {
                    return false;
                }
                ListNode node = head;
                head = head.next;
                size--;
                return true;
            }

            public int Front()
            {
                if (IsEmpty())
                {
                    return -1;
                }
                return head.val;
            }

            public int Rear()
            {
                if (IsEmpty())
                {
                    return -1;
                }
                return tail.val;
            }

            public bool IsEmpty()
            {
                return size == 0;
            }

            public bool IsFull()
            {
                return size == capacity;
            }
        }

    }
}

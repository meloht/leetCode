using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0701_0750
{
    public class _707_DesignLinkedListAlg
    {
        public class MyLinkedList
        {
            private LinkNode head;
            private LinkNode tail;
            private int count = 0;

            public MyLinkedList()
            {

            }

            public int Get(int index)
            {
                if (count == 0)
                    return -1;
                var node = GetNode(index);
                if (node == null)
                    return -1;
                return node.Val;
            }
            private void initNode(int val)
            {
                this.head = new LinkNode(val, null, null);
                this.tail = this.head;
                this.head.Next = this.tail;
                this.tail.Prev = this.head;
                count++;
            }
            public void AddAtHead(int val)
            {
                if (this.head == null)
                {
                    initNode(val);
                }
                else
                {
                    var temp = this.head;
                    this.head = new LinkNode(val, null, temp);
                    temp.Prev = this.head;
                    count++;
                }

            }


            public void AddAtTail(int val)
            {
                if (this.tail == null)
                {
                    initNode(val);
                }
                else
                {
                    var temp = this.tail;
                    this.tail = new LinkNode(val, temp, null);
                    temp.Next = this.tail;
                    count++;
                }
            }

            public void AddAtIndex(int index, int val)
            {
                if (index == 0)
                {
                    AddAtHead(val);
                }
                else if (index == count)
                {
                    AddAtTail(val);
                }
                else if (index < count)
                {
                    var node = GetNode(index);
                    var temp = node.Prev;
                    temp.Next = new LinkNode(val, temp, node);
                    node.Prev = temp.Next;
                    count++;
                }



            }

            public void DeleteAtIndex(int index)
            {
                if (count == 0 || index >= count)
                    return;
                if (count == 1 && index == 0)
                {
                    this.head = null;
                    this.tail = null;
                    count--;
                    return;

                }
                if (index == 0)
                {
                    this.head = this.head.Next;
                    this.head.Prev = null;
                    count--;
                }
                else if (index == count - 1)
                {
                    this.tail = this.tail.Prev;
                    this.tail.Next = null;
                    count--;
                }
                else
                {
                    var node = GetNode(index);
                    var next = node.Next;
                    var prev = node.Prev;
                    if (next != null)
                    {
                        next.Prev = prev;
                    }
                    if (prev != null)
                    {
                        prev.Next = next;
                    }

                    count--;
                }
            }

            public LinkNode GetNode(int index)
            {
                if (count == 0)
                    return null;

                if (index >= count)
                    return null;

                int mid = count / 2;
                if (mid == 0)
                {
                    return this.head;
                }

                if (index > mid)
                {
                    int idx = count - 1;
                    LinkNode node = this.tail;
                    while (node != null && idx != index)
                    {
                        node = node.Prev;
                        idx--;
                    }
                    return node;
                }
                else
                {
                    int idx = 0;
                    LinkNode node = this.head;
                    while (node != null && idx != index)
                    {
                        node = node.Next;
                        idx++;
                    }
                    return node;
                }

            }
        }

        public class LinkNode
        {
            public LinkNode Prev;
            public LinkNode Next;
            public int Val;

            public LinkNode(int val, LinkNode prev, LinkNode next)
            {
                this.Val = val;
                this.Prev = prev;
                this.Next = next;
            }

            public override string ToString()
            {
                return Val.ToString();
            }
        }

        public class MyLinkedList1
        {
            private List<int> list;

            public MyLinkedList1()
            {
                list = new List<int>();
            }

            public int Get(int index)
            {
                if (index < list.Count)
                    return list[index];
                return -1;
            }

            public void AddAtHead(int val)
            {

                list.Insert(0, val);
            }

            public void AddAtTail(int val)
            {
                list.Add(val);
            }

            public void AddAtIndex(int index, int val)
            {
                if (index < list.Count)
                {
                    list.Insert(index, val);
                }
                else if (index == list.Count)
                {
                    list.Add(val);
                }

            }

            public void DeleteAtIndex(int index)
            {
                if (index < list.Count)
                {
                    list.RemoveAt(index);
                }
            }
        }
    }
}

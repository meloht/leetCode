using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode.Model.ListNodes
{
    public class Node
    {
        public int val;
        public Node prev;
        public Node next;
        public Node child;

        public override string ToString()
        {
            return val.ToString();
        }

        public static Node Build(int?[] arr)
        {
            if (arr == null || arr.Length == 0)
                return null;

            Node head = new Node();
            head.next = new Node();
            head.next.val = arr[0].Value;
            Node node = head.next;

            int idx = 1;
            int index = 0;
            while (idx < arr.Length)
            {
                if (arr[idx] != null)
                {
                    if (index > 0)
                    {

                        while (index > 0)
                        {
                            node = node.prev;
                            index--;
                        }
                        Node curr=new Node();
                        curr.val = arr[idx].Value;
                        node.child=curr;
                        node = curr;

                    }
                    else
                    {
                        Node curr = new Node();
                        curr.val = arr[idx].Value;
                        node.next = curr;
                        curr.prev = node;
                        node= curr;

                    }
                }
                else
                {

                    index++;

                }

                idx++;

            }
            return head.next;
        }

        public static int[] GetList(Node node)
        {
            List<int> list = new List<int>();

            while (node != null)
            {
                list.Add(node.val);
                node = node.next;
            }

            return list.ToArray();
        }
    }
}

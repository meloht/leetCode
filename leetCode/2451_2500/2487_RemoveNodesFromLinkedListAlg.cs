using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2451_2500
{
    public class _2487_RemoveNodesFromLinkedListAlg
    {
        public ListNode RemoveNodes1(ListNode head)
        {
            Stack<ListNode> stack = new Stack<ListNode>();

            ListNode nodeDump = new ListNode(-1);
            nodeDump.next = head;

            ListNode node = head;
            while (node != null)
            {
                if (stack.Count > 0)
                {
                    var last = stack.Peek();
                    while (stack.Count > 0 && stack.Peek().val < node.val)
                    {
                        last = stack.Pop();
                    }
                    if (stack.Count == 0)
                    {
                        nodeDump.next = node;

                    }
                    else
                    {
                        stack.Peek().next = node;
                    }
                }

                stack.Push(node);

                node = node.next;
            }

            return nodeDump.next;
        }

        public ListNode RemoveNodes2(ListNode head)
        {
            head = Reverse(head);
            for (ListNode p = head; p.next != null;)
            {
                if (p.val > p.next.val)
                {
                    p.next = p.next.next;
                }
                else
                {
                    p = p.next;
                }
            }
            return Reverse(head);

        }




        public ListNode Reverse(ListNode head)
        {
            ListNode dummy = new ListNode(-1);
            while (head != null)
            {
                ListNode p = head;
                head = head.next;
                p.next = dummy.next;
                dummy.next = p;
            }
            return dummy.next;
        }

        public ListNode RemoveNodes3(ListNode head)
        {
            Stack<ListNode> stack = new Stack<ListNode>();
            for (; head != null; head = head.next)
            {
                stack.Push(head);
            }
            for (; stack.Count > 0; stack.Pop())
            {
                if (head == null || stack.Peek().val >= head.val)
                {
                    stack.Peek().next = head;
                    head = stack.Peek();
                }
            }
            return head;
        }

        public ListNode RemoveNodes(ListNode head)
        {
            if (head == null)
            {
                return null;
            }
            head.next = RemoveNodes(head.next);
            if (head.next != null && head.val < head.next.val)
            {
                return head.next;
            }
            else
            {
                return head;
            }
        }


    }
}

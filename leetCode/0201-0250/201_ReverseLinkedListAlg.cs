using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._201_250
{
    public class _201_ReverseLinkedListAlg
    {
        public ListNode ReverseList1(ListNode head)
        {
            if (head == null)
                return null;
            if (head != null && head.next == null)
                return head;
            Stack<ListNode> stack = new Stack<ListNode>();

            ListNode node = head;
            while (node != null)
            {
                stack.Push(node);
                node = node.next;
            }
            ListNode header = stack.Pop();
            node = header;
            while (stack.Count > 0)
            {
                var temp = stack.Pop();
                if (temp != null)
                {
                    node.next = temp;
                    node = temp;
                }
            }
            node.next = null;
            return header;
        }

        public ListNode ReverseList2(ListNode head)
        {
            if (head == null)
                return null;
            if (head != null && head.next == null)
                return head;

            ListNode newNode = new ListNode(-1);
            ListNode header = newNode;
            var node = ReverseNode(head, newNode);
            node.next = null;

            return header.next;
        }

        private ListNode ReverseNode(ListNode node, ListNode newNode)
        {
            if (node.next == null)
            {
                newNode.next = node;
                return newNode.next;
            }
            else
            {
                var next = ReverseNode(node.next, newNode);
                next.next = node;

                return next.next;

            }
        }

        public ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;
            ListNode curr = head;
            while (curr != null)
            {
                ListNode next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }
            return prev;
        }

    }
}


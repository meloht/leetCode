using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._51_100
{
    public class _92_ReverseLinkedListIIAlg
    {
        public ListNode ReverseBetween(ListNode head, int left, int right)
        {
            ListNode oldHead = head;
            ListNode leftNode = null;
            ListNode curr = head;
            int index = 1;
            if (left > 1)
            {
                while (curr != null)
                {
                    if (index >= left - 1)
                    {
                        leftNode = curr;
                        break;
                    }
                    curr = curr.next;
                    index++;
                }
            }
            int newright = right - left + 1;
           
            if (leftNode==null)
            {
                var node1 = ReverseList(head, newright);
                return node1;
            }
            var node = ReverseList(leftNode.next, newright);
            leftNode.next = node;
            return head;
        }
        private ListNode ReverseList(ListNode head, int right)
        {
            int index = 0;
            ListNode prev = null;
            ListNode curr = head;
            while (curr != null)
            {
                ListNode next = curr.next;
                curr.next = prev;
                prev = curr;

                index++;
                if (index == right)
                {
                    head.next = next;
                    break;
                }
                curr = next;
            }
            return prev;
        }
        public ListNode ReverseBetween1(ListNode head, int left, int right)
        {
            if (head == null)
                return null;
            if (head != null && head.next == null)
                return head;
            Stack<ListNode> stack = new Stack<ListNode>();

            ListNode node = head;
            ListNode leftNode = null;
            ListNode rightNode = null;
            int index = 1;
            while (node != null)
            {
                if (index >= left && index <= right)
                {
                    stack.Push(node);
                }
                if (index < left)
                {
                    leftNode = node;
                }
                if (index == right)
                {
                    rightNode = node.next;
                    break;
                }
                node = node.next;
                index++;
            }
            ListNode header = stack.Pop();
            node = header;
            if (stack.Count == 0)
            {
                header.next = rightNode;
            }
            while (stack.Count > 0)
            {
                var temp = stack.Pop();
                if (temp != null)
                {
                    node.next = temp;
                    node = temp;
                }
                if (stack.Count == 0)
                {
                    temp.next = rightNode;
                }
            }


            if (leftNode != null)
            {
                leftNode.next = header;
            }
            else
            {
                head = header;
            }
            return head;

        }


    }
}

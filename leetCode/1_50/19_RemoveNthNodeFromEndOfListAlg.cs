using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static leetCode._1_50.AddTwoNumbersAlg;

namespace leetCode._1_50
{
    internal class RemoveNthNodeFromEndOfListAlg
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode headNode = head;
            ListNode node = head;
            ListNode stepLeft = head;

            int num = 0;
            while (node != null)
            {
                node = node.next;
                num++;
                if (num > (n + 1))
                {
                    stepLeft = stepLeft.next;
                }
            }
            if (n == num)
            {
                if (head != null)
                    return head.next;
                return null;
            }

            if (stepLeft.next != null)
            {
                ListNode delNode = stepLeft.next;
                if (delNode.next != null)
                {
                    stepLeft.next = delNode.next;
                }
                else
                {
                    stepLeft.next = null;
                }

                delNode.next = null;
                return headNode;
            }
            else
            {
                return null;
            }
        }
    }
}

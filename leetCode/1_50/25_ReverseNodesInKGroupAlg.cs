using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static leetCode._1_50.AddTwoNumbersAlg;

namespace leetCode._1_50
{
    internal class ReverseNodesInKGroupAlg
    {
        public ListNode ReverseKGroup(ListNode head, int k)
        {
            ListNode dummy = new ListNode(0);
            dummy.next = head;

            ListNode pre = dummy;
            ListNode end = dummy;

            while (end.next != null)
            {
                for (int i = 0; i < k && end != null; i++)
                {
                    end = end.next;
                }
                if (end == null)
                    break;
                ListNode start = pre.next;
                ListNode next = end.next;
                end.next = null;
                pre.next = Reverse(start);
                start.next = next;
                pre = start;

                end = pre;

            }
            return dummy.next;
        }
        public ListNode Reverse(ListNode head)
        {
            ListNode pre = null;
            ListNode curr = head;
            while (curr != null)
            {
                ListNode next = curr.next;
                curr.next = pre;
                pre = curr;
                curr = next;
            }
            return pre;
        }
    }
}

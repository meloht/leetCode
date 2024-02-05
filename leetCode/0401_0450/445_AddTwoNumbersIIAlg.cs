using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0401_0450
{
    public class _445_AddTwoNumbersIIAlg
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var l1r = Reverse(l1);
            var l2r = Reverse(l2);

            ListNode dummy = new ListNode(-1);
            ListNode node3 = dummy;
            int next = 0;
            ListNode node1 = l1r;
            ListNode node2 = l2r;
            while (node1 != null || node2 != null || next > 0)
            {
                int num = 0;
                if (node1 != null)
                {
                    num += node1.val;
                }
                if (node2 != null)
                {
                    num += node2.val;
                }
                if (next >0)
                {
                    num += next;
                }
                if (num > 9)
                {
                    next = 1;
                    num = num % 10;
                }
                else
                {
                    next = 0;
                }
                node3.next = new ListNode(num);
                node3 = node3.next;

                if (node1 != null)
                {
                    node1 = node1.next;
                }
                if (node2 != null)
                {
                    node2 = node2.next;
                }

            }
            var ans = Reverse(dummy.next);
            return ans;
        }

        private ListNode Reverse(ListNode head)
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
    }
}

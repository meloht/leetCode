using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static leetCode._1_50.AddTwoNumbersAlg;

namespace leetCode._1_50
{
    internal class MergeTwoSortedListsAlg
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode head = null;
            ListNode node = null;
            if (l1 == null)
                return l2;
            if (l2 == null)
                return l1;

            if (l1 != null && l2 != null)
            {
                if (l1.val > l2.val)
                {
                    head = l2;
                    node = l2;
                    l2 = l2.next;
                }
                else
                {
                    head = l1;
                    node = l1;
                    l1 = l1.next;
                }
            }

            while (l1 != null && l2 != null)
            {
                if (l1.val > l2.val)
                {
                    node.next = l2;
                    l2 = l2.next;
                }
                else
                {
                    node.next = l1;
                    l1 = l1.next;
                }
                node = node.next;
            }

            if (l1 != null)
            {
                node.next = l1;
            }
            if (l2 != null)
            {
                node.next = l2;
            }

            return head;
        }
    }
}

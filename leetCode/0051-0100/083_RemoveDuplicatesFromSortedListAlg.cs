using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._51_100
{
    public class _83_RemoveDuplicatesFromSortedListAlg
    {
        public ListNode DeleteDuplicates1(ListNode head)
        {
            ListNode nodeHead = head;
            ListNode node1 = nodeHead;
            while (node1 != null)
            {
                ListNode node2 = node1.next;
                while (node2 != null && node2.val == node1.val)
                {
                    node2 = node2.next;
                }
                node1.next = node2;
                node1 = node1.next;

            }
            return nodeHead;
        }

        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null)
                return null;
            ListNode node = head;
            while (node.next != null)
            {
                if (node.next.val == node.val)
                {
                    node.next = node.next.next;
                }
                else
                {
                    node = node.next;
                }
            }
            return head;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._51_100
{
    public class _86_PartitionListAlg
    {
        public ListNode Partition(ListNode head, int x)
        {
            if (head == null)
                return null;

            ListNode lefts = new  ListNode(0);
            ListNode leftsHeader = lefts;
            ListNode rights = new ListNode(0);
            ListNode rightHeader = rights;
            ListNode node = head;
            while (node != null)
            {
                if (node.val < x)
                {
                    lefts.next = node;
                    lefts = lefts.next;
                }
                else
                {
                    rights.next = node;
                    rights = rights.next;
                }
                node = node.next;
            }
            lefts.next = rightHeader.next;
            rights.next = null;
            return leftsHeader.next;
        }
    }
}

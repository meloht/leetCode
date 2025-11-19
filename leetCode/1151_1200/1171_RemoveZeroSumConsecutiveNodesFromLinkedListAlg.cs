using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1151_1200
{
    public class _1171_RemoveZeroSumConsecutiveNodesFromLinkedListAlg
    {
        public ListNode RemoveZeroSumSublists(ListNode head)
        {
            int prefix = 0;
            ListNode dummy = new ListNode(0);
            dummy.next = head;
            Dictionary<int, ListNode> seen = new Dictionary<int, ListNode>();
            seen[0] = dummy;
            for (ListNode node = dummy; node != null; node = node.next)
            {
                prefix += node.val;
                seen[prefix] = node;
            }
            prefix = 0;
            for (ListNode node = dummy; node != null; node = node.next)
            {
                prefix += node.val;
                node.next = seen[prefix].next;
            }
            return dummy.next;

        }
    }
}

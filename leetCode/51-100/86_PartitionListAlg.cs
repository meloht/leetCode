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

            List<ListNode> lefts = new List<ListNode>();
            List<ListNode> rights = new List<ListNode>();
            ListNode node = head;
            while (node != null)
            {
                if (node.val < x)
                {
                    lefts.Add(node);
                }
                else
                {
                    rights.Add(node);
                }
                node = node.next;
            }
            lefts.AddRange(rights);

            for (int i = 1; i < lefts.Count; i++)
            {
                lefts[i - 1].next = lefts[i];
            }
            lefts[lefts.Count - 1].next = null;
            return lefts[0];
        }
    }
}

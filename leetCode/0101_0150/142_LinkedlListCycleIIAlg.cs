using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0101_0150
{
    public class _142_LinkedlListCycleIIAlg
    {
        public ListNode DetectCycle(ListNode head)
        {
            HashSet<ListNode> set = new HashSet<ListNode>();
            ListNode node = head;
            while (node != null)
            {
                if (set.Contains(node))
                {
                    return node;
                }
                else
                {
                    set.Add(node);
                    node = node.next;
                }
            }

            return null;
        }
    }
}

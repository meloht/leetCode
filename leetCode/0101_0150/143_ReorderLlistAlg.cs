using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0101_0150
{
    public class _143_ReorderLlistAlg
    {
        public void ReorderList(ListNode head)
        {
            if (head.next == null)
                return;
            List<ListNode> list = new List<ListNode>();
            ListNode node = head.next;
            while (node != null)
            {
                list.Add(node);
                node = node.next;
            }
            node = head;
            while (list.Count > 0)
            {
                var node1= list[list.Count - 1];
                node.next = node1;
                node1.next = null;
                list.RemoveAt(list.Count - 1);
                if (list.Count > 0)
                {
                    var node2 = list[0];
                    node1.next = node2;
                    node = node2;
                    node2.next = null;
                    list.RemoveAt(0);
                }
            }
        }
    }
}

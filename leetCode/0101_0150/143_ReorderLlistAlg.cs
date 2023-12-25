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
            int left = 0;
            int right = list.Count - 1;
            while (left <= right)
            {
                var node1 = list[right];
                node.next = node1;
                node1.next = null;

                if (left < right)
                {
                    var node2 = list[left];
                    node1.next = node2;
                    node = node2;
                    node2.next = null;
                }

                right--;
                left++;
            }
        }
    }
}

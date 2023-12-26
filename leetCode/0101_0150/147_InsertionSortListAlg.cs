using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0101_0150
{
    public class _147_InsertionSortListAlg
    {
        public ListNode InsertionSortList(ListNode head)
        {
            if (head.next == null)
                return head;

            ListNode dump = new ListNode(int.MinValue);

            ListNode curr = head;
            while (curr != null)
            {
                var next = curr.next;
                ListNode node = dump;
                ListNode prev = dump;
                curr.next = null;
                while (node != null)
                {

                    if (curr.val > node.val)
                    {
                        if (node.next == null)
                        {
                            InertNode(node, curr);
                            break;
                        }
                    }
                    else
                    {
                        InertNode(prev, curr);
                        break;
                    }
                    prev = node;
                    node = node.next;
                }

                curr = next;
            }

            return dump.next;
        }


        private void InertNode(ListNode prev, ListNode insertNode)
        {
            var tem = prev.next;
            prev.next = insertNode;
            insertNode.next = tem;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._51_100
{
    public class _82_RemoveDuplicatesFromSortedListIIAlg
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null || head.next == null)
                return head;

            ListNode nodeHead = GetNextNode(head);
            ListNode node = nodeHead;
            ListNode nodeFirt = node;
            while (nodeFirt != null)
            {
                if (nodeFirt.next != null)
                {
                    var temp = GetNextNode(nodeFirt.next);
                    if (temp.val != node.next.val)
                    {
                        nodeFirt.next = temp;
                        if (temp.next == null)
                            break;
                    }
                    else
                    {
                        nodeFirt = temp;
                    }
                }
                else
                {
                    break;
                }
            }
            return nodeHead;
        }

        private ListNode GetNextNode(ListNode head)
        {
            ListNode node = head;
            ListNode nodeHead = head;
            bool flag = false;
            while (node != null && node.next != null && node.next.val == node.val)
            {
                node = node.next;
                flag = true;
            }
            if (flag)
            {
                nodeHead = node.next;
            }
            else
            {
                nodeHead = node;
            }

            return nodeHead;
        }
    }
}

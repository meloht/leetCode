using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2151_2200
{
    public class _2181_MergeNodesInBetweenZerosAlg
    {
        public ListNode MergeNodes1(ListNode head)
        {
            ListNode headNew = new ListNode(-1);
            ListNode node = head.next;
            ListNode nodeNew = headNew;
            int sum = 0;
            while (node != null)
            {
                if (node.val != 0)
                {
                    sum += node.val;
                }
                if (node.val == 0)
                {
                    ListNode listNode = new ListNode(sum);
                    nodeNew.next = listNode;
                    nodeNew = listNode;
                    sum = 0;
                }
                node = node.next;
            }

            return headNew.next;
        }

        public ListNode MergeNodes(ListNode head)
        {
            ListNode tail = head;
            ListNode node = head.next;

            while (node.next != null)
            {
                if (node.val != 0)
                {
                    tail.val += node.val;
                }
                else
                {
                    tail = tail.next;
                    tail.val = 0;
                }

                node = node.next;
            }

            tail.next = null;

            return head;
        }
    }
}

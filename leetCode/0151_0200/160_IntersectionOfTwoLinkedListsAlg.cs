using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0151_0200
{
    public class _160_IntersectionOfTwoLinkedListsAlg
    {
        public ListNode GetIntersectionNode1(ListNode headA, ListNode headB)
        {

            ListNode nodeA = headA;
            ListNode nodeB = headB;
            HashSet<ListNode> listNodes = new HashSet<ListNode>();
            while (nodeA != null || nodeB != null)
            {
                if (nodeA != null)
                {
                    if (listNodes.Contains(nodeA))
                    {
                        return nodeA;
                    }
                    else
                    {
                        listNodes.Add(nodeA);
                    }
                    nodeA = nodeA.next;
                }
                if (nodeB != null)
                {
                    if (listNodes.Contains(nodeB))
                    {
                        return nodeB;
                    }
                    else
                    {
                        listNodes.Add(nodeB);
                    }
                    nodeB = nodeB.next;
                }
            }
            return null;
        }

      

        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            int lenA = GetLen(headA);
            int lenB = GetLen(headB);

            ListNode nodeA = headA;
            ListNode nodeB = headB;
            if (lenA > lenB)
            {
                int dec = lenA - lenB;
                while (nodeA != null && dec > 0)
                {
                    dec--;
                    nodeA = nodeA.next;
                }
            }
            else
            {
                int dec = lenB - lenA;
                while (nodeB != null && dec > 0)
                {
                    dec--;
                    nodeB = nodeB.next;
                }
            }

            while (nodeA != null && nodeB != null)
            {
                if (nodeA == nodeB)
                    return nodeA;

                nodeA = nodeA.next;
                nodeB = nodeB.next;
            }


            return null;
        }
        private int GetLen(ListNode head)
        {
            int num = 0;
            ListNode node = head;
            while (node != null)
            {
                num++;
                node = node.next;
            }
            return num;
        }

        public ListNode GetIntersectionNode3(ListNode headA, ListNode headB)
        {
            if (headA == null || headB == null)
            {
                return null;
            }
            ListNode pA = headA, pB = headB;
            while (pA != pB)
            {
                pA = pA == null ? headB : pA.next;
                pB = pB == null ? headA : pB.next;
            }
            return pA;
        }

    }
}

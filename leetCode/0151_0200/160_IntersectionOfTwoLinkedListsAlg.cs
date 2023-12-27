using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0151_0200
{
    public class _160_IntersectionOfTwoLinkedListsAlg
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {

            ListNode nodeA= headA;
            ListNode nodeB= headB;
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
    }
}

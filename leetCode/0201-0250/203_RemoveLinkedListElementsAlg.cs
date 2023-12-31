using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._201_250
{
    public class _203_RemoveLinkedListElementsAlg
    {
        public ListNode RemoveElements1(ListNode head, int val)
        {
            ListNode headNew = null;
            ListNode node = head;
            ListNode nodePrev = null;
            while (node != null)
            {

                if (node.val != val)
                {
                    if (headNew == null)
                    {
                        headNew = node;
                    }
                    nodePrev = node;
                }
                else
                {
                    if (nodePrev != null)
                    {
                        nodePrev.next = node.next;
                    }
                }

                node = node.next;

            }
            return headNew;
        }

        public ListNode RemoveElements(ListNode head, int val)
        {
            if (head == null)
            {
                return head;
            }
            head.next = RemoveElements(head.next, val);
           
            return head.val == val ? head.next : head;
        }


    }
}

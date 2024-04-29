using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0301_0350
{
    public class _328_OddEvenLinkedListAlg
    {
        public ListNode OddEvenList(ListNode head)
        {
            ListNode even = new ListNode(0);
            ListNode odd = new ListNode(0);
            ListNode oddNode = odd;
            ListNode evenNode = even;

            ListNode node = head;
            int index = 1;
            while (node != null)
            {
                if (index % 2 == 0)
                {
                    evenNode.next = new ListNode(node.val);
                    evenNode = evenNode.next;

                }
                else
                {
                    oddNode.next = new ListNode(node.val);
                    oddNode = oddNode.next;
                }
                node = node.next;
                index++;
            }
            oddNode.next = even.next;
            return odd.next;
        }
    }
}

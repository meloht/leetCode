using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2801_2850
{
    public class _2807_InsertGreatestCommonDivisorsInLinkedListAlg
    {
        public ListNode InsertGreatestCommonDivisors(ListNode head)
        {
            if (head.next == null)
                return head;

            ListNode node = head;
            while (node != null)
            {
                var temp = node.next;
                if (temp != null)
                {
                    int num = gcd(node.val, node.next.val);
                    ListNode nodeGcd = new ListNode(num);
                    node.next = nodeGcd;
                    nodeGcd.next = temp;
       
                }
                node = temp;

            }
            return head;
        }

        public int gcd(int a, int b)
        {
            return b != 0 ? gcd(b, a % b) : a;
        }

    }
}

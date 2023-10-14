using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static leetCode._1_50.AddTwoNumbersAlg;

namespace leetCode._1_50
{
    internal class SwapNodesInPairsAlg
    {
        public ListNode SwapPairs(ListNode head)
        {
            if (head == null)
                return null;

            if (head.next == null)
                return head;

            ListNode nodeRes = head.next;
            ListNode node = head;
            ListNode aheah = null;
            while (node != null)
            {
                if (node.next == null)
                    break;

                ListNode first = node;


                ListNode sencond = node.next;
                ListNode temp = sencond.next;
                sencond.next = first;
                first.next = temp;

                node = first.next;
                if (aheah != null)
                {
                    aheah.next = sencond;
                }

                aheah = first;
            }
            return nodeRes;
        }
    }
}

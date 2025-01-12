using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0701_0750
{
    public class _725_SplitLinkedListInPartsAlg
    {
        public ListNode[] SplitListToParts(ListNode head, int k)
        {
            ListNode[] result = new ListNode[k];
            int len = 0;
            var node = head;
            while (node != null)
            {
                len++;
                node = node.next;
            }
            int res = len % k;
            int avg = len / k;

            node = head;
            int i = 0;
            int count = 0;

            ListNode curr = null;
            int nodeCount = 0;
            while (node != null)
            {
                if (count == 0)
                {
                    nodeCount = res > 0 ? avg + 1 : avg;
                    if (nodeCount > 0)
                    {
                        curr = new ListNode(node.val);
                        result[i] = curr;

                        count++;
                        i++;
                        if (res > 0)
                        {
                            res--;
                        }
                    }
                }
                else
                {
                    curr.next = new ListNode(node.val);
                    curr = curr.next;
                    count++;
                }
                if (nodeCount == count)
                {
                    count = 0;
                }
                node = node.next;
            }

            return result;
        }
    }
}

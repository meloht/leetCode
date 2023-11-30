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

            ListNode nodeHead = head;
            while (true)
            {
                var nodeFi = GetNextNode(nodeHead);
                nodeHead = nodeFi.Item2;
                if (nodeFi.Item1 == false || nodeFi.Item2 == null)
                {
                    break;
                }
            }
            if (nodeHead == null)
                return null;
            ListNode nodeFirt = nodeHead;
            ListNode node = nodeFirt.next;
            while (true)
            {
                if (node != null)
                {
                    var temp = GetNextNode(node);
                    if (temp.Item1)
                    {
                        node = temp.Item2;
                        if (temp.Item2 == null)
                        {
                            nodeFirt.next = null;
                            
                            break;
                        }
                    }
                    else
                    {
                        if (temp.Item2 == null)
                        {
                            nodeFirt.next = temp.Item2;
                            break;
                        }
                        else
                        {
                            nodeFirt.next = temp.Item2;
                            nodeFirt = temp.Item2;
                        }
                        node = temp.Item2.next;
                    }
                }
                else
                {
                    break;
                }
            }
            return nodeHead;
        }

        private Tuple<bool, ListNode> GetNextNode(ListNode head)
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

            return new Tuple<bool, ListNode>(flag, nodeHead);
        }
    }
}

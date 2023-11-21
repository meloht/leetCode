using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._51_100
{
    public class _61_RotateListAlg
    {
        public ListNode RotateRight(ListNode head, int k)
        {
            if (head == null || head.next == null)
                return head;
           
            int count = 0;
            ListNode currentHead = head;
            ListNode currentLast = null;
            Queue<ListNode> queue = GetQueueNode(head);
            int num = k % queue.Count;
            while (count < num)
            {
                currentLast = queue.Dequeue();
                ListNode temp = currentLast;
                temp.next = currentHead;
                queue.Peek().next = null;
                queue.Enqueue(temp);
                currentHead = temp;
                count++;
            }
            return currentHead;
        }

        private Queue<ListNode> GetQueueNode(ListNode head)
        {

            Queue<ListNode> list = new Queue<ListNode>();
            List<ListNode> nodeList = new List<ListNode>();
            ListNode current = head;
            while (current != null)
            {
                nodeList.Add(current);
                current = current.next;
            }
            for (int i = nodeList.Count - 1; i >= 0; i--)
            {
                list.Enqueue(nodeList[i]);
            }
            return list;
        }
    }
}

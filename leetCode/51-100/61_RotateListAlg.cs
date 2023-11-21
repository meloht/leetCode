using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._51_100
{
    public class _61_RotateListAlg
    {
        public ListNode RotateRight1(ListNode head, int k)
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
        /// <summary>
        /// 循环链表
        /// </summary>
        /// <param name="head"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public ListNode RotateRight(ListNode head, int k)
        {
            if (k == 0 || head == null || head.next == null)
            {
                return head;
            }
            int n = 1;
            ListNode iter = head;
            while (iter.next != null)
            {
                iter = iter.next;
                n++;
            }
            int add = n - k % n;
            if (add == n)
            {
                return head;
            }
            iter.next = head;
            while (add > 0)
            {
                iter = iter.next;
                add--;
            }
            ListNode ret = iter.next;
            iter.next = null;
            return ret;
        }

    }
}

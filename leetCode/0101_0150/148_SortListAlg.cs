using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0101_0150
{
    public class _148_SortListAlg
    {
        public ListNode SortList1(ListNode head)
        {
            if (head == null || head.next == null)
                return head;

            List<ListNode> list = new List<ListNode>();

            ListNode curr = head;
            while (curr != null)
            {
                list.Add(curr);
                curr = curr.next;

            }
            list.Sort((x, y) => { return x.val.CompareTo(y.val); });
            for (int i = 1; i < list.Count; i++)
            {
                list[i - 1].next = list[i];
                list[i].next = null;
            }
            return list[0];
        }



        public ListNode SortList(ListNode head)
        {
            return SortList(head, null);
        }

        public ListNode SortList(ListNode head, ListNode tail)
        {
            if (head == null)
            {
                return head;
            }
            if (head.next == tail)
            {
                head.next = null;
                return head;
            }
            ListNode slow = head, fast = head;
            while (fast != tail)
            {
                slow = slow.next;
                fast = fast.next;
                if (fast != tail)
                {
                    fast = fast.next;
                }
            }
            ListNode mid = slow;
            ListNode list1 = SortList(head, mid);
            ListNode list2 = SortList(mid, tail);
            ListNode sorted = Merge(list1, list2);
            return sorted;
        }

        public ListNode Merge(ListNode head1, ListNode head2)
        {
            ListNode dummyHead = new ListNode(0);
            ListNode temp = dummyHead, temp1 = head1, temp2 = head2;
            while (temp1 != null && temp2 != null)
            {
                if (temp1.val <= temp2.val)
                {
                    temp.next = temp1;
                    temp1 = temp1.next;
                }
                else
                {
                    temp.next = temp2;
                    temp2 = temp2.next;
                }
                temp = temp.next;
            }
            if (temp1 != null)
            {
                temp.next = temp1;
            }
            else if (temp2 != null)
            {
                temp.next = temp2;
            }
            return dummyHead.next;
        }


    }
}

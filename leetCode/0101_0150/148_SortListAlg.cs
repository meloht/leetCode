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

    }
}

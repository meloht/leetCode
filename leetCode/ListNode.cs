using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode
{
    // Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }

        public override string ToString()
        {
            return $"{val}";
        }


        public static ListNode Reverse(ListNode head)
        {
            ListNode dummy = new ListNode(-1);
            while (head != null)
            {
                ListNode p = head;
                head = head.next;
                p.next = dummy.next;
                dummy.next = p;
            }
            return dummy.next;
        }


    }

    
}

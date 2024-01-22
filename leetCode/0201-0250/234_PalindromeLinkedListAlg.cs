using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._0201_0250
{
    public class _234_PalindromeLinkedListAlg
    {
        public bool IsPalindrome1(ListNode head)
        {
            if (head.next == null)
                return true;

            List<int> list = new List<int>();
            ListNode node = head;
            while (node != null)
            {
                list.Add(node.val);
                node = node.next;
            }
            int mid = list.Count / 2;
            if (list.Count % 2 == 0)
            {
                mid--;
            }
            for (int i = 0, j = list.Count - 1; i <= mid; i++, j--)
            {
                if (list[i] != list[j])
                    return false;
            }
            return true;
        }

       
        public bool IsPalindrome(ListNode head)
        {
            if (head == null)
            {
                return true;
            }

            // 找到前半部分链表的尾节点并反转后半部分链表
            ListNode firstHalfEnd = EndOfFirstHalf(head);
            ListNode secondHalfStart = ReverseList(firstHalfEnd.next);

            // 判断是否回文
            ListNode p1 = head;
            ListNode p2 = secondHalfStart;
            bool result = true;
            while (result && p2 != null)
            {
                if (p1.val != p2.val)
                {
                    result = false;
                }
                p1 = p1.next;
                p2 = p2.next;
            }

            // 还原链表并返回结果
            firstHalfEnd.next = ReverseList(secondHalfStart);
            return result;
        }

        private ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;
            ListNode curr = head;
            while (curr != null)
            {
                ListNode nextTemp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = nextTemp;
            }
            return prev;
        }

        private ListNode EndOfFirstHalf(ListNode head)
        {
            ListNode fast = head;
            ListNode slow = head;
            while (fast.next != null && fast.next.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }
            return slow;
        }
    }
}

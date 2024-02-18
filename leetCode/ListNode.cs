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

        public ListNode EndOfFirstHalf(ListNode head)
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




        public static ListNode BuildListNode(int[] arr)
        {
            if (arr.Length == 0)
                return null;
            ListNode node = new ListNode(arr[0]);
            ListNode header = node;
            for (int i = 1; i < arr.Length; i++)
            {
                node.next = new ListNode(arr[i]);
                node = node.next;
            }

            return header;
        }

        public static int[] GetLinkNodeList(ListNode head)
        {
            List<int> list = new List<int>();
            ListNode node = head;
            while (node != null)
            {
                list.Add(node.val);
                node = node.next;
            }
            return list.ToArray();
        }

        public static ListNode BuildListNode(int[] arr, int pos)
        {
            if (arr.Length == 0)
                return null;
            ListNode node = new ListNode(arr[0]);
            ListNode header = node;
            Dictionary<int, ListNode> dict = new Dictionary<int, ListNode>();
            dict.Add(0, header);
            for (int i = 1; i < arr.Length; i++)
            {
                node.next = new ListNode(arr[i]);
                node = node.next;
                dict.Add(i, node);
            }
            if (pos != -1)
            {
                dict[arr.Length - 1].next = dict[pos];
            }

            return header;
        }

        public static bool ListNodeSame(ListNode header, int[] arr)
        {
            List<int> list = new List<int>();
            ListNode node = header;
            while (node != null)
            {
                list.Add(node.val);
                node = node.next;
            }
            bool bl = arr.SequenceEqual(list.ToArray());
            return bl;
        }


    }

    
}

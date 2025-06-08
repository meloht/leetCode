using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1001_1050
{
    public class _1019_NextGreaterNodeInLinkedListAlg
    {
        public int[] NextLargerNodes(ListNode head)
        {
            int n = GetLen(head);
            int[] ans = new int[n];

            ListNode node = head;
            int idx = 0;
            Stack<ItemData> stack = new Stack<ItemData>();
            while (node != null)
            {
               
                while (stack.Count > 0 && stack.Peek().Val < node.val)
                {
                    var item = stack.Pop();
                    ans[item.Idx] = node.val;
                }
                stack.Push(new ItemData(node.val, idx));

                node = node.next;
                idx++;
            }
            return ans.ToArray();
        }

        private int GetLen(ListNode head)
        {
            ListNode node = head;
            int cnt = 0;
            while (node != null)
            {
                cnt++;
                node = node.next;
            }
            return cnt;
        }
    }

    public struct ItemData
    {
        public int Val;
        public int Idx;
        public ItemData(int val, int idx) 
        {
            this.Idx = idx;
            this.Val = val;
        }
    }
}

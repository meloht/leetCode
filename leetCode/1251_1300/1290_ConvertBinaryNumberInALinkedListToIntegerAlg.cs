using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1251_1300
{
    public class _1290_ConvertBinaryNumberInALinkedListToIntegerAlg
    {
        public int GetDecimalValue(ListNode head)
        {
            int ans = 0;
            var node = head;
            while (node != null)
            {
                ans <<= 1;
                ans |= node.val;
                node = node.next;
            }
            return ans;
        }
    }
}

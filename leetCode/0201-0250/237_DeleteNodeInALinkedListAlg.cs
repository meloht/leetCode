using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0201_0250
{
    public class _237_DeleteNodeInALinkedListAlg
    {
        public void DeleteNode(ListNode node)
        {
            ListNode temp = node.next;
            node.val = temp.val;
            node.next = temp.next;


        }
    }
}

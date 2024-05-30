using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0351_0400
{
    public class _382_LinkedListRandomNodeAlg
    {
        Random random = new Random();
        List<int> list = new List<int>();
        public _382_LinkedListRandomNodeAlg(ListNode head)
        {
            ListNode node= head;
            while (node != null) 
            {
                list.Add(node.val);
                node = node.next;
            }
        }

        public int GetRandom()
        {
            int index = random.Next(list.Count);

            return list[index];
        }
    }
}

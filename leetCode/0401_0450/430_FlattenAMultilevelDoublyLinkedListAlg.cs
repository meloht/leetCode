using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leetCode.Model.ListNodes;

namespace leetCode._0401_0450
{
    public class _430_FlattenAMultilevelDoublyLinkedListAlg
    {
        public Node Flatten(Node head)
        {
            Dfs(head);
            return head;
        }
        private Node Dfs(Node node)
        {
            Node curr = node;
            Node last = null;
            while (curr != null)
            {
                Node next = curr.next;
                if (curr.child != null)
                {
                    Node childLast = Dfs(curr.child);
                    next = curr.next;
                    curr.next = curr.child;
                    curr.child.prev = curr;

                    if (next != null)
                    {
                        childLast.next = next;
                        next.prev = childLast;

                    }

                    curr.child = null;
                    last = childLast;
                }
                else
                {
                    last = curr;
                }
                curr = next;
            }
            return last;
        }


    }
}

using leetCode._0501_0550;
using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1351_1400
{
    public class _1367_LinkedListInBinaryTreeAlg
    {
        private ListNode _head;
        public bool IsSubPath(ListNode head, TreeNode root)
        {
            _head = head;
            return Dfs(head, root);
        }

        private bool Dfs(ListNode node, TreeNode root)
        {
            if (node == null)
            {
                return true;
            }
            if (root == null)
                return false;

            return node.val==root.val&&(Dfs(node.next,root.left)||Dfs(node.next,root.right))
                ||node==_head&& (Dfs(_head, root.left) || Dfs(_head, root.right));
        }
    }
}

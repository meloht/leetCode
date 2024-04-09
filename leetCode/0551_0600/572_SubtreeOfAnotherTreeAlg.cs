using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0551_0600
{
    public class _572_SubtreeOfAnotherTreeAlg
    {
        TreeNode _subRoot;
        public bool IsSubtree(TreeNode root, TreeNode subRoot)
        {
            _subRoot = subRoot;

            return Dfs(root, subRoot);
        }
        private bool Dfs(TreeNode root, TreeNode subRoot)
        {
            if (root == null)
            {
                if (subRoot == null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (subRoot == null)
                    return false;
            }

            var tree = subRoot;
            if (root.val != subRoot.val)
            {
                tree = _subRoot;
                bool l = Dfs(root.left, tree);
                bool r = Dfs(root.right, tree);
                return l || r;
            }
            else
            {
                bool l = Dfs(root.left, tree.left);
                bool r = Dfs(root.right, tree.right);
                return l && r;
            }

        }
    }
}

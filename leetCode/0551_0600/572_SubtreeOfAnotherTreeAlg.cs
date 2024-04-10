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
        public bool IsSubtree(TreeNode root, TreeNode subRoot)
        {
            return Dfs(root, subRoot);
        }
        private bool Dfs(TreeNode root, TreeNode subRoot)
        {
            if (root == null)
                return false;

            return Check(root, subRoot) || Dfs(root.left, subRoot) || Dfs(root.right, subRoot);

        }

        private bool Check(TreeNode root, TreeNode subRoot)
        {
            if (root == null && subRoot == null)
                return true;
            if (root == null || subRoot == null || root.val != subRoot.val)
                return false;

            return Check(root.left, subRoot.left) && Check(root.right, subRoot.right);
        }
    }
}

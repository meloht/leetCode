using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leetCode.Model.BinaryTree;

namespace leetCode._0201_0250
{
    public class _236_LowestCommonAncestorOfABinaryTreeAlg
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null || root == p || root == q)
                return root;
            var left = LowestCommonAncestor(root.left, p, q);
            var right = LowestCommonAncestor(root.right, p, q);
            if (left != null && right != null)
                return root;
            if (left != null)
            {
                return left;
            }
            return right;
        }
    }
}

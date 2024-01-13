using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0201_0250
{
    public class _235_LowestCommonAncestorOfABinarySearchTreeAlg
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (p.val < root.val && q.val < root.val)
                return LowestCommonAncestor(root.left, p, q);
            if (q.val > root.val && p.val > root.val)
                return LowestCommonAncestor(root.right, p, q);
            return root;
        }
    }
}

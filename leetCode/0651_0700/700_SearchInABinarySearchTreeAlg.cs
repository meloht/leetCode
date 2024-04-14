using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0651_0700
{
    public class _700_SearchInABinarySearchTreeAlg
    {
        public TreeNode SearchBST(TreeNode root, int val)
        {
            if (root == null)
                return null;
            if(root.val==val)
                return root;
            return SearchBST(val < root.val ? root.left : root.right, val);
        }
    }
}

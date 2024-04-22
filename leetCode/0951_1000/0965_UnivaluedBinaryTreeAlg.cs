using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0951_1000
{
    public class _0965_UnivaluedBinaryTreeAlg
    {
        int val = int.MaxValue;
        public bool IsUnivalTree(TreeNode root)
        {
            if (root == null)
                return true;
            if (val == int.MaxValue)
            {
                val = root.val;
            }
            else
            {
                if (val != root.val)
                    return false;
            }

            return IsUnivalTree(root.left) && IsUnivalTree(root.right);
        }
    }
}

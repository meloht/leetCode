using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leetCode.Model.BinaryTree;

namespace leetCode._0101_0150
{
    public class _112_PathSumAlg
    {
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root == null)
                return false;

            int dec = targetSum - root.val;
            if (root.left == null && root.right == null)
            {
                if (dec == 0)
                    return true;
            }

            bool left = HasPathSum(root.left, dec);
            if (left)
                return true;

            bool right = HasPathSum(root.right, dec);
            if (right)
                return true;

            return false;
        }
    }
}

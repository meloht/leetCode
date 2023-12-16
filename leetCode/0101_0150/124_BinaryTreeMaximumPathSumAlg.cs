using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0101_0150
{
    public class _124_BinaryTreeMaximumPathSumAlg
    {
        int pre = 0, maxAns = int.MinValue;
        public int MaxPathSum(TreeNode root)
        {
            Inorder(root);
            return maxAns;
        }

        private void Inorder(TreeNode root)
        {
            if (root == null)
                return;
            Inorder(root.left);
            pre = Math.Max(pre + root.val, root.val);
            System.Diagnostics.Debug.WriteLine(root.val);
            maxAns = Math.Max(maxAns, pre);
            Inorder(root.right);
        }
    }
}

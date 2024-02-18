using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leetCode.Model.BinaryTree;

namespace leetCode._0101_0150
{
    public class _124_BinaryTreeMaximumPathSumAlg
    {
        int maxAns = int.MinValue;
        public int MaxPathSum(TreeNode root)
        {
            if (root == null)
                return 0;
            Inorder(root);
            return maxAns;
        }

        private int Inorder(TreeNode root)
        {
            if (root == null)
                return 0;
            int currentPre = root.val;

            var leftAns = Inorder(root.left);
            int tem1 = leftAns + root.val;
            if (tem1 > currentPre)
            {
                currentPre = tem1;
            }

            var rightAns = Inorder(root.right);

            int tem2 = rightAns + root.val;
            if (tem2 > root.val)
            {
                currentPre = Math.Max(tem2, currentPre);
            }
            int total = Math.Max(currentPre, tem1 + rightAns);
            maxAns = Math.Max(maxAns, total);

            return currentPre;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._101_150
{
    public class _104_MaximumDepthOfBinaryTreeAlg
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
                return 0;
            int mm = GetMax(root, 0);
            return mm;
        }

        private int GetMax(TreeNode root, int num)
        {
            if (root == null)
                return num;
            num++;
            int left = GetMax(root.left, num);
            int right = GetMax(root.right, num);

            int mm = Math.Max(left, right);
            return mm;
        }
    }
}

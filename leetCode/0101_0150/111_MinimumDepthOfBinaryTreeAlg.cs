using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0101_0150
{
    public class _111_MinimumDepthOfBinaryTreeAlg
    {
        public int MinDepth(TreeNode root)
        {
            int mm = GetMin(root, 0);
            return mm;

        }

        private int GetMin(TreeNode root, int num)
        {
            if (root == null)
                return num;
            num++;
            if (root.left == null && root.right == null)
            {
                return num;
            }

            int left = GetMin(root.left, num);
            int right = GetMin(root.right, num);

            if (root.left != null && root.right == null)
            {
                return left;
            }
            else if (root.right != null && root.left == null)
            {
                return right;
            }
            else if (root.right != null && root.left != null)
            {
                int mm = Math.Min(left, right);
                return mm;
            }
          
            return num;
        }
    }
}

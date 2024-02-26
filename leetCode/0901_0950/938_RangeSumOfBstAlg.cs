using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0901_0950
{
    public class _938_RangeSumOfBstAlg
    {
        int ans = 0;
        public int RangeSumBST1(TreeNode root, int low, int high)
        {
            Dfs(root, low, high);
            return ans;
        }
        private void Dfs(TreeNode root, int low, int high)
        {
            if (root == null)
                return;

            Dfs(root.left, low, high);

            if (root.val >= low && root.val <= high)
            {
                ans += root.val;
            }
            if (root.val > high)
                return;

            Dfs(root.right, low, high);
        }

        public int RangeSumBST(TreeNode root, int low, int high)
        {
            if (root == null)
                return 0;
            if (root.val > high)
            {
                return RangeSumBST(root.left, low, high);
            }
            if (root.val < low)
            {
                return RangeSumBST(root.right, low, high);
            }
            return root.val + RangeSumBST(root.left, low, high) + RangeSumBST(root.right, low, high);
        }
    }
}

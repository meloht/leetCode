using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0401_0450
{
    public class _404_SumOfLeftLeavesAlg
    {
        int ans = 0;
        public int SumOfLeftLeaves(TreeNode root)
        {
            Dfs(root);
            return ans;
        }
        private void Dfs(TreeNode node)
        {
            if (node == null) 
                return;

            if (node.left != null && node.left.left == null && node.left.right == null)
            {
                ans += node.left.val;
            }
            Dfs(node.left);
            Dfs(node.right);
        }
    }
}

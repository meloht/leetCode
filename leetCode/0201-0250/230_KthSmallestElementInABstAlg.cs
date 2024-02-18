using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leetCode.Model.BinaryTree;

namespace leetCode._0201_0250
{
    public class _230_KthSmallestElementInABstAlg
    {
        int index = 0;
        int K = 0;
        int ans = -1;
        public int KthSmallest1(TreeNode root, int k)
        {
            this.K = k;
            Dfs(root);

            return ans;
        }
        private void Dfs(TreeNode node)
        {
            if (node == null)
                return;
            Dfs(node.left);
            index++;
            if (index == K)
            {
                ans = node.val;
                return;
            }
            Dfs(node.right);

        }

        public int KthSmallest(TreeNode root, int k)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();
            while (root != null || stack.Count > 0)
            {
                while (root != null)
                {
                    stack.Push(root);
                    root = root.left;
                }
                root = stack.Pop();
                --k;
                if (k == 0)
                {
                    break;
                }
                root = root.right;
            }
            return root.val;
        }
    }
}

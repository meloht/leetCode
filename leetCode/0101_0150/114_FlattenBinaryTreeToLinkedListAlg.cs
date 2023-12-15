using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0101_0150
{
    public class _114_FlattenBinaryTreeToLinkedListAlg
    {
        public void Flatten1(TreeNode root)
        {
            List<TreeNode> list = new List<TreeNode>();
            Dfs(root, list);
            for (int i = 1; i < list.Count; i++)
            {
                var pre = list[i - 1];
                var next = list[i];
                pre.right = next;
                pre.left = null;
                next.left = null;
            }

        }

        private void Dfs(TreeNode node, List<TreeNode> list)
        {
            if (node == null)
                return;

            list.Add(node);
            Dfs(node.left, list);
            Dfs(node.right, list);
        }

        private TreeNode pre = null;

        public void Flatten(TreeNode root)
        {
            if (root == null)
                return;
            Flatten(root.right);
            Flatten(root.left);
            root.right = pre;
            root.left = null;
            pre = root;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leetCode.Model.BinaryTree;

namespace leetCode._0151_0200
{
    public class _199_BinaryTreeRightSideViewAlg
    {
        int dep = 0;
        public IList<int> RightSideView(TreeNode root)
        {
            var res = new List<int>();

            if (root == null)
                return res;

            Dfs(root, res, 0);

            return res;
        }

        private void Dfs(TreeNode root, List<int> res, int depth)
        {
            if (root == null)
                return;
            depth++;
            if (depth > dep)
            {
                res.Add(root.val);
                dep = depth;
            }
            Dfs(root.right, res, depth);
            Dfs(root.left, res, depth);
        }

        public IList<int> RightSideView2(TreeNode root)
        {
            List<int> list = new List<int>();
            if (root == null) return list;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                int levelCount = queue.Count;
                for (int i = 0; i < levelCount; i++)
                {
                    TreeNode node = queue.Dequeue();
                    if (i == levelCount - 1)
                    {
                        list.Add(node.val);
                    }
                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                }
            }
            return list;
        }
    }
}

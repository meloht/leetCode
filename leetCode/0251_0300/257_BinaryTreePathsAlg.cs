using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0251_0300
{
    public class _257_BinaryTreePathsAlg
    {
        public IList<string> BinaryTreePaths2(TreeNode root)
        {
            List<string> res = new List<string>();
            Dfs(root, new List<int>(), res);
            return res;
        }
        private void Dfs(TreeNode root, List<int> list, List<string> res)
        {
            if (root == null)
            {
                return;
            }
            list.Add(root.val);

            if (root.left == null && root.right == null)
            {
                res.Add(string.Join("->", list));
            }
            else
            {
                if (root.left != null)
                {
                    Dfs(root.left, list, res);
                    list.RemoveAt(list.Count - 1);
                }
                if (root.right != null)
                {
                    Dfs(root.right, list, res);
                    list.RemoveAt(list.Count - 1);
                }
            }
        }

        public IList<string> BinaryTreePaths(TreeNode root)
        {
            List<string> res = new List<string>();
            if (root == null)
                return res;
            Queue<TreeNode> nodeQueue = new Queue<TreeNode>();
            Queue<string> path = new Queue<string>();
            nodeQueue.Enqueue(root);
            path.Enqueue(root.val.ToString());
            while (nodeQueue.Count > 0)
            {
                var node = nodeQueue.Dequeue();
                var ls = path.Dequeue();
                if (node.right == null && node.left == null)
                {
                    res.Add(ls.ToString());
                }
                else
                {
                    if (node.left != null)
                    {
                        nodeQueue.Enqueue(node.left);
                        path.Enqueue($"{ls}->{node.left.val}");

                    }
                    if (node.right != null)
                    {
                        path.Enqueue($"{ls}->{node.right.val}");
                        nodeQueue.Enqueue(node.right);

                    }
                }

            }
            return res;
        }

    }
}

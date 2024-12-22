using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0651_0700
{
    public class _655_PrintBinaryTreeAlg
    {
        int dept = 0;
        public IList<IList<string>> PrintTree(TreeNode root)
        {
            Dfs(root, 0);
            int height = dept - 1;
            int n = (1 << (height + 1)) - 1;

            IList<IList<string>> list = new List<IList<string>>();

            Queue<Tuple<int, TreeNode>> queue = new Queue<Tuple<int, TreeNode>>();
            queue.Enqueue(new Tuple<int, TreeNode>((n - 1) / 2, root));
            int level = 0;
            while (queue.Count > 0)
            {
                int count = queue.Count;
                string[] ls = new string[n];
                Array.Fill(ls, "");
                for (int i = 0; i < count; i++)
                {
                    var node = queue.Dequeue();
                    int idx = node.Item1;
                    TreeNode tree = node.Item2;
                    ls[idx] = tree.val.ToString();
                    if (tree.left != null)
                    {
                        queue.Enqueue(new Tuple<int, TreeNode>(idx - GetIndex(height, level), tree.left));
                    }
                    if (tree.right != null)
                    {
                        queue.Enqueue(new Tuple<int, TreeNode>(idx + GetIndex(height, level), tree.right));
                    }
                }
                list.Add(ls);
                level++;
            }

            return list;
        }

        private int GetIndex(int height, int r)
        {
            int num = 1 << (height - r - 1);
            return num;
        }

        private void Dfs(TreeNode root, int height)
        {
            if (root == null)
                return;
            height++;
            dept = Math.Max(dept, height);
            Dfs(root.left, height);
            Dfs(root.right, height);
        }
    }
}

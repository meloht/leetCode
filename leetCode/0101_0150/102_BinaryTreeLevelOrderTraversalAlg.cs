using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leetCode.Model.BinaryTree;

namespace leetCode._101_150
{
    public class _102_BinaryTreeLevelOrderTraversalAlg
    {

        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            List<IList<int>> res = new List<IList<int>>();
            if (root == null)
                return res;
            res.Add(new int[] { root.val });

            List<TreeNode> levelNode = new List<TreeNode>();
            List<int> ints = new List<int>();
            if (root.left != null)
            {
                ints.Add(root.left.val);
                levelNode.Add(root.left);
            }
            if (root.right != null)
            {
                ints.Add(root.right.val);
                levelNode.Add(root.right);
            }
            if (ints.Count > 0)
            {
                res.Add(ints.ToArray());
                ints.Clear();
            }

            while (levelNode.Count > 0)
            {
                List<TreeNode> list = new List<TreeNode>();
                foreach (TreeNode node in levelNode)
                {
                    if (node.left != null)
                    {
                        ints.Add(node.left.val);
                        list.Add(node.left);
                    }
                    if (node.right != null)
                    {
                        ints.Add(node.right.val);
                        list.Add(node.right);
                    }
                }
                levelNode.Clear();
                if (list.Count > 0)
                {
                    levelNode.AddRange(list);
                }

                if (ints.Count > 0)
                {
                    res.Add(ints.ToArray());
                    ints.Clear();
                }
            }

            return res;
        }

    }
}

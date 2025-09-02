using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1101_1150
{
    public class _1110_DeleteNodesAndReturnForestAlg
    {
        public IList<TreeNode> DelNodes(TreeNode root, int[] to_delete)
        {
            var set = new HashSet<int>(to_delete);
            List<TreeNode> res = new List<TreeNode>();
            if (root != null && !set.Contains(root.val))
            {
                res.Add(root);
            }
            Dfs(root, null, false, set, res);
            return res;
        }

        private void Dfs(TreeNode root, TreeNode parent, bool isLeft, HashSet<int> set, List<TreeNode> res)
        {
            if (root == null)
                return;

            TreeNode left = root.left;
            TreeNode right = root.right;

            if (set.Contains(root.val))
            {
                if (parent != null) 
                {
                    if (isLeft)
                    {
                        parent.left = null;
                    }
                    else
                    {
                        parent.right = null;
                    }
                }
               
                if (root.left != null)
                {
                    if (!set.Contains(root.left.val))
                    {
                        res.Add(root.left);
                    }
                }

               

                if (root.right != null)
                {

                    if (!set.Contains(root.right.val))
                    {
                        res.Add(root.right);
                    }
                }
             
            }
            Dfs(left, root, true, set, res);
            Dfs(right, root, false, set, res);
        }

        public IList<TreeNode> DelNodes1(TreeNode root, int[] to_delete)
        {
            ISet<int> toDeleteSet = new HashSet<int>();
            foreach (int val in to_delete)
            {
                toDeleteSet.Add(val);
            }
            IList<TreeNode> roots = new List<TreeNode>();
            DFS(root, true, toDeleteSet, roots);
            return roots;
        }

        public TreeNode DFS(TreeNode node, bool isRoot, ISet<int> toDeleteSet, IList<TreeNode> roots)
        {
            if (node == null)
            {
                return null;
            }
            bool deleted = toDeleteSet.Contains(node.val);
            node.left = DFS(node.left, deleted, toDeleteSet, roots);
            node.right = DFS(node.right, deleted, toDeleteSet, roots);
            if (deleted)
            {
                return null;
            }
            else
            {
                if (isRoot)
                {
                    roots.Add(node);
                }
                return node;
            }
        }

    }
}

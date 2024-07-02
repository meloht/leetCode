using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0401_0450
{
    public class _450_DeleteNodeInABstAlg
    {
        public TreeNode DeleteNode(TreeNode root, int key)
        {
            if (root == null)
                return root;
            if (root.val == key)
            {
                if (root.right != null)
                {
                    var left = root.left;
                    var newRoot = GetLeftMin(root.right);
                    newRoot.left = left;
                    return root.right;
                }
                else
                {
                    return root.left;
                }
            }
            bool bl = Dfs(root.left, root, true, key);
            if (!bl)
            {
                Dfs(root.right, root, false, key);
            }

            return root;
        }

        private bool Dfs(TreeNode node, TreeNode parent, bool isLeft, int key)
        {
            if (node == null)
                return false;

            if (node.val == key)
            {
                if (isLeft)
                {
                    var leftt = node.left;
                    var newRoot = GetLeftMin(node.right);
                    if (newRoot != null)
                    {
                        newRoot.left = leftt;
                        parent.left = node.right;

                    }
                    else
                    {
                        parent.left = leftt;
                    }
                }
                else
                {
                    var rightt = node.right;

                    if (node.left != null)
                    {
                        parent.right = node.left;
                        var ri = GetRightMax(node.left);
                        ri.right = rightt;

                    }
                    else
                    {
                        parent.right = rightt;
                    }
                }

                return true;
            }

            bool bl = Dfs(node.left, node, true, key);
            if (!bl)
            {
                return Dfs(node.right, node, false, key);
            }
            return bl;

        }

        private TreeNode GetLeftMin(TreeNode node)
        {
            if (node == null)
                return null;

            var left = GetLeftMin(node.left);
            if (left != null)
            {
                return left;
            }

            return node;

        }
        private TreeNode GetRightMax(TreeNode node)
        {
            if (node == null)
                return null;

            var right = GetRightMax(node.right);
            if (right != null)
            {
                return right;
            }

            return node;

        }
    }
}

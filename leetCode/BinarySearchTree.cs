using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode
{
    public class BinarySearchTree
    {
        public TreeNode root;

        public void Insert(int?[] values)
        {
            foreach (var val in values)
            {
                if (val.HasValue)
                {
                    root = InsertRec(root, val.Value);
                }
            }
        }

        private TreeNode InsertRec(TreeNode root, int val)
        {
            if (root == null)
            {
                root = new TreeNode(val);
                return root;
            }

            if (val < root.val)
            {
                root.left = InsertRec(root.left, val);
            }
            else if (val > root.val)
            {
                root.right = InsertRec(root.right, val);
            }

            return root;
        }

        public void InorderTraversal(TreeNode node)
        {
            if (node != null)
            {
                InorderTraversal(node.left);
                Console.Write(node.val + " ");
                InorderTraversal(node.right);
            }
        }


    }
}

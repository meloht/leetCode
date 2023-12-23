using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0101_0150
{
    public class _145_BinaryTreePostorderTraversalAlg
    {
        public IList<int> PostorderTraversal1(TreeNode root)
        {
            List<int> list = new List<int>();
            Postorder(root, list);
            return list;
        }
        private void Postorder(TreeNode root, List<int> list)
        {
            if (root == null)
                return;
            Postorder(root.left, list);
            Postorder(root.right, list);
            list.Add(root.val);
        }

        public IList<int> PostorderTraversal(TreeNode root)
        {
            List<int> list = new List<int>();
            if (root == null)
                return list;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode node = root;
            TreeNode pre = null;
            while (node != null || stack.Count > 0)
            {
                while (node != null)
                {
                    stack.Push(node);
                    node = node.left;
                }
                node = stack.Pop();
                if (node.right == null || node.right == pre)
                {
                    list.Add(node.val);
                    pre = node;
                    node = null;
                }
                else
                {
                    stack.Push(node);
                    node = node.right;
                }

            }
            return list;

        }
    }
}

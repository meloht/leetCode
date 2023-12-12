using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode
{
    public class BinaryTreeBuilder
    {
        private int index = 0;

        public TreeNode BuildTree(int?[] values)
        {
            return Construct(values);
        }

        private TreeNode Construct(int?[] values)
        {
            if (index >= values.Length || !values[index].HasValue)
            {
                index++;
                return null;
            }

            TreeNode node = new TreeNode(values[index].Value);
            index++;

            node.left = Construct(values);
            node.right = Construct(values);

            return node;
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

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

        public TreeNode BuildTree(int?[] preorder)
        {
            return Construct(preorder);
        }

        private TreeNode Construct(int?[] preorder)
        {
            if (index >= preorder.Length || preorder[index] == null)
            {
                index++;
                return null;
            }
 
            TreeNode node = new TreeNode(preorder[index++].Value);
            node.left = Construct(preorder);
            node.right = Construct(preorder);

            return node;
        }
    }
}

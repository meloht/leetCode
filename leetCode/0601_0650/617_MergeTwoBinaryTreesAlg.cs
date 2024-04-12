using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0601_0650
{
    public class _617_MergeTwoBinaryTreesAlg
    {
        public TreeNode MergeTrees(TreeNode root1, TreeNode root2)
        {
            if (root1 != null && root2 != null)
            {
                TreeNode node = new TreeNode(root1.val + root2.val);
                node.left = MergeTrees(root1.left, root2.left);
                node.right = MergeTrees(root1.right, root2.right);
                return node;
            }
            else if (root1 != null)
            {
                return root1;
            }
            else if (root2 != null)
            {
                return root2;
            }
            return null;
        }
       

    }
}

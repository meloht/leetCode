using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0601_0650
{
    public class _606_ConstructStringFromBinaryTreeAlg
    {

        public string Tree2str(TreeNode root)
        {
            if (root == null)
                return "";
            if (root.left == null && root.right == null)
            {
                return root.val.ToString();
            }
            string left = Tree2str(root.left);
            string right = Tree2str(root.right);
            if (right == "")
            {
                return $"{root.val}({left})";
            }
            return $"{root.val}({left})({right})";
        }
    }
}

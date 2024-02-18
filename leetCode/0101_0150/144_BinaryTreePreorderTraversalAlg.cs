using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leetCode.Model.BinaryTree;

namespace leetCode._0101_0150
{
    public class _144_BinaryTreePreorderTraversalAlg
    {
        public IList<int> PreorderTraversal(TreeNode root)
        {
            List<int> list = new List<int>();
            if (root == null)
                return list;
            PreTraval(list, root);
            return list;
        }
        private void PreTraval(List<int> list, TreeNode root)
        {
            if (root == null)
                return;
            list.Add(root.val);
            PreTraval(list, root.left);
            PreTraval(list, root.right);
        }
    }
}

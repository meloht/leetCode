using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetCode._1251_1300
{
    public class _1261_find_elements_in_a_contaminated_binary_tree
    {
        public class FindElements
        {
            private HashSet<int> _set;
            public FindElements(TreeNode root)
            {
                _set = new HashSet<int>();
                root.val = 0;
                Dfs(root);
              
            }
            private void Dfs(TreeNode node)
            {
                if (node == null)
                {
                    return;
                }
                int x = node.val;
                _set.Add(x);
                if (node.left != null)
                {
                    node.left.val = x * 2 + 1;

                    Dfs(node.left);
                }
                if (node.right != null)
                {
                    node.right.val = x * 2 + 2;
                    Dfs(node.right);
                }
            }

            public bool Find(int target)
            {
                return _set.Contains(target);
            }

            
        }

    }
}

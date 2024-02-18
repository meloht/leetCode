using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leetCode.Model.BinaryTree;

namespace leetCode._0151_0200
{
    public class _173_BinarySearchTreeIteratorAlg
    {
        public class BSTIterator
        {
            
            Stack<TreeNode> stk = new Stack<TreeNode>();
            TreeNode node;
            public BSTIterator(TreeNode root)
            {
                node = root;
               
            }

            public int Next()
            {
                if (node != null || stk.Count > 0)
                {
                    while (node != null)
                    {
                        stk.Push(node);
                        node = node.left;
                    }
                    node = stk.Pop();
                    int res = node.val;
                    node = node.right;
                    return res;
                }
                return 0;
            }

            public bool HasNext()
            {
                if (node != null || stk.Count > 0)
                    return true;
                return false;
            }
        }


      
    }
}

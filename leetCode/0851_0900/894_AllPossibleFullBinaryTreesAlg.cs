using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0851_0900
{
    public class _894_AllPossibleFullBinaryTreesAlg
    {
        public IList<TreeNode> AllPossibleFBT(int n)
        {
            List<TreeNode> list = new List<TreeNode>();
            if (n % 2 == 0)
                return list;
            if (n == 1)
            {
                list.Add(new TreeNode(0));
                return list;
            }

            for (int i = 1; i < n; i += 2)
            {
                IList<TreeNode> left = AllPossibleFBT(i);
                IList<TreeNode> right = AllPossibleFBT(n - 1 - i);
                foreach (TreeNode leftSubtree in left)
                {
                    foreach (TreeNode rightSubtree in right)
                    {
                        TreeNode root = new TreeNode(0, leftSubtree, rightSubtree);
                        list.Add(root);
                    }
                }
            }

            return list;
        }

      
       
    }
}

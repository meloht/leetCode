using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2201_2250
{
    public class _2236_RootEqualsSumOfChildrenAlg
    {
        public bool CheckTree(TreeNode root)
        {
            if (root.val == root.left.val + root.right.val)
                return true;
            return false;

        }
    }
}

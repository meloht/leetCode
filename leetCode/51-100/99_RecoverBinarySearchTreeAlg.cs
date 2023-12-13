using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._51_100
{
    public class _99_RecoverBinarySearchTreeAlg
    {
        public void RecoverTree(TreeNode root)
        {
            List<int> result = new List<int>();
            MidOrder(root, result);
            result.Sort();

            MidOrderSet(root, result);

        }
      
        private void MidOrder(TreeNode root, List<int> result)
        {
            if (root == null)
                return;
            MidOrder(root.left, result);
            result.Add(root.val);
            MidOrder(root.right, result);
          
        }

        private void MidOrderSet(TreeNode root, List<int> result)
        {
            if (root == null)
                return;
            MidOrderSet(root.left, result);
            root.val = result[0];
            result.RemoveAt(0);
            MidOrderSet(root.right, result);
        }
 
    }
}

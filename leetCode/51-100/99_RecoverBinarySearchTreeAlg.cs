using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._51_100
{
    public class _99_RecoverBinarySearchTreeAlg
    {
        int index = 0;
        public void RecoverTree(TreeNode root)
        {
            List<int> result = new List<int>();
            MidOrder(root, result);
            result.Sort();

            MidOrderSet(root, result.ToArray());

        }
      
        private void MidOrder(TreeNode root, List<int> result)
        {
            if (root == null)
                return;
            MidOrder(root.left, result);
            result.Add(root.val);
            MidOrder(root.right, result);
          
        }

        private void MidOrderSet(TreeNode root, int[] result)
        {
            if (root == null)
                return;
            MidOrderSet(root.left, result);
            root.val = result[index];
            index++;
            MidOrderSet(root.right, result);
        }
 
    }
}

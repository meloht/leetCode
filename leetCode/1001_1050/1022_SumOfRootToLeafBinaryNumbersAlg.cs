using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1001_1050
{

    public class _1022_SumOfRootToLeafBinaryNumbersAlg
    {
        int ans = 0;
        public int SumRootToLeaf(TreeNode root)
        {
            Dfs(root, 0);
            return ans;
        }

        private void Dfs(TreeNode node, int num)
        {
            if (node == null)
                return ;
      
            if (num > 0)
            {
                num = num << 1;
            }
            num += node.val;
            if (node.left == null && node.right == null)
            {
                ans += num;
            }
            Dfs(node.left, num);
            Dfs(node.right, num);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0201_0250
{
    public class _222_CountCompleteTreeNodesAlg
    {
        int num = 0;
        public int CountNodes(TreeNode root)
        {
            Dfs(root);
            return num; 
        }
        private void Dfs(TreeNode node)
        {
            if (node == null)
                return;
            num++;
            Dfs(node.left);
            Dfs(node.right);
        }
    }
}

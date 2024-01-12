using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._0201_0250
{
    public class _222_CountCompleteTreeNodesAlg
    {
        int num = 0;
        public int CountNodes1(TreeNode root)
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

        public int CountNodes(TreeNode root)
        {
            if (root == null)
                return 0;
            int level = 0;
            TreeNode node = root;
            while (node.left != null)
            {
                level++;
                node = node.left;
            }

            int low = 1 << level;
            int high = (1 << (level + 1)) - 1;
            while (low < high)
            {
                int mid = (high + low + 1) / 2 ;
                if (Exists(root, level, mid))
                {
                    low = mid;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return low;
        }
        public bool Exists(TreeNode root, int level, int k)
        {
            int bits = 1 << (level - 1);
            TreeNode node = root;
            while (node != null && bits > 0)
            {
                if ((bits & k) == 0)
                {
                    node = node.left;
                }
                else
                {
                    node = node.right;
                }
                bits >>= 1;
            }
            return node != null;
        }


    }
}

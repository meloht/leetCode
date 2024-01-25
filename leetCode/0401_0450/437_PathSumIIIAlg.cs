using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0401_0450
{
    public class _437_PathSumIIIAlg
    {
        int count = 0;
        int t = 0;
        Dictionary<long, int> prefix = new Dictionary<long, int>();
        public int PathSum(TreeNode root, int targetSum)
        {
            if (root == null)
            {
                return 0;
            }
            t = targetSum;
            prefix.Add(0, 1);
            Dfs(root, root.val);
            return count;
        }

        private void Dfs(TreeNode root,long val)
        {
            if (prefix.ContainsKey(val - t))
            {
                count += prefix[val - t];
            }

            if (prefix.ContainsKey(val))
            {
                prefix[val]++;
            }
            else
            {
                prefix.Add(val, 1);
            }

            if (root.left != null)
            {
                Dfs(root.left, val + root.left.val);
            }
            if (root.right != null)
            {
                Dfs(root.right, val + root.right.val);
            }
           
            prefix[val]--;

        }

     

        public int PathSum2(TreeNode root, int targetSum)
        {
            if (root == null)
            {
                return 0;
            }
            Dfs1(root,targetSum);
            return count;
        }
        private void Dfs1(TreeNode node, int targetSum)
        {
            if (node == null)
            {
                return ;
            }
            Dfs2(node, targetSum, node.val);
            Dfs1(node.left,targetSum);
            Dfs1(node.right, targetSum);
        }
        private void Dfs2(TreeNode node, int targetSum, long sum)
        {
            if (sum == targetSum)
            {
                count++;
            }
           
            if (node.left != null)
            {
                Dfs2(node.left, targetSum, sum + node.left.val);
            }
            if (node.right != null)
            {
                Dfs2(node.right, targetSum, sum + node.right.val);
            }
           
        }
    }
}

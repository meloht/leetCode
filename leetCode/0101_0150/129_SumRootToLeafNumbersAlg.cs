using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0101_0150
{
    public class _129_SumRootToLeafNumbersAlg
    {
        private int total = 0;
        public int SumNumbers(TreeNode root)
        {
            Reduce(root, 0);
            return total;
        }

       

        private void Reduce(TreeNode node, int num)
        {
            if (node == null)
            {
                return;
            }
            if (node.left == null && node.right == null)
            {
                int n = num + node.val;
                total += n;

            }
            else
            {
                int n = (num + node.val) * 10;
                Reduce(node.left, n);
                Reduce(node.right, n);
            }
        }

        private void Dfs(TreeNode node, List<int> nums)
        {
            if (node == null)
            {
                return;
            }
            nums.Add(node.val);
            if (node.left == null && node.right == null)
            {
                string ss = string.Join("", nums);
                int nn = int.Parse(ss);
                total += nn;

            }
            else
            {
                Dfs(node.left, new List<int>(nums));
                Dfs(node.right, new List<int>(nums));
            }
        }
    }
}

using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0501_0550
{
    public class _508_MostFrequentSubtreeSumAlg
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        int max = 0;
        public int[] FindFrequentTreeSum(TreeNode root)
        {
            Dfs(root);
            List<int> list = new List<int>();

            foreach (var item in dict)
            {
                if (item.Value == max)
                {
                    list.Add(item.Key);
                }
            }
            return list.ToArray(); 
        }
        private int Dfs(TreeNode root)
        {
            if (root == null)
                return 0;
            
            int sum = root.val+ Dfs(root.left) + Dfs(root.right);
            if (dict.ContainsKey(sum))
            {
                dict[sum]++;
                max=Math.Max(max, dict[sum]);
            }
            else
            {
                dict.Add(sum, 1);
                max = Math.Max(max, 1);
            }
            return sum;
        }
    }
}

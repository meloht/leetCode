using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0651_0700
{
    public class _652_FindDuplicateSubtreesAlg
    {
        Dictionary<string, int> dict = new Dictionary<string, int>();
        List<TreeNode> ans = new List<TreeNode>();
        public IList<TreeNode> FindDuplicateSubtrees(TreeNode root)
        {
            Dfs(root);

            return ans;
        }

        private string Dfs(TreeNode root)
        {
            if (root == null)
            {
                return "*";
            }
            StringBuilder sb = new StringBuilder();
            sb.Append(root.val).Append("_");
            sb.Append(Dfs(root.left)).Append(Dfs(root.right));

            string key = sb.ToString();

            if (dict.ContainsKey(key))
            {
                dict[key]++;
            }
            else
            {
                dict.Add(key, 1);
            }
            if (dict[key] == 2)
            {
                ans.Add(root);
            }
            return key;
        }
    }
}

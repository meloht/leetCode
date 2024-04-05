using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0501_0550
{
    public class _501_FindModeInBinarySearchTreeAlg
    {
        public int[] FindMode1(TreeNode root)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            Dfs(root, dict);
            List<int> list = new List<int>();
            int max = dict.Values.Max();
            foreach (var item in dict)
            {
                if (item.Value == max)
                {
                    list.Add(item.Key);
                }

            }
            return list.ToArray();
        }
        private void Dfs(TreeNode node, Dictionary<int, int> dict)
        {
            if (node == null)
                return;
            if (dict.ContainsKey(node.val))
            {
                dict[node.val]++;
            }
            else
            {
                dict.Add(node.val, 1);
            }
            Dfs(node.left, dict);
            Dfs(node.right, dict);
        }

        List<int> res = new List<int>();
        int baseNum = 0;
        int count = 0;
        int maxCount = 0;
        public int[] FindMode(TreeNode root)
        {
            Dfs(root);
            return res.ToArray();
        }

        private void Dfs(TreeNode node)
        {
            if (node == null)
                return;
            Dfs(node.left);
            Update(node.val);
            Dfs(node.right);
        }

        private void Update(int val) 
        {
            if (val == baseNum)
            {
                count++;
            }
            else 
            {
                count = 1;
                baseNum = val;

            }
            if (count == maxCount)
            {
                res.Add(baseNum);
            }
            else if (count > maxCount)
            {
                maxCount = count;
                res.Clear();
                res.Add(baseNum);
            }
        }


    }
}

using leetCode.Model.NTreeNode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0551_0600
{
    public class _559_MaximumDepthOfNAryTreeAlg
    {
        int ans = 0;
        public int MaxDepth(Node root)
        {
            Dfs(root, 0);
            return ans;
        }
        private void Dfs(Node root,int dept)
        {
            if (root == null)
                return;
            dept++;
            if (dept > ans)
            {
                ans = dept;
            }
            if (root.children == null)
                return;
            foreach (var item in root.children)
            {
                Dfs(item, dept);
            }
        }
    }
}

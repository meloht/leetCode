using leetCode.Model.NTreeNode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0551_0600
{
    public class _589_NAryTreePreorderTraversalAlg
    {
        public IList<int> Preorder(Node root)
        {
            List<int> list = new List<int>();
            Dfs(root, list);
            return list;
        }

        private void Dfs(Node root, List<int> list)
        {
            if (root == null)
                return;
            list.Add(root.val);
            if (root.children != null)
            {
                foreach (var item in root.children)
                {
                    Dfs(item, list);
                }
            }

        }
    }
}

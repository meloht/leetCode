using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace leetCode._51_100
{
    public class _95_UniqueBinarySearchTreesIIAlg
    {
        private int index = 0;
        private TreeNode Construct(int?[] preorder)
        {
            if (index >= preorder.Length || preorder[index] == null)
            {
                index++;
                return null;
            }

            TreeNode node = new TreeNode(preorder[index].Value);
            index++;
            node.left = Construct(preorder);
            node.right = Construct(preorder);

            return node;
        }

        public IList<TreeNode> GenerateTrees(int n)
        {
            List<List<TreeNode>> dpTree = new List<List<TreeNode>>();

            for (int i = 0; i <= n; i++)
            {
                List<TreeNode> ls = new List<TreeNode>();
                dpTree.Add(ls);
            }
            index = 0;
            TreeNode node1 = Construct(new int?[] { 1 });
            dpTree[1] = new List<TreeNode>() { node1 };

            if (n == 1)
            {
                return dpTree[1];
            }
            index = 0;
            TreeNode node21 = Construct(new int?[] { 1, null, 2 });
            index = 0;
            TreeNode node22 = Construct(new int?[] { 2, 1 });
            dpTree[2] = new List<TreeNode>() { node21, node22 };

            if (n == 2)
            {
                return dpTree[2];
            }

            for (int i = 3; i <= n; i++)
            {
                List<TreeNode> ans = new List<TreeNode>();
                for (int j = 1; j <= i; j++)
                {
                    List<TreeNode> resLeft = new List<TreeNode>();
                    var left = dpTree[j - 1];
                    var right = dpTree[i - j];

                    bool blLeft = left != null && left.Count > 0;
                    bool blRight = right != null && right.Count > 0;

                    if (blLeft)
                    {
                        foreach (var item in left)
                        {
                            TreeNode root = new TreeNode(j);
                            TreeNode node = new TreeNode(item.val);
                            AddTreeVal(item, node, 0);
                            root.left = item;
                            resLeft.Add(root);
                        }
                        if (blRight == false)
                        {
                            ans.AddRange(resLeft);
                        }
                    }

                    if (blRight)
                    {
                        if (blLeft == false)
                        {
                            List<TreeNode> res = new List<TreeNode>();
                            foreach (var item in right)
                            {
                                TreeNode root = new TreeNode(j);
                                TreeNode node = new TreeNode(item.val);
                                AddTreeVal(item, node, j);
                                root.right = node;
                                res.Add(root);
                            }
                            ans.AddRange(res);
                        }
                        else
                        {
                            List<TreeNode> res = new List<TreeNode>();
                            foreach (var root in resLeft)
                            {
                                foreach (var item in right)
                                {
                                    TreeNode newRoot = new TreeNode(root.val);
                                    AddTreeVal(root, newRoot, 0);

                                    TreeNode node = new TreeNode(item.val);
                                    AddTreeVal(item, node, j);
                                    newRoot.right = node;
                                    res.Add(newRoot);
                                }
                            }
                            ans.AddRange(res);
                        }
                    }
                }
                dpTree[i] = ans;
            }

            return dpTree[n];
        }


        private void AddTreeVal(TreeNode node, TreeNode nodeNew, int n)
        {
            if (node != null)
            {
                nodeNew.val = node.val + n;
                if (node.left != null)
                {
                    nodeNew.left = new TreeNode(node.left.val);
                    AddTreeVal(node.left, nodeNew.left, n);
                }
                if (node.right != null)
                {
                    nodeNew.right = new TreeNode(node.right.val);
                    AddTreeVal(node.right, nodeNew.right, n);
                }
            }
        }






    }
}

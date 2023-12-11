using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._51_100
{
    public class _95_UniqueBinarySearchTreesIIAlg
    {
        public IList<TreeNode> GenerateTrees(int n)
        {

            int?[][][] dp = new int?[n + 1][][];

            int?[] arr1 = new int?[] { 1 };
            int?[] arr2 = new int?[] { 1, null, 2 };
            int?[] arr3 = new int?[] { 2, 1 };
            dp[1] = new List<int?[]>() { arr1 }.ToArray();
            dp[2] = new List<int?[]>() { arr2, arr3 }.ToArray();

            for (int i = 3; i <= n; i++)
            {
                List<int?[]> ans = new List<int?[]>();
                for (int j = 1; j <= i; j++)
                {

                    List<int?[]> res = new List<int?[]>();
                    List<int?[]> temp = new List<int?[]>();
                    var left = dp[j - 1];
                    if (left != null && left.Length > 0)
                    {

                        foreach (var item in left)
                        {
                            List<int?> ls = new List<int?>();
                            ls.Add(j);
                            ls.AddRange(item);
                            temp.Add(ls.ToArray());
                        }

                    }
                    else
                    {
                        int?[] leArr = { j, null };
                        temp.Add(leArr);
                    }
                    var right = dp[i - j];

                    if (right != null && right.Length > 0)
                    {
                        foreach (var leftItem in temp)
                        {
                            foreach (var item in right)
                            {
                                List<int?> ls = new List<int?>();
                                var addItem = GetAddArr(item, j);
                                ls.AddRange(leftItem);
                                ls.AddRange(addItem);
                                res.Add(ls.ToArray());
                            }
                        }

                    }
                    else
                    {
                        res.AddRange(temp);
                    }

                    ans.AddRange(res);


                }
                dp[i] = ans.ToArray();
            }

            var trees = BuildTree(dp[n]);
            return trees;
        }
        private IList<TreeNode> BuildTree(int?[][] arr)
        {
            List<TreeNode> ls = new List<TreeNode>();
            foreach (var item in arr)
            {
                index = 0;
                var tree = Construct(item);
                ls.Add(tree);
            }
            return ls;
        }

        private int?[] GetAddArr(int?[] arr, int n)
        {
            List<int?> list = new List<int?>(arr.Length);
            foreach (var item in arr)
            {
                if (item != null)
                {
                    list.Add(item.Value + n);
                }
                else
                {
                    list.Add(null);
                }
            }
            return list.ToArray();
        }
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


    }
}

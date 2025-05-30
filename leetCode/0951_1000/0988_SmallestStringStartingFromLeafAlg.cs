using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0951_1000
{
    public class _0988_SmallestStringStartingFromLeafAlg
    {
        string ans = null;
        public string SmallestFromLeaf(TreeNode root)
        {
            Dfs(root, "");
            var ch = ans.ToCharArray();
            Array.Reverse(ch);
            return new string(ch);
        }
        private void Dfs(TreeNode root, string s)
        {
            if (root == null)
            {
                return;
            }

            string ch = s + char.ToString((char)(root.val + 'a'));
            if (root.left == null && root.right == null)
            {
                if (ans == null)
                {
                    ans = ch;
                    return;
                }
                int bl = 0;
                for (int i = ch.Length - 1, j = ans.Length - 1; i >= 0 && j >= 0; i--, j--)
                {
                    if (ch[i] < ans[j])
                    {
                        bl = -1;
                        break;
                    }
                    else if (ch[i] > ans[j])
                    {
                        bl = 1;
                        break;
                    }

                }
                if (bl == 0 && ch.Length < ans.Length)
                {
                    bl = -1;
                }
                if (bl == -1)
                {
                    ans = ch;
                }
                return;
            }

            Dfs(root.left, ch);
            Dfs(root.right, ch);


        }



    }
}

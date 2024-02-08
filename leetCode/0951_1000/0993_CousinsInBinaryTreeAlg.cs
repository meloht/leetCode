using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0951_1000
{
    public class _0993_CousinsInBinaryTreeAlg
    {
        int xDept = -1;
        int yDept = -1;
        int X = 0;
        int Y = 0;
        public bool IsCousins(TreeNode root, int x, int y)
        {
            this.X = x; this.Y = y;
            Dfs(root, 0);
            if (this.xDept == -1||this.yDept==-1)
                return false;
            if (this.xDept == -2 || this.yDept == -2)
                return false;

            return this.xDept==this.yDept;
        }
        private void Dfs(TreeNode root,int dept)
        {
            if (root == null)
                return;
            dept++;
            if (root.val == this.Y)
            {
                this.yDept = dept;
            }
            if (root.val == this.X)
            {
                this.xDept = dept;
            }

            if (this.xDept != -1 && this.yDept != -1)
                return;
          
            Dfs(root.left, dept);
            Dfs(root.right, dept);
            if (root.left != null && root.right != null)
            {
                if (root.left.val == this.X && this.Y == root.right.val)
                {
                    this.xDept = -2;
                    this.yDept = -2;
                }
               else if (root.right.val == this.X && this.Y == root.left.val)
                {
                    this.xDept = -2;
                    this.yDept = -2;
                }
            }
        }
    }
}

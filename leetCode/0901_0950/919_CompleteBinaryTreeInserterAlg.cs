using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0901_0950
{
    public class _919_CompleteBinaryTreeInserterAlg
    {
        public class CBTInserter
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            int i = 0;
            int count = 0;
            TreeNode _root;
            TreeNode curr;
            public CBTInserter(TreeNode root)
            {
                _root = root;
                queue.Enqueue(root);
                while (queue.Count > 0)
                {
                    count = queue.Count;
                    for (i = 0; i < count; i++)
                    {
                        curr = queue.Dequeue();
                       
                        if (curr.left != null)
                        {
                            queue.Enqueue(curr.left);
                        }
                        if (curr.right != null)
                        {
                            queue.Enqueue(curr.right);
                        }
                        if (curr.left == null || curr.right == null)
                        {
                            return;
                        }
                    }
                }
            }

            public int Insert(int val)
            {
                int num = curr.val;
                if (curr.left == null)
                {
                    curr.left = new TreeNode(val);
                    queue.Enqueue(curr.left);
                   
                }
                else
                {
                    curr.right = new TreeNode(val);
                    queue.Enqueue(curr.right);
                    if (i + 1 < count)
                    {
                        i++;
                        curr = queue.Dequeue();
                    }
                    else
                    {
                        count = queue.Count;
                        i = 0;
                        curr = queue.Dequeue();
                    }
                  
                }

                return num;


            }

            public TreeNode Get_root()
            {
                return _root;
            }
        }
    }
}

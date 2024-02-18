using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using leetCode.Model.BinaryTree;

namespace leetCode._101_150
{
    public class _103_BinaryTreeZigzagLevelOrderTraversalAlg
    {
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            List<IList<int>> res = new List<IList<int>>();
            if (root == null)
                return res;

            Stack<TreeNode> queue = new Stack<TreeNode>();
            queue.Push(root);
            bool isLeft = true;
            while (queue.Count > 0)
            {
                List<int> list = new List<int>();
                Stack<TreeNode> queueTemp = new Stack<TreeNode>();
                int count = queue.Count;
              
                for (int i = 0; i < count; i++)
                {
                    var node = queue.Pop();
                    list.Add(node.val);
                    if (isLeft)
                    {
                        if (node.left != null)
                        {
                            queueTemp.Push(node.left);
                        }
                        if (node.right != null)
                        {
                            queueTemp.Push(node.right);
                        }
                    }
                    else
                    {
                        if (node.right != null)
                        {
                            queueTemp.Push(node.right);
                        }
                        if (node.left != null)
                        {
                            queueTemp.Push(node.left);
                        }
                    }
                   
                }
                isLeft = !isLeft;
                queue.Clear();
                queue = queueTemp;

                res.Add(list);
            }

            return res;
        }
    }
}

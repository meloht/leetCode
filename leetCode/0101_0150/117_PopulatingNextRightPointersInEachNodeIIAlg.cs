using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0101_0150
{
    public class _117_PopulatingNextRightPointersInEachNodeIIAlg
    {
        public Node Connect(Node root)
        {
            if (root == null)
            {
                return root;
            }
            if (root.left != null)
            {

                if (root.right != null)
                {
                    root.left.next = root.right;
                    var next = GetNext(root.next);
                    if (next != null)
                    {
                        if (next.left != null)
                        {
                            root.right.next = next.left;
                        }
                        else
                        {
                            root.right.next = next.right;
                        }
                    }
                }
                else
                {
                    if (root.next != null)
                    {
                        var next = GetNext(root.next);
                        if (next!=null)
                        {
                            if (next.left != null)
                            {
                                root.left.next = next.left;
                            }
                            else
                            {
                                root.left.next = next.right;
                            }
                        }
                       
                    }
                }
                Connect(root.left);
                Connect(root.right);
            }
            else
            {

                if (root.next != null && root.right != null)
                {
                    var next = GetNext(root.next);
                    if (next != null)
                    {
                        if (next.left != null)
                        {
                            root.right.next = next.left;
                        }
                        else
                        {
                            root.right.next = next.right;
                        }
                    }
                       
                }
                Connect(root.right);
            }
            return root;
        }

        private Node GetNext(Node node)
        {
            var temp = node;
            while (temp != null && temp.right == null && temp.left == null)
            {
                temp = temp.next;

            }
            return temp;
        }


     
    }
}

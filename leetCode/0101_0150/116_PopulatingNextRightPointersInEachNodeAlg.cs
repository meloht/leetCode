﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace leetCode._0101_0150
{
    public class _116_PopulatingNextRightPointersInEachNodeAlg
    {
        public NodeThree Connect(NodeThree root)
        {
            if (root == null)
                return root;

            Queue<NodeThree> queue = new Queue<NodeThree>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                int count = queue.Count;
                NodeThree pre = null;
                for (int i = 0; i < count; i++)
                {
                    var node = queue.Dequeue();
                    if (node.left != null && node.right != null)
                    {
                        if (pre != null)
                        {
                            pre.next = node.left;
                        }
                        node.left.next = node.right;
                        queue.Enqueue(node.left);
                        queue.Enqueue(node.right);
                        pre = node.right;
                    }
                }
            }
            return root;
        }

        public NodeThree Connect2(NodeThree root)
        {
            if (root == null)
            {
                return root;
            }

            // 从根节点开始
            NodeThree leftmost = root;

            while (leftmost.left != null)
            {

                // 遍历这一层节点组织成的链表，为下一层的节点更新 next 指针
                NodeThree head = leftmost;

                while (head != null)
                {

                    // CONNECTION 1
                    head.left.next = head.right;

                    // CONNECTION 2
                    if (head.next != null)
                    {
                        head.right.next = head.next.left;
                    }

                    // 指针向后移动
                    head = head.next;
                }

                // 去下一层的最左的节点
                leftmost = leftmost.left;
            }

            return root;
        }

        public NodeThree Connect3(NodeThree root)
        {
            if (root == null)
            {
                return root;
            }
            if (root.left != null)
            {
                root.left.next = root.right;
                if (root.next != null)
                {
                    if (root.next.left != null)
                    {
                        root.right.next = root.next.left;
                    }
                    else
                    {
                        root.right.next = root.next.right;
                    }
                }
              
                Connect3(root.left);
                Connect3(root.right);
            }
            else
            {
                if (root.next != null)
                {
                    if (root.next.left != null)
                    {
                        root.right.next = root.next.left;
                    }
                    else
                    {
                        root.right.next = root.next.right;
                    }
                }
                Connect3(root.right);
            }
            return root;
        }

    }
}

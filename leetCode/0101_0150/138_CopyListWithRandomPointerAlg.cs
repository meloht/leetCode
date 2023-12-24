using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._0101_0150
{
    public class _138_CopyListWithRandomPointerAlg
    {
        public Node CopyRandomList(Node head)
        {
            if (head == null)
                return null;
            Dictionary<Node, Node> dict = new Dictionary<Node, Node>();

            Node node = head;
            while (node != null)
            {
                Node node1 = new Node(node.val);
                dict.Add(node, node1);
                node = node.next;
            }
            foreach (var item in dict)
            {
                if (item.Key.random != null)
                {
                    item.Value.random = dict[item.Key.random];
                }
                if (item.Key.next != null)
                {
                    item.Value.next= dict[item.Key.next];
                }
               
            }

            return dict[head];
        }
        public class Node
        {
            public int val;
            public Node next;
            public Node random;

            public Node(int _val)
            {
                val = _val;
                next = null;
                random = null;
            }

            public static Node Build(int?[][] arr)
            {
                if (arr.Length == 0)
                    return null;
                Dictionary<int, Node> dict = new Dictionary<int, Node>();
                Node node = new Node(arr[0][0].Value);
                dict.Add(0, node);
                for (int i = 1; i < arr.Length; i++)
                {
                    Node next = new Node(arr[i][0].Value);
                    dict[i - 1].next = next;
                    dict.Add(i, next);
                }

                for (int i = 0; i < arr.Length; i++)
                {
                    var rn = arr[i][1];
                    if (rn != null)
                    {
                        dict[i].random = dict[rn.Value];
                    }
                }
                return node;

            }

            public static int?[][] GetList(Node head)
            {
                List<int?[]> list = new List<int?[]>();
                Node node = head;
                Dictionary<Node, int> dict = new Dictionary<Node, int>();
                List<Node> listNode = new List<Node>();
                int index = 0;
                while (node != null)
                {
                    listNode.Add(node);
                    dict.Add(node, index);
                    node = node.next;
                    index++;
                }

                foreach (var item in listNode)
                {
                    List<int?> ls = new List<int?>();
                    ls.Add(item.val);
                    if (item.random != null)
                    {
                        ls.Add(dict[item.random]);
                    }
                    else
                    {
                        ls.Add(null);
                    }
                    list.Add(ls.ToArray());
                }


                return list.ToArray();
            }
        }
    }
}

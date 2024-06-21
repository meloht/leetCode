using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0401_0450
{

    public class _432_AllOoneDataStructureAlg
    {
        public class AllOne
        {

            private List<NodeData> list = new List<NodeData>();
            private Dictionary<string, NodeData> dict = new Dictionary<string, NodeData>();
            private NodeData head = null;
            private NodeData end = null;
            public AllOne()
            {

            }

            public void Inc(string key)
            {
                if (dict.ContainsKey(key))
                {
                    dict[key].Count++;
                    Update(dict[key]);
                }
                else
                {
                    NodeData node = new NodeData(key, 1);
                    dict.Add(key, node);
                    AddEnd(node);
                }

            }

            public void Dec(string key)
            {
                if (dict.ContainsKey(key))
                {
                    dict[key].Count--;
                    Update(dict[key]);
                    if (dict[key].Count <= 0)
                    {
                        dict.Remove(key);
                    }

                }

            }

            public string GetMaxKey()
            {
                if (head !=null)
                {
                    return head.Key;
                }
                return string.Empty;
            }

            public string GetMinKey()
            {
                if (end!=null)
                {
                    return end.Key;
                }
                return string.Empty;
            }

            private void AddEnd(NodeData node)
            {
                if (head == null)
                {
                    head = node;
                    end = node;
                }
                else
                {
                    var last = end;
                    last.Next = node;
                    node.Prev = last;
                    end = node;
                }
            }
            private void Update(NodeData node)
            {
                if (head == null)
                {
                    return;
                }
                if (node.Count == 0)
                {
                    if (node.Next == null)
                    {
                        end = node.Prev;
                        if (node.Prev == null)
                        {
                            head = null;
                        }
                    }
                    else if (node.Prev == null)
                    {
                        head = node.Next;
                    }
                    else
                    {
                        node.Prev.Next = node.Next;
                        node.Next.Prev = node.Prev;
                    }
                    return;
                }
                while (node.Prev != null && node.Count > node.Prev.Count)
                {
                    var tempPre = node.Prev.Prev;
                    var tempNext = node.Next;

                    if (tempPre == null)
                    {
                        head = node;
                    }
                    node.Next = node.Prev;
                    node.Prev = tempPre;
                    node.Prev.Next = tempNext;
                    node.Prev.Prev = node;
                }

                while (node.Next != null && node.Count < node.Next.Count)
                {
                    var tempNext = node.Next.Next;
                    var tempPre = node.Prev;

                    if (tempNext == null)
                    {
                        end = node;
                    }
                    node.Next.Next = node;
                    node.Next.Prev = tempPre;

                    node.Next = tempNext;
                    node.Prev = node.Next;

                }

            }

        }

        class NodeData
        {
            public string Key { get; set; }
            public int Count { get; set; }

            public NodeData Prev { get; set; }
            public NodeData Next { get; set; }

            public NodeData(string val, int num)
            {
                Count = num;
                Key = val;
            }


        }
    }
}

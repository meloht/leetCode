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
                    var node = dict[key];
                    node.Count--;
                    Update(node);
                    if (node.Count <= 0)
                    {
                        dict.Remove(key);
                    }

                }

            }

            public string GetMaxKey()
            {
                if (head != null)
                {
                    return head.Key;
                }
                return string.Empty;
            }

            public string GetMinKey()
            {
                if (end != null)
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
                            end = null;
                        }
                        else
                        {
                            node.Prev.Next = null;
                        }
                    }
                    else if (node.Prev == null)
                    {
                        head = node.Next;
                        node.Prev = null;
                    }
                    else
                    {
                        node.Prev.Next = node.Next;
                        node.Next.Prev = node.Prev;
                    }
                    return;
                }

                NodeData nodeCurr = node;
                while (nodeCurr.Prev != null && nodeCurr.Count > nodeCurr.Prev.Count)
                {
                    var PreNode = nodeCurr.Prev;
                    var nextNode = nodeCurr.Next;
                    if (PreNode.Prev == null)
                    {
                        head = nodeCurr;
                    }
                    var pre = PreNode.Prev;
                    if (pre != null)
                    {
                        pre.Next = nodeCurr;
                    }
                    nodeCurr.Prev = pre;
                    PreNode.Prev = nodeCurr;
                    nodeCurr.Next = PreNode;

                    PreNode.Next = nextNode;
                    if (nextNode != null)
                    {
                        nextNode.Prev = PreNode;
                    }
                    else
                    {
                        end = PreNode;
                    }
                   

                }

                nodeCurr = node;
                while (nodeCurr.Next != null && nodeCurr.Count < nodeCurr.Next.Count)
                {
                    var PreNode = nodeCurr.Prev;
                    var nextNode = nodeCurr.Next;


                    if (nextNode.Next == null)
                    {
                        end = nodeCurr;
                    }
                    var next = nextNode.Next;

                    nextNode.Prev = PreNode;
                    if (PreNode != null)
                    {
                        PreNode.Next = nextNode;
                    }
                    else
                    {
                        head = nextNode;
                    }
                    
                    nextNode.Next = nodeCurr;
                    nodeCurr.Prev = nextNode;
                    nodeCurr.Next = next;
                    if (next != null)
                    {
                        next.Prev = nodeCurr;
                    }

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

            public override string ToString()
            {
                return $"{Key} {Count}";
            }

        }
    }
}

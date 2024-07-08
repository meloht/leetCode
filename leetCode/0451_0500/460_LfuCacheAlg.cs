using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static leetCode._0451_0500._460_LfuCacheAlg;

namespace leetCode._0451_0500
{
    public class _460_LfuCacheAlg
    {
        public class LFUCache
        {
            private int Capacity = 0;

            private Dictionary<int, LinkedListNode<Data>> dict = new Dictionary<int, LinkedListNode<Data>>();
            private Dictionary<int, LinkedListNode<LinkedList<Data>>> dictCount = new Dictionary<int, LinkedListNode<LinkedList<Data>>>();

            LinkedList<LinkedList<Data>> countLink = new LinkedList<LinkedList<Data>>();

            public LFUCache(int capacity)
            {
                this.Capacity = capacity;

            }

            public int Get(int key)
            {
                if (dict.ContainsKey(key))
                {
                    var node = dict[key];
                    AddCount(node, key);
                    return node.Value.Val;
                }
                return -1;
            }

            public void Put(int key, int value)
            {
                if (dict.Count == this.Capacity && !dict.ContainsKey(key))
                {
                    if (countLink.Last != null)
                    {
                        if (countLink.Last.Value.Last != null)
                        {
                            var last = countLink.Last.Value.Last;
                            countLink.Last.Value.RemoveLast();
                            dict.Remove(last.Value.Key);

                            if (countLink.Last.Value.Count == 0)
                            {
                                var last1 = countLink.Last;
                                countLink.RemoveLast();
                                dictCount.Remove(last.Value.Count);
                            }
                        }
                    }
                }
                Data data = new Data { Count = 1, Val = value, Key = key };

                if (dict.ContainsKey(key))
                {
                    var node = dict[key];
                    node.Value.Val = value;
                    AddCount(node, key);

                }
                else
                {
                    if (!dictCount.ContainsKey(1))
                    {
                        LinkedList<Data> nodeList = new LinkedList<Data>();
                        var node = nodeList.AddLast(data);
                        dict.Add(key, node);

                        var link = countLink.AddLast(nodeList);
                        dictCount.Add(1, link);
                    }
                    else
                    {
                        var node = dictCount[1].Value.AddLast(data);
                        dict.Add(key, node);
                    }
                }
            }

            private void AddCount(LinkedListNode<Data> node, int key)
            {
                var link = dictCount[node.Value.Count];
                link.Value.Remove(node);
                if (link.Value.Count == 0)
                {
                    dictCount.Remove(node.Value.Count);
                    countLink.Remove(link);
                }
                node.Value.Count++;
                if (dictCount.ContainsKey(node.Value.Count))
                {
                    var linkNode = dictCount[node.Value.Count];
                    var newNode = linkNode.Value.AddLast(node.Value);
                    dict[key] = newNode;
                }
                else
                {
                    LinkedList<Data> nodeList = new LinkedList<Data>();
                    var newNode = nodeList.AddLast(node.Value);
                    dict[key] = newNode;

                    var link1 = countLink.AddFirst(nodeList);
                    dictCount.Add(node.Value.Count, link1);
                }
            }
        }

        public class Data
        {
            public int Key { get; set; }
            public int Count { get; set; }
            public int Val { get; set; }
        }
        //public class Node
        //{
        //    public Node Prev { get; set; }
        //    public Node Next { get; set; }



        //    public Node Insert(Node node)
        //    {  // 在 this 后插入 node
        //        node.Prev = this;
        //        node.Next = this.Next;
        //        node.Prev.Next = node;
        //        node.Next.Prev = node;
        //        return node;
        //    }

        //    public void Remove()
        //    {
        //        this.Prev.Next = this.Next;
        //        this.Next.Prev = this.Prev;
        //    }

        //}




    }
}

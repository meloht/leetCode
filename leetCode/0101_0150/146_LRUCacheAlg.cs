using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static leetCode._0101_0150._138_CopyListWithRandomPointerAlg;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._0101_0150
{
    public class _146_LRUCacheAlg
    {
        public class LRUCache
        {
            private int _capacity;

            private Dictionary<int, NodeData> _cache;
            private NodeData Head;
            private NodeData Tail;
            public LRUCache(int capacity)
            {
                _capacity = capacity;
                _cache = new Dictionary<int, NodeData>(_capacity);
                Head = new NodeData();
                Tail = new NodeData();
                Head.Next = Tail;
                Tail.Prev = Head;

            }

            public int Get(int key)
            {
                if (_cache.ContainsKey(key))
                {
                    var data = _cache[key];
                    MoveToHead(data);
                    return data.Value;
                }

                return -1;
            }

            public void Put(int key, int value)
            {
                if (!_cache.ContainsKey(key))
                {
                    if (_capacity == _cache.Count)
                    {
                        var node = RemoveTail();

                        _cache.Remove(node.Key);
                    }
                    var data = new NodeData(key, value);
                    _cache.Add(key, data);
                    AddToHead(data);
                }
                else
                {
                    var data = _cache[key];
                    data.Value = value;
                    MoveToHead(data);

                }
            }


            private void MoveToHead(NodeData node)
            {
                RemoveNode(node);
                AddToHead(node);
            }
            private void AddToHead(NodeData node)
            {
                node.Prev = Head;
                node.Next = Head.Next;
                Head.Next.Prev = node;
                Head.Next = node;
            }

            private void RemoveNode(NodeData node)
            {
                node.Prev.Next = node.Next;
                node.Next.Prev = node.Prev;
            }
            private NodeData RemoveTail()
            {
                NodeData res = Tail.Prev;
                RemoveNode(res);
                return res;
            }



        }
        class NodeData
        {
            public int Key;
            public int Value;
            public NodeData Next;
            public NodeData Prev;
            public NodeData()
            { }
            public NodeData(int key, int value)
            {
                Key = key;
                Value = value;
            }
            public override string ToString()
            {
                return $"{Key} {Value}";
            }
        }
    }
}

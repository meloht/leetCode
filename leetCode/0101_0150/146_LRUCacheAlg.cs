using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            private NodeData Last;
            public LRUCache(int capacity)
            {
                _capacity = capacity;
                _cache = new Dictionary<int, NodeData>(_capacity);
            }

            public int Get(int key)
            {
                if (_cache.ContainsKey(key))
                {
                    var data = _cache[key];
                    UpdateOrder(data);
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
                        var node = RemoveNode();

                        _cache.Remove(node.Key);
                    }
                    var data = new NodeData(key, value);
                    _cache.Add(key, data);
                    AddNode(data);
                }
                else
                {
                    var data = _cache[key];
                    data.Value = value;
                    UpdateOrder(data);

                }
            }
            private void AddNode(NodeData data)
            {
                if (Head == null)
                {
                    Head = data;
                    Last = data;
                }
                else
                {
                    Last.Next = data;
                    data.Pre = Last;
                    Last = data;
                }
            }

            private void UpdateOrder(NodeData data)
            {
                if (data == Last)
                    return;

                if (data == Head)
                {
                    var temp = data;
                    Head = data.Next;
                    Head.Pre = null;

                    var tem2 = Last;
                    tem2.Next = temp;
                    temp.Pre = tem2;
                    Last = temp;

                }
                else
                {
                    var pre = data.Pre;
                    var last = data.Next;

                    if (pre != null)
                    {
                        pre.Next = last;
                    }
                    if (last != null)
                    {
                        last.Pre = pre;
                    }

                    if (Last != null)
                    {
                        var temp = Last;
                        data.Next = null;
                        data.Pre = temp;
                        temp.Next = data;
                        Last = data;
                    }
                }


            }
            private NodeData RemoveNode()
            {
                var temp = Head;

                var newHead = Head.Next;
                if (newHead != null)
                {
                    newHead.Pre = null;
                }
                Head = newHead;
                if (Head == null)
                {
                    Last = null;
                }
                temp.Next = null;

                return temp;
            }
        }
        class NodeData
        {
            public int Key;
            public int Value;
            public NodeData Next;
            public NodeData Pre;
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

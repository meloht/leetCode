using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0101_0150
{
    public class _146_LRUCacheAlg
    {
        public class LRUCache
        {
            private int _capacity;

            private Dictionary<int, NodeData> _cache;
            private List<NodeData> queue;
            public LRUCache(int capacity)
            {
                _capacity = capacity;
                queue = new List<NodeData>(_capacity);
                _cache = new Dictionary<int, NodeData>(_capacity);
            }

            public int Get(int key)
            {
                if (_cache.ContainsKey(key))
                {
                    var data = _cache[key];
                    data.Time = DateTime.Now;
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
                        var rem = queue[0];
                        _cache.Remove(rem.Key);
                        queue.RemoveAt(0);
                    }
                    var data = new NodeData(key, value, DateTime.Now);
                    _cache.Add(key, data);
                    queue.Add(data);
                }
                else
                {
                    var data = _cache[key];
                    data.Value = value;
                    UpdateOrder(data);
                   
                }


            }
            private void UpdateOrder(NodeData data)
            {
                data.Time = DateTime.Now;
                int index = queue.IndexOf(data);
                queue.RemoveAt(index);
                queue.Add(data);
             
               // queue.Sort((x, y) => { return x.Time.CompareTo(y.Time); });
            }
        }
        class NodeData
        {
            public int Key;
            public int Value;
            public DateTime Time;
            public NodeData(int key, int value, DateTime time)
            {
                Key = key;
                Time = time;
                Value = value;
            }
        }
    }
}

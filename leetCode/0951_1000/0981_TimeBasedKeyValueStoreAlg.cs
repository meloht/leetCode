using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0951_1000
{
    public class _0981_TimeBasedKeyValueStoreAlg
    {
        public class TimeMap
        {
            private Dictionary<string, List<NodeItem>> dict = new Dictionary<string, List<NodeItem>>();

            public TimeMap()
            {

            }

            public void Set(string key, string value, int timestamp)
            {
                NodeItem item = new NodeItem();
                item.Timestamp = timestamp;
                item.Value = value;
                if (!dict.ContainsKey(key))
                {
                    dict.Add(key, new List<NodeItem>());
                }

                dict[key].Add(item);
            }

            public string Get(string key, int timestamp)
            {
                if (!dict.ContainsKey(key))
                    return null;

                var list = dict[key];
                int ans = -1;
                int left = 0;
                int right = list.Count - 1;
                while (left <= right)
                {
                    int mid = (right - left) / 2 + left;
                    var val = list[mid];
                    if (val.Timestamp <= timestamp)
                    {
                        left = mid + 1;
                        ans = mid;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
                if (ans != -1)
                {
                    return list[ans].Value;
                }

                return "";
            }
        }

        class NodeItem
        {
            public int Timestamp { get; set; }
            public string Value { get; set; }
        }
    }
}

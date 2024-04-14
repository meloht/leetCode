using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0701_0750
{
    public class _706_DesignHashmapAlg
    {
        public class MyHashMap1
        {
            int[] map;
            public MyHashMap1()
            {
                map = new int[1000001];
                Array.Fill(map, -1);
            }

            public void Put(int key, int value)
            {
                map[key] = value;
            }

            public int Get(int key)
            {
                return map[key];
            }

            public void Remove(int key)
            {
                map[key] = -1;
            }
        }

        public class MyHashMap
        {
            private int baseNum = 769;
            private LinkedList<Pair>[] data;

            public MyHashMap()
            {
                data = new LinkedList<Pair>[baseNum];
                for (int i = 0; i < baseNum; i++)
                {
                    data[i] = new LinkedList<Pair>();
                }
            }

            public void Put(int key, int value)
            {
                System.Console.WriteLine($"{key},{value}");
                int h = GetHash(key);
                var iterator = data[h];
                foreach (var item in iterator)
                {
                    if (item.Key == key)
                    {
                        item.Value = value;
                        return;
                    }
                }
                iterator.AddLast(new LinkedListNode<Pair>(new Pair(key, value)));
            }

            public int Get(int key)
            {
                int h = GetHash(key);
                var iterator = data[h];
                foreach (var item in iterator)
                {
                    if (item.Key == key)
                    {
                        return item.Value;
                    }
                }
                return -1;
            }

            public void Remove(int key)
            {
                int h = GetHash(key);
                var iterator = data[h];
               
                Pair pair = null;
                foreach (var item in iterator)
                {
                    if (item.Key == key)
                    {
                        pair = item;
                        
                        break;
                    }
                }
                if (pair != null)
                {
                    iterator.Remove(pair);
                }

            }
            private int GetHash(int key)
            {
                return key % baseNum;

            }

            private class Pair
            {
                public int Key { get; set; }
                public int Value { get; set; }
                public Pair() { }
                public Pair(int k, int v)
                {
                    this.Value = v;
                    this.Key = k;
                }

            }
        }
    }
}

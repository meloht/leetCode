using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0701_0750
{
    public class _705_DesignHashsetAlg
    {
        public class MyHashSet
        {
            int[] map = new int[1000001];
            public MyHashSet()
            {

            }

            public void Add(int key)
            {
                if (map[key] > 0)
                    return;
                map[key] = 1;
            }

            public void Remove(int key)
            {
                map[key] = 0;
            }

            public bool Contains(int key)
            {
                if (map[key] > 0)
                {
                    return true;
                }
                return false;
            }
        }
    }
}

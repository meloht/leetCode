using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCodeTemplates.树状数组
{
    public class BinaryIndexedTree
    {
        private int[] tree;

        public BinaryIndexedTree(int n)
        {
            tree = new int[n + 1];
        }

        public void Add(int i)
        {
            while (i < tree.Length)
            {
                tree[i]++;
                i += i & -i;
            }
        }

        public int Get(int i)
        {
            int sum = 0;
            while (i > 0)
            {
                sum += tree[i];
                i -= i & -i;
            }
            return sum;
        }

    }
}

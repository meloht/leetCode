using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2151_2200
{
    public class _2179_CountGoodTripletsInAnArrayAlg
    {
        public long GoodTriplets(int[] nums1, int[] nums2)
        {
            int n = nums1.Length;
            int[] p = new int[n];
            for (int i = 0; i < n; i++)
            {
                p[nums1[i]] = i;
            }
            long ans = 0;
            FenwickTree t = new FenwickTree(n);
            for (int i = 0; i < n - 1; i++)
            {
                int y = p[nums2[i]];
                long less = t.Pre(y);
                ans += less * (n - 1 - y - (i - less));
                t.Update(y + 1, 1);
            }
            return ans;
        }

        class FenwickTree
        {
            private long[] tree;
            public FenwickTree(int n)
            {
                tree = new long[n + 1];
            }

            public void Update(int i, long val)
            {
                for (; i < tree.Length; i += i & -i)
                {
                    tree[i] += val;
                }
            }

            public long Pre(int i)
            {
                long res = 0;
                for (; i > 0; i &= i - 1)
                {
                    res += tree[i];
                }
                return res;
            }
        }
    }
}

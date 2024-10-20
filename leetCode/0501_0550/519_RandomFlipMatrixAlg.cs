using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0501_0550
{
    public class _519_RandomFlipMatrixAlg
    {
        public class Solution
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            int m, n, total;
            Random rand = new Random();

            public Solution(int m, int n)
            {
                this.m = m;
                this.n = n;
                this.total = m * n;
            }

            public int[] Flip()
            {
                int x = rand.Next(total);
                total--;
                // 查找位置 x 对应的映射
                int idx = dictionary.ContainsKey(x) ? dictionary[x] : x;
                // 将位置 x 对应的映射设置为位置 total 对应的映射
                int value = dictionary.ContainsKey(total) ? dictionary[total] : total;
                if (dictionary.ContainsKey(x))
                {
                    dictionary[x] = value;
                }
                else
                {
                    dictionary.Add(x, value);
                }
                return new int[] { idx / n, idx % n };
            }

            public void Reset()
            {
                total = m * n;
                dictionary.Clear();
            }

        }
    }
}

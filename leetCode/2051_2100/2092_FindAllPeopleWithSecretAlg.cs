using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._2051_2100
{
    public class _2092_FindAllPeopleWithSecretAlg
    {
        public IList<int> FindAllPeople(int n, int[][] meetings, int firstPerson)
        {
            Array.Sort(meetings, (a, b) => a[2] - b[2]);
            UnionFind uf = new UnionFind(n);
            // 一开始 0 和 firstPerson 都知道秘密
            uf.merge(firstPerson, 0);
            // 分组循环
            int m = meetings.Length;
            for (int i = 0; i < m;)
            {
                int start = i;
                int time = meetings[i][2];
                // 合并在同一时间发生的会议
                for (; i < m && meetings[i][2] == time; i++)
                {
                    uf.merge(meetings[i][0], meetings[i][1]);
                }

                // 如果节点不和 0 在同一个集合，那么撤销合并，恢复成初始值
                for (int j = start; j < i; j++)
                {
                    int x = meetings[j][0];
                    int y = meetings[j][1];
                    if (!uf.isSame(x, 0))
                    {
                        uf.reset(x);
                    }
                    if (!uf.isSame(y, 0))
                    {
                        uf.reset(y);
                    }
                }
            }
            // 和 0 在同一个集合的专家都知道秘密
            List<int> ans = new List<int>();
            for (int k = 0; k < n; k++)
            {
                if (uf.isSame(k, 0))
                {
                    ans.Add(k);
                }
            }
            return ans;
        }

    }

    public class UnionFind
    {
        private int[] fa; // 代表元

       public UnionFind(int n)
        {
            // 一开始有 n 个集合 {0}, {1}, ..., {n-1}
            // 集合 i 的代表元是自己
            fa = new int[n];
            for (int i = 0; i < n; i++)
            {
                fa[i] = i;
            }
        }

        // 返回 x 所在集合的代表元
        // 同时做路径压缩，也就是把 x 所在集合中的所有元素的 fa 都改成代表元
        public int find(int x)
        {
            // 如果 fa[x] == x，则表示 x 是代表元
            if (fa[x] != x)
            {
                fa[x] = find(fa[x]); // fa 改成代表元
            }
            return fa[x];
        }

        // 判断 x 和 y 是否在同一个集合
        public bool isSame(int x, int y)
        {
            // 如果 x 的代表元和 y 的代表元相同，那么 x 和 y 就在同一个集合
            // 这就是代表元的作用：用来快速判断两个元素是否在同一个集合
            return find(x) == find(y);
        }

        // 把 from 所在集合合并到 to 所在集合中
        public void merge(int from, int to)
        {
            int x = find(from);
            int y = find(to);
            fa[x] = y; // 合并集合
        }

        public void reset(int x)
        {
            fa[x] = x;
        }
    }


}

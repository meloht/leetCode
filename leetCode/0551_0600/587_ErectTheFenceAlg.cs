using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._0551_0600
{
    public class _587_ErectTheFenceAlg
    {

        private int[] Subtraction(int[] a, int[] b)
        { // 向量相减
            return new int[] { a[0] - b[0], a[1] - b[1] };
        }
        private double Cross(int[] a, int[] b)
        { // 叉乘
            return a[0] * b[1] - a[1] * b[0];
        }
        private double GetArea(int[] a, int[] b, int[] c)
        { // 向量 ab 转为 向量 ac 过程中扫过的面积
            return Cross(Subtraction(b, a), Subtraction(c, a));
        }

        public int[][] OuterTrees(int[][] trees)
        {
            Array.Sort(trees, (a, b)=>{
                return a[0] != b[0] ? a[0].CompareTo(b[0]) : a[1].CompareTo(b[1]);
            });
            int n = trees.Length, tp = 0;
            int[] stk = new int[n + 10];
            bool[] vis = new bool[n + 10];
            stk[++tp] = 0; // 不标记起点
            for (int i = 1; i < n; i++)
            {
                int[] c = trees[i];
                while (tp >= 2)
                {
                    int[] a = trees[stk[tp - 1]], b = trees[stk[tp]];
                    if (GetArea(a, b, c) > 0) vis[stk[tp--]] = false;
                    else break;
                }
                stk[++tp] = i;
                vis[i] = true;
            }
            int size = tp;
            for (int i = n - 1; i >= 0; i--)
            {
                if (vis[i]) continue;
                int[] c = trees[i];
                while (tp > size)
                {
                    int[] a = trees[stk[tp - 1]], b = trees[stk[tp]];
                    if (GetArea(a, b, c) > 0) tp--;
                    // vis[stk[tp--]] = false; // 非必须
                    else break;
                }
                stk[++tp] = i;
                // vis[i] = true; // 非必须
            }
            int[][] ans = new int[tp - 1][];
            for (int i = 0; i < ans.Length; i++)
            {
                ans[i] = new int[2];
            }
            for (int i = 1; i < tp; i++) ans[i - 1] = trees[stk[i]];
            return ans;
        }


    }
}

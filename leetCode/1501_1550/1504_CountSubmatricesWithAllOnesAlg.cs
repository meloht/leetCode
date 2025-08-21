using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1501_1550
{
    public class _1504_CountSubmatricesWithAllOnesAlg
    {
        public int NumSubmat(int[][] mat)
        {
            int n = mat[0].Length;
            int[] heights = new int[n];
            int ans = 0;

            int[,] st = new int[n + 1, 3]; // (j, f, heights[j])
            foreach (int[] row in mat)
            {
                for (int j = 0; j < n; j++)
                {
                    if (row[j] == 0)
                    {
                        heights[j] = 0;
                    }
                    else
                    {
                        heights[j]++;
                    }
                }

                st[0, 0] = st[0, 2] = -1; // 哨兵，方便处理 left=-1 的情况
                int top = 0;
                for (int j = 0; j < n; j++)
                {
                    int h = heights[j];
                    while (st[top, 2] >= h)
                    {
                        top--; // 出栈
                    }
                    int left = st[top, 0];
                    int f = st[top, 1];
                    // 计算底边为 row，右边界为 j 的子矩形个数
                    // 左边界 <= left 的矩形，每个矩形的右边界都可以扩展到 j，一共有 f 个
                    // 左边界 >  left 的矩形，左边界有 j-left 种，高度有 h 种，一共有 (j-left)*h 个
                    f += (j - left) * h;
                    ans += f;
                    top++;
                    st[top, 0] = j; // 入栈
                    st[top, 1] = f;
                    st[top, 2] = h;
                }
            }

            return ans;

        }
    }
}

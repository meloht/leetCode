using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._0751_0800
{
    public class _757_SetIntersectionSizeAtLeastTwoAlg
    {
        public int IntersectionSizeTwo(int[][] intervals)
        {
            Array.Sort(intervals, (a, b)=>a[1] - b[1]);
            // 栈中保存闭区间左右端点，栈底到栈顶的区间长度的和
            List<int[]> st = new List<int[]>();
            st.Add(new int[] { -2, -2, 0 }); // 哨兵，保证不和任何区间相交
            foreach (int[] t in intervals)
            {
                int start = t[0], end = t[1];
                int[] e = st[lowerBound(st, start) - 1];
                int d = 2 - (st[st.Count - 1][2] - e[2]); // 去掉运行中的时间点
                if (start <= e[1])
                { // start 在区间 st[i] 内
                    d -= e[1] - start + 1; // 去掉运行中的时间点
                }
                if (d <= 0)
                {
                    continue;
                }
                while (end - st[st.Count - 1][1] <= d)
                { // 剩余的 d 填充区间后缀
                    e = st[st.Count - 1];
                    st.RemoveAt(st.Count - 1);
                    d += e[1] - e[0] + 1; // 合并区间
                }
                st.Add(new int[] { end - d + 1, end, st[st.Count - 1][2] + d });
            }
            return st[st.Count - 1][2];


        }
        private int lowerBound(List<int[]> st, int target)
        {
            int left = -1, right = st.Count; // 开区间 (left, right)
            while (left + 1 < right)
            { // 区间不为空
              // 循环不变量：
              // st[left] < target
              // st[right] >= target
                int mid = (left + right) >>> 1;
                if (st[mid][0] < target)
                {
                    left = mid; // 范围缩小到 (mid, right)
                }
                else
                {
                    right = mid; // 范围缩小到 (left, mid)
                }
            }
            return right;
        }

    }
}

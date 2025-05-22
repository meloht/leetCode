using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._3351_3400
{
    public class _3362_ZeroArrayTransformationIIIAlg
    {
        public int MaxRemoval(int[] nums, int[][] queries)
        {
            Array.Sort(queries, (a, b)=>a[0] - b[0]);
            PriorityQueue<int,int> pq = new PriorityQueue<int,int>(Comparer<int>.Create((x,y)=>y-x));
            int n = nums.Length;
            int[] diff = new int[n + 1];
            int sumD = 0;
            int j = 0;
            for (int i = 0; i < n; i++)
            {
                sumD += diff[i];
                // 维护左端点 <= i 的区间
                while (j < queries.Length && queries[j][0] <= i)
                {
                    pq.Enqueue(queries[j][1], queries[j][1]);
                    j++;
                }
                // 选择右端点最大的区间
                while (sumD < nums[i] && pq.Count>0 && pq.Peek() >= i)
                {
                    sumD++;
                    diff[pq.Dequeue() + 1]--;
                }
                if (sumD < nums[i])
                {
                    return -1;
                }
            }
            return pq.Count;

        }
    }
}

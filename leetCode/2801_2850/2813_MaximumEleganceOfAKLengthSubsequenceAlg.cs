using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2801_2850
{
    public class _2813_MaximumEleganceOfAKLengthSubsequenceAlg
    {
        public long FindMaximumElegance(int[][] items, int k)
        {
            Array.Sort(items, (x, y) =>
            {
                return y[0].CompareTo(x[0]);
            });
            HashSet<int> catSet = new HashSet<int>();
            long ans = 0;
            long res = 0;
            Stack<int> stack=new Stack<int>();
            for (int i = 0; i < items.Length; i++)
            {
                if (i < k)
                {
                    ans += items[i][0];
                    if (!catSet.Add(items[i][1]))
                    {
                        stack.Push(items[i][0]);
                    }
                }
                else if (stack.Count > 0 && catSet.Add(items[i][1]))
                {
                    ans += items[i][0] - stack.Pop();
                }
                res = Math.Max(res, ans + (long)catSet.Count * catSet.Count);
            }
            return res;
        }
    }
}

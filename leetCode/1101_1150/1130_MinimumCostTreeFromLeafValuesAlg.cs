using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1101_1150
{
    public class _1130_MinimumCostTreeFromLeafValuesAlg
    {
        public int MctFromLeafValues(int[] arr)
        {
            int res = 0;
            Stack<int> stk = new Stack<int>();
            foreach (int x in arr)
            {
                while (stk.Count > 0 && stk.Peek() <= x)
                {
                    int y = stk.Pop();
                    if (stk.Count == 0 || stk.Peek() > x)
                    {
                        res += y * x;
                    }
                    else
                    {
                        res += stk.Peek() * y;
                    }
                }
                stk.Push(x);
            }
            while (stk.Count >= 2)
            {
                int x = stk.Pop();
                res += stk.Peek() * x;
            }
            return res;
        }

    }
}

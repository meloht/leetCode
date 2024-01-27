using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0701_0750
{
    public class _739_DailyTemperaturesAlg
    {
        public int[] DailyTemperatures(int[] temperatures)
        {
            int n = temperatures.Length;
            int[] res = new int[n];

            Stack<int> stackOrder = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                int curr = temperatures[i];
                if (i == 0)
                {
                    stackOrder.Push(i);
                }
                else
                {
                    while (stackOrder.Count > 0 && temperatures[stackOrder.Peek()] < curr)
                    {
                        int j = stackOrder.Pop();
                        res[j] = i - j;
                    }
                    stackOrder.Push(i);
                }

            }

            return res;
        }
    }
}

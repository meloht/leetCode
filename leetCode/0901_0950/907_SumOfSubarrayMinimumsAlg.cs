using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0901_0950
{
    public class _907_SumOfSubarrayMinimumsAlg
    {
        public int SumSubarrayMins(int[] arr)
        {
            int Mod = 1_000_000_007;
            long ans = 0;
            Stack<int> stack = new Stack<int>();
            stack.Push(-1);
            for (int r = 0; r <= arr.Length; r++)
            {
                int x = r < arr.Length ? arr[r] : -1;
                while (stack.Count > 1 && arr[stack.Peek()] >= x)
                {
                    int i = stack.Pop();
                    ans += ((long)arr[i] * (i - stack.Peek()) * (r - i))%Mod;
                }
                stack.Push(r);
            }

            return (int)(ans % Mod);
        }

    }
}

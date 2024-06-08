using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0401_0450
{
    public class _402_RemoveKDigitsAlg
    {
        public string RemoveKdigits(string num, int k)
        {
            if (k == num.Length)
                return "0";

            Stack<int> stack = new Stack<int>();

            int nn = 0;
            for (int i = 0; i < num.Length; i++)
            {
                while (stack.Count > 0 && nn < k && num[stack.Peek()] > num[i])
                {
                    stack.Pop();
                    nn++;

                }
                stack.Push(i);
            }

            while (nn < k)
            {
                stack.Pop();
                nn++;
            }

            if (stack.Count == 0)
                return "0";


            StringBuilder stringBuilder = new StringBuilder();
            var ss = stack.ToArray();

            for (int i = ss.Length - 1; i >= 0; i--)
            {

                if (stringBuilder.Length == 0 && num[ss[i]] == '0')
                {
                    continue;
                }
                stringBuilder.Append(num[ss[i]]);
            }

            if (stringBuilder.Length == 0)
            {
                return "0";
            }
            return stringBuilder.ToString();
        }
    }
}

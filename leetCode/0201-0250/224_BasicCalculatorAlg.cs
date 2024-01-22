using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0201_0250
{
    public class _224_BasicCalculatorAlg
    {
        public int Calculate(string s)
        {
            s = s.Trim();
            if (s.Length == 1)
                return Convert.ToInt32(s);

            Stack<string> stack = new Stack<string>();
            foreach (char item in s)
            {
                if (item == ' ')
                {
                    continue;
                }
                if (item == ')')
                {
                    while (stack.Peek() != "(")
                    {
                        var num1 = stack.Pop();
                        var op = stack.Pop();
                        var num2 = stack.Pop();
                        int num = 0;
                        if (op == "-")
                        {
                             num = int.Parse(num2) - int.Parse(num1);
                        }
                        else
                        {
                             num = int.Parse(num2) + int.Parse(num1);
                        }
                       
                        stack.Push(num.ToString());
                    }
                    stack.Pop();
                }
               // stack.Push(item);
            }
            return 0;
        }
    }
}

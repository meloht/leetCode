using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0101_0150
{
    public class _150_EvaluateReversePolishNotationAlg
    {
        public int EvalRPN(string[] tokens)
        {
            Stack<string> stack = new Stack<string>();
            foreach (var item in tokens)
            {
                if (item == "+" || item == "-" || item == "*" || item == "/")
                {
                    int num2 = int.Parse(stack.Pop());
                    int num1 = int.Parse(stack.Pop());
                    int res = 0;
                    if (item == "+")
                    {
                        res = num1 + num2;
                    }
                    else if (item == "-")
                    {
                        res = num1 - num2;
                    }
                    else if (item == "*")
                    {
                        res = num1 * num2;
                    }
                    else if (item == "/")
                    {
                        res = num1 / num2;
                    }

                    stack.Push(res.ToString());
                }
                else
                {
                    stack.Push(item);
                }
            }
            int num = int.Parse(stack.Pop());
            return num;
        }
    }
}

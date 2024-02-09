using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0651_0700
{
    public class _682_BaseballGameAlg
    {
        public int CalPoints1(string[] operations)
        {
            Stack<int> stack = new Stack<int>();
            foreach (string op in operations)
            {
                if (op == "D")
                {
                    int num = stack.Peek() * 2;
                    stack.Push(num);
                }
                else if (op == "C")
                {
                    stack.Pop();
                }
                else if (op == "+")
                {
                    int num1 = stack.Pop();
                    int num2 = stack.Peek();
                    stack.Push(num1);
                    stack.Push(num2 + num1);
                }
                else
                {
                    stack.Push(int.Parse(op));
                }
            }

            int ans = 0;
            while (stack.Count > 0)
            {
                ans += stack.Pop();
            }
            return ans;
        }

        public int CalPoints(string[] operations)
        {
            List<int> stack = new List<int>();
            foreach (string op in operations)
            {
                if (op == "D")
                {
                    int num = stack[stack.Count - 1] * 2;
                    stack.Add(num);
                }
                else if (op == "C")
                {
                    stack.RemoveAt(stack.Count - 1);
                }
                else if (op == "+")
                {
                    int num1 = stack[stack.Count - 1];
                    int num2 = stack[stack.Count - 2];
                    stack.Add(num2 + num1);
                }
                else
                {
                    stack.Add(int.Parse(op));
                }
            }

            return stack.Sum();
        }

    }
}

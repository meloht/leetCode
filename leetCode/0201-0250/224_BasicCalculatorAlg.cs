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

            char[] arr = s.ToCharArray().Where(p => p != ' ').ToArray();
            bool flag = arr[0] == '-';

            Stack<string> stack = new Stack<string>();
            int i = flag ? 1 : 0;
            while (i < arr.Length)
            {
                if (char.IsNumber(arr[i]))
                {
                    StringBuilder sb = new StringBuilder();
                    while (i < s.Length && char.IsNumber(s[i]))
                    {
                        sb.Append(s[i]);
                        i++;
                    }
                   

                    stack.Push(sb.ToString());
                    continue;
                }
                else
                {
                    if (s[i] == ')')
                    {
                        while (stack.Count > 0)
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
                            if (stack.Peek() == "(")
                            {
                                stack.Pop();
                                stack.Push(num.ToString());
                                break;
                            }
                            else
                            {
                                stack.Push(num.ToString());
                            }

                        }

                    }
                    else
                    {
                        stack.Push(s[i].ToString());
                    }

                    i++;
                }

            }



            return 0;
        }
    }
}

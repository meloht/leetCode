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

            var ress = CaculateNum(arr, 0, ' ', i);
            while (i < arr.Length)
            {
                if (char.IsNumber(arr[i]))
                {
                    var res = CaculateNum(arr, 0, ' ', i);
                    i = res.Item2;
                    stack.Push(res.Item1.ToString());
                    continue;
                }
                else
                {
                    if (arr[i] == ')')
                    {
                        while (stack.Count > 1)
                        {
                            var num1 = stack.Pop();
                            if (stack.Peek() == "(")
                            {
                                stack.Pop();
                            }
                            if (stack.Count == 0)
                            {
                                stack.Push(num1.ToString());
                                break;
                            }
                            if (stack.Peek() == "+" || stack.Peek() == "-")
                            {
                                string op = stack.Pop();
                                int num2 = int.Parse(stack.Pop());
                                if (op == "+")
                                {
                                    int num = num2 + int.Parse(num1);
                                    stack.Push(num.ToString());

                                }
                                else if (op == "-")
                                {
                                    int num = num2 - int.Parse(num1);
                                    stack.Push(num.ToString());
                                }
                            }
                            else
                            {
                                break;
                            }
                        }

                    }
                    else
                    {
                        stack.Push(arr[i].ToString());
                    }

                    i++;
                }

            }

            if (stack.Count == 1)
            {
                int num = int.Parse(stack.Pop());
                if (flag)
                {
                    return -num;
                }
                return num;
            }

            return 0;
        }

        private Tuple<int, int> CaculateNum(char[] arr, int num, char op, int i)
        {
            if (i >= arr.Length)
            {
                return new Tuple<int, int>(num, i);
            }
            if (arr[i] == '(')
            {
                return new Tuple<int, int>(num, i - 1);
            }
            if (arr[i] == ')')
            {
                return new Tuple<int, int>(num, i);
            }
            if (arr[i] == '+' || arr[i] == '-')
            {
                return CaculateNum(arr, num, arr[i], i + 1);
            }
            if (char.IsNumber(arr[i]))
            {
                var res = GetNextNum(arr, i);
                int num1 = res.Item1;
                if (op == '+')
                {
                    num1 = num + num1;
                }
                else if (op == '-')
                {
                    num1 = num - num1;
                }
                return CaculateNum(arr, num1, op, res.Item2);
            }

            return new Tuple<int, int>(num, 0);
        }
        private Tuple<int, int> GetNextNum(char[] arr, int i)
        {
            StringBuilder sb = new StringBuilder();
            while (i < arr.Length && char.IsNumber(arr[i]))
            {
                sb.Append(arr[i]);
                i++;
            }
            int num = int.Parse(sb.ToString());
            return new Tuple<int, int>(num, i);
        }
    }
}

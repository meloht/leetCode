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
                    var res = ComputeNum(arr, i);
                    stack.Push(res.Item2.ToString());
                    i = res.Item3;
                    continue;
                }
                else
                {
                    if (arr[i] == ')')
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
                        stack.Push(arr[i].ToString());
                    }

                    i++;
                }

            }

            if (stack.Count == 1)
            {
                int num= int.Parse(stack.Pop());
                if (flag)
                {
                    return -num;
                }
                return num;
            }

            return 0;
        }

        private Tuple<bool, int, int> ComputeNum(char[] arr, int i)
        {
            if (i >= arr.Length)
                return new Tuple<bool, int, int>(false, 0, i - 1);
            if (!char.IsNumber(arr[i]))
            {
                return new Tuple<bool, int, int>(false, 0, i);
            }
            var item = GetNextNum(arr, i);
            if (item.Item2 >= arr.Length)
            {
                return new Tuple<bool, int, int>(true, item.Item1, item.Item2);
            }
            i = item.Item2;
            int num = item.Item1;
            var flag = arr[i];
            if (char.IsNumber(arr[i + 1]))
            {
                var next = GetNextNum(arr, i + 1);
                int res = 0;
                if (flag == '+')
                {
                    res = num + next.Item2;
                }
                else
                {
                    res = num - next.Item2;
                }

            }
         
            return new Tuple<bool, int, int>(false, num, item.Item2);

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

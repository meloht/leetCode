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
            bool flag = arr[0] == '-' && arr[1] == '(';

            Stack<int> stack = new Stack<int>();
            Stack<char> opStack = new Stack<char>();
            int i = flag ? 1 : 0;

            while (i < s.Length)
            {
                int num = 0;
                while (arr[i] != '(')
                {
                    var res = GetNum(arr, i);
                    num += res.Item1;
                    i = res.Item2;
                }
                if (arr[i] == '(')
                {
                    stack.Push(num);
                    i++;
                }
                num = 0;
                while (arr[i] != ')')
                {
                    var res = GetNum(arr, i);
                    num += res.Item1;
                    i = res.Item2;
                }
                if (arr[i] == ')')
                {
                    int prev = stack.Pop();
                    num = num + prev;
                    stack.Push(num);
                    i++;
                }
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


        private Tuple<int, int> GetNum(char[] arr, int i)
        {
            bool flag = false;
            if (arr[i] == '-')
            {
                flag = true;
                i++;
            }
            else if (arr[i] == '+')
            {
                i++;
            }
            StringBuilder sb = new StringBuilder();
            while (i < arr.Length && char.IsNumber(arr[i]))
            {
                sb.Append(arr[i]);
                i++;
            }
            if (sb.ToString().Length == 0)
            {
                return new Tuple<int, int>(0, i--);
            }
            int num = int.Parse(sb.ToString());
            if (flag)
            {
                num = -num;
            }
            return new Tuple<int, int>(num, i);
        }
    }
}

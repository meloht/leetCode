using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0251_0300
{
    public class _282_ExpressionAddOperatorsAlg
    {
        int Target = 0;
        static string[] op = ["+", "-", "*"];

        public IList<string> AddOperators11(string num, int target)
        {
            var max = long.Parse(num);
            if (max > int.MaxValue || max < int.MinValue)
                return new List<string>();
            Target = target;

            List<string> res = new List<string>();
            for (int i = 0; i < num.Length; i++)
            {
                int count = i + 1;
                string nn = num.Substring(0, count);
                if (nn.Length > 1 && nn.StartsWith('0'))
                {
                    continue;
                }
                List<string> list = new List<string>();
                list.Add(nn);
                Dfs(num, count, list, res);
            }

            return res;
        }
        private void Dfs(string num, int index, List<string> list, List<string> res)
        {
            if (index >= num.Length)
            {
                string format = string.Join("", list);
                int n = Calculate(format);

                if (n == this.Target)
                {
                    res.Add(format);
                }
                return;
            }

            for (int i = index; i < num.Length; i++)
            {
                int count = i + 1 - index;
                string nn = num.Substring(index, count);
                if (nn.Length > 1 && nn.StartsWith('0'))
                {
                    continue;
                }
                foreach (var item in op)
                {
                    list.Add(item);

                    list.Add(nn);

                    Dfs(num, i + 1, list, res);

                    list.RemoveAt(list.Count - 1);
                    list.RemoveAt(list.Count - 1);
                }
            }


        }


        public int Calculate(string s)
        {
            Stack<int> stack = new Stack<int>();
            char preSign = '+';
            int num = 0;
            int n = s.Length;
            for (int i = 0; i < n; ++i)
            {
                if (char.IsDigit(s[i]))
                {
                    num = num * 10 + s[i] - '0';
                }
                if (!char.IsDigit(s[i]) && s[i] != ' ' || i == n - 1)
                {
                    switch (preSign)
                    {
                        case '+':
                            stack.Push(num);
                            break;
                        case '-':
                            stack.Push(-num);
                            break;
                        case '*':
                            stack.Push(stack.Pop() * num);
                            break;
                        default:
                            stack.Push(stack.Pop() / num);
                            break;
                    }
                    preSign = s[i];
                    num = 0;
                }
            }
            int ans = 0;
            while (stack.Count > 0)
            {
                ans += stack.Pop();
            }
            return ans;
        }




        int n;
        string num;
        int target;
        IList<string> ans;

        public IList<string> AddOperators(string num, int target)
        {
            this.n = num.Length;
            this.num = num;
            this.target = target;
            this.ans = new List<string>();
            StringBuilder expr = new StringBuilder();
            Backtrack(expr, 0, 0, 0);
            return ans;
        }

        public void Backtrack(StringBuilder expr, int i, long res, long mul)
        {
            if (i == n)
            {
                if (res == target)
                {
                    ans.Add(expr.ToString());
                }
                return;
            }
            int signIndex = expr.Length;
            if (i > 0)
            {
                expr.Append(0); // 占位，下面填充符号
            }
            long val = 0;
            // 枚举截取的数字长度（取多少位），注意数字可以是单个 0 但不能有前导零
            for (int j = i; j < n && (j == i || num[i] != '0'); ++j)
            {
                val = val * 10 + num[j] - '0';
                expr.Append(num[j]);
                if (i == 0)
                { // 表达式开头不能添加符号
                    Backtrack(expr, j + 1, val, val);
                }
                else
                { // 枚举符号
                    expr.Replace(expr[signIndex], '+', signIndex, 1);
                    Backtrack(expr, j + 1, res + val, val);
                    expr.Replace(expr[signIndex], '-', signIndex, 1);
                    Backtrack(expr, j + 1, res - val, -val);
                    expr.Replace(expr[signIndex], '*', signIndex, 1);
                    Backtrack(expr, j + 1, res - mul + mul * val, mul * val);
                }
            }
            expr.Length = signIndex;
        }

    }
}

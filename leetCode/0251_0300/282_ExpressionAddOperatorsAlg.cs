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

        public IList<string> AddOperators(string num, int target)
        {
            Target = target;
  
            List<string> res = new List<string>();
            List<string> list = new List<string>();
            list.Add(num[0].ToString());
            Dfs(num, 1, list, res);
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
                foreach (var item in op)
                {
                    list.Add(item);
                    list.Add(num.Substring());

                    Dfs(num, index + 1, list, res);

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
    }
}

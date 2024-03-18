using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0201_0250
{
    public class _227_BasicCalculatorIIAlg
    {
        int index = 0;
        char[] strNum;
        public int Calculate2(string s)
        {
            s = s.Trim();
            if (s.Length == 1)
                return Convert.ToInt32(s);
            strNum = s.Where(p => p != ' ').ToArray();
            Stack<int> list = new Stack<int>();

            while (index < strNum.Length)
            {
                if (strNum[index] == '+' || strNum[index]=='-')
                {
                    int num = GetNum();
                    list.Push(num);
                    continue;
                }
                else if (strNum[index] == '*' || strNum[index] == '/')
                {
                    int prev = list.Pop();
                    char op = strNum[index];

                    while (index < strNum.Length && (op == '*' || op == '/'))
                    {
                        index++;
                        int num2 = GetNum(); 
                        
                        if (op == '*')
                        {
                            prev = prev * num2;
                        }
                        else
                        {
                            prev = prev / num2;
                        }

                        if (index < strNum.Length)
                        {
                            op = strNum[index];
                        }
                    }
                    list.Push(prev);
                    continue;
                }
                else
                {
                    int num = GetNum();
                    list.Push(num);
                }

            }

            return list.Sum();
        }


        private int GetNum()
        {
            int op = 1;
            if (strNum[index] == '+')
            {
                index++;
            }
            else if (strNum[index] == '-')
            {
                index++;
                op = -1;
            }
            int res = 0;
            while (index < strNum.Length && char.IsDigit(strNum[index]))
            {
                res = res * 10 + strNum[index] - '0';
                index++;
            }
            return res * op;
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

            return stack.Sum();
        }


    }
}

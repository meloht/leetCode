using leetCode._101_150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0351_0400
{
    public class _394_DecodeStringAlg
    {
        string str;
        int index;
        public string DecodeString1(string s)
        {
            if (s.Length == 1)
                return s;
            str = s;
            index = 0;

            string ss = GetString();
            return ss;

        }

        private string GetString()
        {
            if (index >= str.Length || str[index] == ']')
            {
                return "";
            }
            StringBuilder sb = new StringBuilder();
            if (char.IsDigit(str[index]))
            {
                int num = GetNum();
                index++;
                string res = GetString();
                index++;

                for (int i = 0; i < num; i++)
                {
                    sb.Append(res);
                }
            }
            else
            {
                string res = GetStringList();
                sb.Append(res);
            }

            string ss = GetString();
            return sb.Append(ss).ToString();

        }
        private int GetNum()
        {
            int res = 0;
            while (index < str.Length && char.IsDigit(str[index]))
            {
                res = res * 10 + str[index] - '0';
                index++;
            }

            return res;
        }
        private string GetStringList()
        {
            StringBuilder sb = new StringBuilder();
            while (index < str.Length && char.IsLetter(str[index]))
            {
                sb.Append(str[index]);
                index++;
            }
            return sb.ToString();
        }


        public string DecodeString(string s)
        {
            StringBuilder sb = new StringBuilder();
            Stack<int> stack = new Stack<int>();
            int n = s.Length;
            int num = 0;
            for (int i = 0; i < n; i++)
            {
                var ch = s[i];
                if (char.IsDigit(ch))
                {
                    num = num * 10 + ch - '0';
                }
                else if (char.IsLetter(ch))
                {
                    sb.Append(ch);
                }
                else if (ch == '[')
                {
                    stack.Push(num);
                    num = 0;
                    sb.Append(ch);
                }
                else
                {
                    int index=sb.Length - 1;
                    List<char> list = new List<char>();
                    while (sb[index] != '[')
                    {
                        list.Add(sb[index]);
                        sb.Length = index;
                        index--;
                    }
                    sb.Length = index;
                    StringBuilder sb2 = new StringBuilder();
                    for (int j = list.Count - 1; j >= 0; j--)
                    {
                        sb2.Append(list[j]);
                    }
                    int count = stack.Pop();
                    string item = sb2.ToString();
                    for (int j = 0; j < count; j++)
                    {
                        sb.Append(item);
                    }
                }

            }
            return sb.ToString();
        }

    }
}

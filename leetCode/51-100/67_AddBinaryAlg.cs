using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._51_100
{
    public class _67_AddBinaryAlg
    {
        public string AddBinary(string a, string b)
        {
            string max = a;
            string min = b;
            List<char> list = new List<char>();
            if (b.Length > a.Length)
            {
                max = b;
                min = a;
            }
            char next = '0';
            for (int i = max.Length - 1, j = min.Length - 1; i >= 0; i--, j--)
            {
                if (j >= 0)
                {
                    char x = max[i];
                    char y = min[j];
                    char z = '0';
                    if (Add(x, y, next, ref z))
                    {
                        next = '1';
                    }
                    else
                    {
                        next = '0';
                    }
                    list.Add(z);
                }
                else
                {
                    char x = max[i];
                    char z = '0';
                    if (Add(x, '0', next, ref z))
                    {
                        next = '1';
                    }
                    else
                    {
                        next = '0';
                    }
                    list.Add(z);
                }
            }
            if (next == '1')
            {
                list.Add('1');
            }
            StringBuilder sb = new StringBuilder();
            for (int i = list.Count - 1; i >= 0; i--)
            {
                sb.Append(list[i]);
            }
            return sb.ToString();
        }
        private bool Add(char a, char b, char next, ref char res)
        {
            if (a == '1' && b == '1')
            {
                res = '0';
                if (next == '1')
                {
                    res = '1';
                }
                return true;
            }
            else if (a == '0' && b == '0')
            {
                res = '0';
                if (next == '1')
                {
                    res = '1';
                }
            }
            else
            {
                res = '1';
                if (next == '1')
                {
                    res = '0';
                    return true;
                }
            }
            return false;
        }
    }
}

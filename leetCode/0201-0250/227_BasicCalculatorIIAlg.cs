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
        public int Calculate(string s)
        {
            s = s.Trim();
            if (s.Length == 1)
                return Convert.ToInt32(s);
            strNum = s.ToCharArray();

            List<string> list = new List<string>();
            while (index < s.Length)
            {
                if (s[index] == ' ')
                {
                    index++;
                    continue;
                }
                if (char.IsDigit(s[index]))
                {
                    var num = GetNumString();
                    list.Add(num);
                    continue;
                }
                else
                {
                    list.Add(strNum[index].ToString());
                    index++;
                }
            }


            int ans = Calc(0, 0, list);

            return ans;
        }
        private int Calc(int num, int index, List<string> list)
        {
            if (index >= list.Count)
                return num;
            if (list[index] == "*")
            {
                index++;
                int n = int.Parse(list[index]);
                int res = n * num;
                return Calc(res, index + 1, list);
            }
            else if (list[index] == "/")
            {
                index++;
                int n = int.Parse(list[index]);
                int res = num / n;
                return Calc(res, index + 1, list);
            }
            else if (list[index] == "+")
            {
                index++;
                int n = int.Parse(list[index]);
                return num + Calc(n, index + 1, list);
            }
            else if(list[index] == "-")
            {
                index++;
                int n = int.Parse(list[index]);
                return num - Calc(n, index + 1, list);
            }
            else
            {
                int n = int.Parse(list[index]);
                return n;
            }

        }

        private string GetNumString()
        {
            StringBuilder sb = new StringBuilder();
            while (index < strNum.Length && char.IsDigit(strNum[index]))
            {
                sb.Append(strNum[index]);
                index++;
            }
            return sb.ToString();
        }

        private int GetNum()
        {
            int res = 0;
            while (index < strNum.Length && char.IsDigit(strNum[index]))
            {
                res = res * 10 + strNum[index] - '0';
                index++;
            }
            return res;
        }
    }
}

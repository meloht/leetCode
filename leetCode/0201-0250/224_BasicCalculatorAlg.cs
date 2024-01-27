using leetCode._0151_0200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0201_0250
{
    public class _224_BasicCalculatorAlg
    {

        int index = 0;
        char[] strNum;
        public int Calculate(string s)
        {
            s = s.Trim();
            if (s.Length == 1)
                return Convert.ToInt32(s);

            strNum = s.ToCharArray().Where(p => p != ' ').ToArray();
            int ans = Calc();
            return ans;
        }

        private int Calc()
        {
            if (index >= strNum.Length)
            {
                return 0;
            }
            if (strNum[index] == ')')
            {
                return 0;
            }
            int ans = 0;
            if (char.IsDigit(strNum[index]))
            {
                int num = ComputNum();
                ans += num;
            }
            else if (strNum[index] == '-' && index + 1 < strNum.Length && char.IsDigit(strNum[index + 1]))
            {
                int num = ComputNum();
                ans += num;
            }
            else if (strNum[index] == '-' && index + 1 < strNum.Length && strNum[index + 1] == '(')
            {
                index += 2;
                ans = ans - Calc();
                index++;
            }
            else if (strNum[index] == '(')
            {
                index++;
                ans = ans + Calc();
                index++;
            }
            else if (strNum[index]=='+')
            {
                index++;
            }
            ans = ans + Calc();
            return ans;
        }

        private int ComputNum()
        {
            if (index >= strNum.Length || strNum[index] == '(' || strNum[index] == ')')
            {
                return 0;
            }
            if (strNum[index] == '-' && index + 1 < strNum.Length && strNum[index + 1] == '(')
            {
                return 0;
            }
            int num = 0;
            if (strNum[index] == '-')
            {
                index++;
                num = -GetNum();
            }
            else if (char.IsDigit(strNum[index]))
            {
                num = GetNum();
            }
            else if (strNum[index] == '+')
            {
                index++;
                num = GetNum();
            }

            int ans = num + ComputNum();
            return ans;
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

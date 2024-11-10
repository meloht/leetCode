using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0551_0600
{
    public class _592_FractionAdditionAndSubtractionAlg
    {


        public string FractionAddition(string expression)
        {
            long x = 0, y = 1; // 分子，分母
            int index = 0, n = expression.Length;
            while (index < n)
            {
                // 读取分子
                long x1 = 0, sign = 1;
                if (expression[index] == '-' || expression[index] == '+')
                {
                    sign = expression[index] == '-' ? -1 : 1;
                    index++;
                }
                while (index < n && char.IsDigit(expression[index]))
                {
                    x1 = x1 * 10 + expression[index] - '0';
                    index++;
                }
                x1 = sign * x1;
                index++;

                // 读取分母
                long y1 = 0;
                while (index < n && char.IsDigit(expression[index]))
                {
                    y1 = y1 * 10 + expression[index] - '0';
                    index++;
                }

                x = x * y1 + x1 * y;
                y *= y1;
            }
            if (x == 0)
            {
                return "0/1";
            }
            long g = GCD(Math.Abs(x), y); // 获取最大公约数
            return (x / g).ToString() + "/" + (y / g).ToString();
        }

        public long GCD(long a, long b)
        {
            long remainder = a % b;
            while (remainder != 0)
            {
                a = b;
                b = remainder;
                remainder = a % b;
            }
            return b;
        }


    }
}

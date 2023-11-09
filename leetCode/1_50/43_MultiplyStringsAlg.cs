using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1_50
{
    public class _43_MultiplyStringsAlg
    {
        public string Multiply(string num1, string num2)
        {
            if (num1 == "0" || num2 == "0")
                return "0";

            int countA = 0;
            string sum = null;
            for (int i = num1.Length - 1; i >= 0; i--)
            {
                int numA = num1[i] - '0';
                int countB = 0;

                for (int j = num2.Length - 1; j >= 0; j--)
                {
                    int numB = num2[j] - '0';
                    int res = numA * numB;
                    if (res > 0)
                    {
                        string item = res.ToString();
                        item = item.PadRight(item.Length + countB + countA, '0');
                        if (sum == null)
                        {
                            sum = item;
                        }
                        else
                        {
                            sum = Add(sum, item);
                        }
                    }
                    countB++;

                }
                countA++;
            }

            return sum;
        }

        private string Add(string num1, string num2)
        {
            string min = num1;
            string max = num2;
            if (num2.Length < num1.Length)
            {
                min = num2;
                max = num1;
            }
            int next = 0;
            Stack<int> list = new Stack<int>();
            int n = max.Length - 1;
            for (int i = min.Length - 1; i >= 0 && n >= 0; i--, n--)
            {
                int numA = min[i] - '0';
                int numB = max[n] - '0';
                int sum = numA + numB + next;
                next = 0;
                if (sum >= 10)
                {
                    next = 1;
                    list.Push(sum % 10);
                }
                else
                {
                    list.Push(sum);
                }

            }
            for (int i = n; i >= 0; i--)
            {
                int num = max[i] - '0';
                int sum = num + next;
                next = 0;
                if (sum >= 10)
                {
                    next = 1;
                    list.Push(sum % 10);
                }
                else
                {
                    list.Push(sum);
                }
            }
            if (next > 0)
            {
                list.Push(next);
            }

            StringBuilder sb = new StringBuilder();
            while (list.Count > 0)
            {
                sb.Append(list.Pop());
            }

            return sb.ToString();
        }

    }
}

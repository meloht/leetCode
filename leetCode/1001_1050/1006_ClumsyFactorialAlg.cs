using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1001_1050
{
    public class _1006_ClumsyFactorialAlg
    {
        public int Clumsy(int n)
        {
            int prev = 0;
            int curr = n;
            bool bl = false;
            char[] arr = ['*', '/', '+', '-'];

            for (int i = n - 1, j = 0; i > 0; i--)
            {
                char op = arr[j];
                if (op == '*')
                {
                    curr = curr * i;
                }
                else if (op == '/')
                {
                    curr = curr / i;
                }
                else if (op == '+')
                {
                    if (bl)
                    {
                        curr = prev - curr;
                    }
                    curr += i;
                    bl = false;
                }
                else if (op == '-')
                {
                    prev = curr;
                    curr = i;
                    bl = true;
                }

                j++;
                j = j % 4;
            }
            if (bl)
            {
                return prev - curr;
            }
            else
            {
               return curr;
            }
        }
    }
}

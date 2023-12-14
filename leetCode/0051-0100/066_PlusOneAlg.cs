using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._51_100
{
    public class _66_PlusOneAlg
    {
        public int[] PlusOne(int[] digits)
        {
            List<int> list = digits.ToList();
            int next = 0;
            int num = digits[digits.Length - 1] + 1;
            if (num >= 10)
            {
                int mm = num % 10;
                list[digits.Length - 1] = mm;
                next = 1;
            }
            else
            {
                list[digits.Length - 1] = num;
            }
            for (int i = digits.Length - 2; i >= 0; i--)
            {

                int num1 = digits[i] + next;
                if (num1 >= 10)
                {
                    int mm = num1 % 10;
                    list[i] = mm;
                    next = 1;
                }
                else
                {
                    next = 0;
                    list[i] = num1;
                }

            }
            if (next > 0)
            {
                list.Insert(0, 1);
            }
            return list.ToArray();
        }
    }
}

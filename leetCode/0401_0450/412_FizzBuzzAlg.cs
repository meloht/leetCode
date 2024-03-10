using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0401_0450
{
    public class _412_FizzBuzzAlg
    {
        public IList<string> FizzBuzz(int n)
        {
            string[] arr = new string[n];
            for (int i = 1; i <= n; i++)
            {
                bool flag3 = i % 3 == 0;
                bool flag5 = i % 5 == 0;
                if (flag3 && flag5)
                {
                    arr[i - 1] = "FizzBuzz";
                }
                else if (flag3)
                {
                    arr[i - 1] = "Fizz";
                }
                else if (flag5)
                {
                    arr[i - 1] = "Buzz";
                }
                else
                {
                    arr[i - 1] = i.ToString();
                }
            }
            return arr;
        }
    }
}

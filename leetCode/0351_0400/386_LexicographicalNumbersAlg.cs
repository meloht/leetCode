using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0351_0400
{
    public class _386_LexicographicalNumbersAlg
    {
        public IList<int> LexicalOrder1(int n)
        {
            List<string> ls = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                ls.Add(i.ToString());
            }
            ls.Sort();
            List<int> res = ls.Select(p => int.Parse(p)).ToList();

            return res;
        }

        public IList<int> LexicalOrder(int n)
        {
            IList<int> ret = new List<int>();
            int number = 1;
            for (int i = 0; i < n; i++)
            {
                ret.Add(number);
                if (number * 10 <= n)
                {
                    number *= 10;
                }
                else
                {
                    while (number % 10 == 9 || number + 1 > n)
                    {
                        number /= 10;
                    }
                    number++;
                }
            }
            return ret;
        }


    }
}

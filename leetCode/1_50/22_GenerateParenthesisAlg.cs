using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1_50
{
    internal class GenerateParenthesisAlg
    {
        public IList<string> GenerateParenthesis(int n)
        {
            List<List<string>> total = new List<List<string>>();
            if (n == 0)
                return new List<string>();

            total.Add(new List<string>() { "" });
            total.Add(new List<string>() { "()" });

            for (int i = 2; i < n + 1; i++)
            {
                List<string> list = new List<string>();
                for (int j = 0; j < i; j++)
                {
                    List<string> nowList1 = total[j];
                    List<string> nowList2 = total[i - 1 - j];
                    foreach (var k1 in nowList1)
                    {
                        foreach (var k2 in nowList2)
                        {
                            string el = "(" + k1 + ")" + k2;
                            list.Add(el);
                        }
                    }
                }
                total.Add(list);
            }

            return total[n];
        }
    }
}

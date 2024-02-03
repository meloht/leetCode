using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1_50
{
    public class GenerateParenthesisAlg
    {
        public IList<string> GenerateParenthesis1(int n)
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

        public IList<string> GenerateParenthesis(int n)
        {
            int m = 2 * n;
            char[] list = new char[m];
            Array.Fill(list, ' ');
            List<string> res = new List<string>();
            Dfs(0, 0, m, n, list, res);
            return res;
        }
        private void Dfs(int i,int open,int m,int n, char[] ls,List<string> res)
        {
            if (i == m)
            {
                res.Add(new string(ls));
                return;
            }

            if (open < n)
            {
                ls[i] = '(';
                Dfs(i + 1, open + 1, m, n, ls, res);
            }
            if (i - open < open)
            {
                ls[i] = ')';
                Dfs(i + 1, open, m, n, ls, res);
            }
           
        }

    }
}

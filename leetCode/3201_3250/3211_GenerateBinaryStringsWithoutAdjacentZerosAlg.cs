using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3201_3250
{
    public class _3211_GenerateBinaryStringsWithoutAdjacentZerosAlg
    {
        IList<string> res = new List<string>();
        int n;

        public IList<string> ValidStrings(int n)
        {
            this.n = n;
            Dfs(new StringBuilder());
            return res;
        }

        public void Dfs(StringBuilder sb)
        {
            if (sb.Length == n)
            {
                res.Add(sb.ToString());
            }
            else
            {
                if (sb.Length == 0 || sb[sb.Length - 1] == '1')
                {
                    sb.Append('0');
                    Dfs(sb);
                    sb.Length--;
                }
                sb.Append('1');
                Dfs(sb);
                sb.Length--;
            }
        }

        public List<string> ValidStrings2(int n)
        {
            List<string> res = new List<string>();
            int mask = (1 << n) - 1;
            for (int i = 0; i < 1 << n; i++)
            {
                int t = mask ^ i;
                if (((t >> 1) & t) == 0)
                {
                    string str = Convert.ToString(i,2); 
                    StringBuilder sb = new StringBuilder();
                    for (int j = n - str.Length; j > 0; j--)
                    {
                        sb.Append('0');
                    }
                    sb.Append(str);
                    res.Add(sb.ToString());
                }
            }
            return res;
        }


    }
}

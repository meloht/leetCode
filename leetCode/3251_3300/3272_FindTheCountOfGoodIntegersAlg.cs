using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._3251_3300
{
    public class _3272_FindTheCountOfGoodIntegersAlg
    {
        public long CountGoodIntegers(int n, int k)
        {
            int[] fac = new int[n + 1];
            fac[0] = 1;

            for (int i = 1; i <= n; i++)
            {
                fac[i] = fac[i - 1] * i;
            }

            long ans = 0;
            int skip = n & 1;
            HashSet<string> vis = new HashSet<string>();
            int baseVal = (int)Math.Pow(10, (n - 1) / 2);
            for (int i = baseVal; i < baseVal * 10; i++)
            { // 枚举回文数左半边
                string s = i.ToString(); ;
                var chs = s.ToCharArray();
                Array.Reverse(chs);
                s += new string(chs).Substring(skip);
                if (long.Parse(s) % k > 0)
                { // 回文数不能被 k 整除
                    continue;
                }

                char[] sortedS = s.ToCharArray();
                Array.Sort(sortedS);
                if (!vis.Add(new string(sortedS)))
                { // 不能重复统计
                    continue;
                }

                int[] cnt = new int[10];
                foreach (char c in sortedS)
                {
                    cnt[c - '0']++;
                }
                int res = (n - cnt[0]) * fac[n - 1];
                foreach (int c in cnt)
                {
                    res /= fac[c];
                }
                ans += res;
            }
            return ans;

          
        }
    }
}

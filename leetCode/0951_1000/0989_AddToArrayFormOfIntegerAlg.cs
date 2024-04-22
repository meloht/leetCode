using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0951_1000
{
    public class _0989_AddToArrayFormOfIntegerAlg
    {
        public IList<int> AddToArrayForm(int[] num, int k)
        {
            string kk = k.ToString();
            var ans = AddStrings(num, kk);

            return ans;
        }

        private List<int> AddStrings(int[] num1, string num2)
        {
            int i = num1.Length - 1, j = num2.Length - 1, add = 0;
            List<int> ans = new List<int>();
            while (i >= 0 || j >= 0 || add != 0)
            {
                int x = i >= 0 ? num1[i] : 0;
                int y = j >= 0 ? num2[j] - '0' : 0;
                int result = x + y + add;
                ans.Add(result % 10);
                add = result / 10;
                i--;
                j--;
            }
            List<int> list = new List<int>();
            for (int k = ans.Count - 1; k >= 0; k--)
            {
                list.Add(ans[k]);
            }
            return list;
        }
    }
}

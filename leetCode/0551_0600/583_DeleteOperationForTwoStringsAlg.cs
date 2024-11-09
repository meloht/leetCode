using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0551_0600
{
    public class _583_DeleteOperationForTwoStringsAlg
    {
        public int MinDistance(string word1, string word2)
        {

            char[] t = word2.ToCharArray();
            int m = t.Length;
            int[] f = new int[m + 1];
            foreach (char x in word1)
            {
                int pre = 0; // f[0]
                for (int j = 0; j < m; j++)
                {
                    int tmp = f[j + 1];
                    f[j + 1] = x == t[j] ? pre + 1 : Math.Max(f[j + 1], f[j]);
                    pre = tmp;
                }
            }
            int len = f[m];
            return word1.Length - len + word2.Length - len;


        }
    }
}

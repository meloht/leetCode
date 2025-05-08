using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0951_1000
{
    public class _0955_DeleteColumnsToMakeSortedIIAlg
    {
        public int MinDeletionSize(string[] strs)
        {
            int ans = 0;
            int n = strs[0].Length;
            bool[] del = new bool[n];

            for (int i = 1; i < strs.Length; i++)
            {
                string s1 = strs[i - 1];
                string s2 = strs[i];
                bool bl = false;
                for (int j = 0; j < n; j++)
                {
                    if (del[j])
                        continue;
                    if (s2[j] > s1[j])
                    {
                        break;
                    }
                    else if (s2[j] < s1[j])
                    {
                        del[j] = true;
                        ans++;
                        bl = true;
                    }

                }
                if (bl)
                {
                    i = 0;
                }
            }


            return ans;
        }
    }
}

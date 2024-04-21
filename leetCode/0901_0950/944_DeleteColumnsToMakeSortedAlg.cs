using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0901_0950
{
    public class _944_DeleteColumnsToMakeSortedAlg
    {
        public int MinDeletionSize(string[] strs)
        {
            int m = strs.Length;
            int n = strs[0].Length;
            int ans = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j < m; j++)
                {
                    char prev = strs[j - 1][i];
                    char curr = strs[j][i];
                    if (prev > curr)
                    {
                        ans++;
                        break;
                    }
                }
            }
            return ans;
        }
    }
}

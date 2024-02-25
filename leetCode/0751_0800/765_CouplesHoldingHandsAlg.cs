using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0751_0800
{
    public class _765_CouplesHoldingHandsAlg
    {
        public int MinSwapsCouples(int[] row)
        {
            int ans = 0;
            for (int i = 0; i < row.Length; i += 2)
            {
                int x = row[i];
                int y = x ^ 1;
                if (row[i + 1] == y)
                {
                    continue;
                }
                for (int j = 0; j < row.Length; j++)
                {
                    if (i == j)
                        continue;
                    if (row[j] == y)
                    {
                        int temp = row[i + 1];
                        row[i + 1] = row[j];
                        row[j] = temp;
                        ans++;
                        break;
                    }
                }
            }
            return ans;
        }
    }
}

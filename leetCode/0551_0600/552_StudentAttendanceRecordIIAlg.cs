using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0551_0600
{
    public class _552_StudentAttendanceRecordIIAlg
    {
       
        public int CheckRecord(int n)
        {
            return Dfs(0, n, 0, 0);
        }

        private int Dfs(int idx, int n, int a, int l)
        {
            if (a > 1)
            {
                return 0;
            }
            if (l >= 3)
            {
                return 0;
            }
            if (idx >= n)
            {
                return 1;
            }
            int ans = 0;
            if (l > 0)
            {
                ans += Dfs(idx + 1, n, a, l + 1);
            }
            else
            {
                ans += Dfs(idx + 1, n, a, 1);
            }
            ans += Dfs(idx + 1, n, a + 1, 0);
            ans += Dfs(idx + 1, n, a, 0);
            return ans;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0601_0650
{
    public class _650_2KeysKeyboardAlg
    {
        public int MinSteps(int n)
        {
            int ans = 0;
            for (int i = 2; i * i <= n; ++i)
            {
                while (n % i == 0)
                {
                    n /= i;
                    ans += i;
                }
            }
            if (n > 1)
            {
                ans += n;
            }
            return ans;
        }



       
    }
}

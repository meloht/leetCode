using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0351_0400
{
    public class _367_ValidPerfectSquareAlg
    {
        public bool IsPerfectSquare(int num)
        {
            int n = MySqrt(num);
            if (n * n == num)
            { 
                return true;
            }

            return false;
        }

        public int MySqrt(int x)
        {
            int l = 0, r = x, ans = -1;
            while (l <= r)
            {
                int mid = l + (r - l) / 2;
                if ((long)mid * mid <= x)
                {
                    ans = mid;
                    l = mid + 1;
                }
                else
                {
                    r = mid - 1;
                }
            }
            return ans;
        }

    }
}

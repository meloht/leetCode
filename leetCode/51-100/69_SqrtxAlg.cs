using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._51_100
{
    public class _69_SqrtxAlg
    {
        public int MySqrt(int x)
        {
            if (x == 0)
                return 0;
            if (x == 1)
                return 1;

            return 0;
        }

        private int GetRes(int left, int right, int target)
        {
            int mid = (left + right) / 2;

            int mm = mid * mid;

            int n1 = 0;
            int n2 = 0;
            if (mm > target)
            {
                n1 = GetRes(left, mid, target);
            }
            else
            {
                n2 = GetRes(mid, right, target);
            }
            

            return 0;
        }
    }
}

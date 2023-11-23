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
            int n = GetRes(0, x, x);
            return n;
        }

        private int GetRes(int left, int right, int target)
        {
            int mid = (left + right) / 2;

            int mmPre = Sqrt(mid - 1);
            int mm = Sqrt(mid);
            int mmLast = Sqrt(mid + 1);

            if (target >= mmPre && target < mm)
            {
                return mid - 1;
            }
            if (target >= mm && target < mmLast)
            {
                return mid;
            }
            if (mmPre > target)
            {
                return GetRes(left, mid - 1, target);
            }
            if (mmLast < target)
            {
                return GetRes(mid + 1, right, target);
            }
            return 0;
        }

        private int Sqrt(int num)
        {
            if (num < 0)
                return 0;
            return num * num;
        }


    }
}

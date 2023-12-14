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
            int right = GetRight(x);
            int n = GetRes(0, right, x);
            return n;
        }

        private int GetRes(int left, int right, int target)
        {
            int mid = (left + right) / 2;

            long mmPre = Sqrt(mid - 1);
            long mm = Sqrt(mid);
            long mmLast = Sqrt(mid + 1);

            if (target >= mmPre && target < mm)
            {
                return mid - 1;
            }
            if (target >= mm && target < mmLast)
            {
                return mid;
            }
            if (mmLast == target)
            {
                return mid + 1;
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

        private long Sqrt(long num)
        {
            if (num < 0)
                return 0;
            return num * num;
        }

        private int GetRight(int target)
        {
            int len = target.ToString().Length;
            if (len <= 2)
            {
                if (target < 10)
                    return target;
                return 10;
            }
            int count = (len + 1) / 2;
            int num = (int)Math.Pow(10, count);
           
            return num;
        }


    }
}

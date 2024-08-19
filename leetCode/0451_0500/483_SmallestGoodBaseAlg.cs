using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0451_0500
{
    public class _483_SmallestGoodBaseAlg
    {
        public string SmallestGoodBase1(string n)
        {
            long nVal = long.Parse(n);
            int mMax = (int)Math.Floor(Math.Log(nVal) / Math.Log(2));
            for (int m = mMax; m > 0; m--)
            {
                int k = (int)Math.Pow(nVal, 1.0 / m);
                long mul = 1, sum = 1;
                for (int i = 0; i < m; i++)
                {
                    mul *= k;
                    sum += mul;
                }
                if (sum == nVal)
                {
                    return k.ToString();
                }

            }
            return (nVal - 1).ToString();
        }

        public string SmallestGoodBase(string n)
        {
            long nVal = long.Parse(n);
            int mMax = (int)(Math.Log(nVal) / Math.Log(2) + 1);
            for (int len = mMax; len >= 3; len--)
            {
                long l = 2;
                long r = nVal - 1;
                while (l < r)
                {
                    long mid = (l + r) >> 1;
                    if (Check(mid, len, nVal) >= 0)
                    {
                        r = mid;
                    }
                    else
                    {
                        l = mid + 1;
                    }
                }
                if (Check(r, len, nVal) == 0)
                {
                    return r.ToString();
                }

            }
            return (nVal - 1).ToString();
        }

        private int Check(long k, int len, long t)
        {
            long ans = 1;
            for (int i = 1; i < len; i++)
            {
                if (ans > (t - 1) / k)
                    return 1;
                ans = ans * k + 1;
            }
            if (ans == t)
                return 0;
            return ans - t > 0 ? 1 : -1;
        }
    }
}

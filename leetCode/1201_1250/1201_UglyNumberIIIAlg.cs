using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1201_1250
{
    public class _1201_UglyNumberIIIAlg
    {
        public int NthUglyNumber(int n, int a, int b, int c)
        {
            long low = Math.Min(c, Math.Min(a, b));
            long high = low * n;
            long res = BinarySearch(low, high, a, b, c, n);

            long left_a = res % a;
            long left_b = res % b;
            long left_c = res % c;

            return (int)(res - Math.Min(left_a, Math.Min(left_b, left_c)));

        }

        private long BinarySearch(long low,long high,int a,int b,int c,long n)
        {
            if (low >= high)
            {
                return low;
            }
            long mid = (low + high) >> 1;
            long MCM_a_b = Lcm(a, b);
            long MCM_a_c = Lcm(a, c);
            long MCM_b_c = Lcm(b, c);
            long MCM_a_b_c = Lcm(MCM_a_b, c);


            long count_n = mid / a + mid / b + mid / c - mid / MCM_a_b - mid / MCM_b_c - mid / MCM_a_c + mid / MCM_a_b_c;

            if (count_n == n) return mid;

            if (count_n < n) return BinarySearch(mid + 1, high, a, b, c, n);

            return BinarySearch(low, mid - 1, a, b, c, n);



        }

        // 计算两个数的最大公约数 (GCD)
        public static long Gcd(long a, long b)
        {
            if (b == 0)
            {
                return a;
            }
            return Gcd(b, a % b);
        }

        // 计算两个数的最小公倍数 (LCM)
        public static long Lcm(long a, long b)
        {
            return (a * b) / Gcd(a, b);
        }
    }
}

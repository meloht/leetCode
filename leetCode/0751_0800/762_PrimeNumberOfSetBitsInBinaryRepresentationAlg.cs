using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0751_0800
{
    
    public class _762_PrimeNumberOfSetBitsInBinaryRepresentationAlg
    {
        public int CountPrimeSetBits(int left, int right)
        {
            int ans = 0;
            for (int i = left; i <= right;i++) 
            {
                int count = GetCount(i);
                if (IsPrime(count))
                {
                    ans++;
                }
            }
            return ans;
        }
        private int GetCount(int num)
        {
            int count = 0;
            while (num > 0)
            {
                if (num % 2 == 1)
                {
                    count++;
                }
                num = num / 2;
               
            }
            return count;
        }
        private static int BitCount(int i)
        {
            i = i - ((i >> 1) & 0x55555555);
            i = (i & 0x33333333) + ((i >> 2) & 0x33333333);
            i = (i + (i >> 4)) & 0x0f0f0f0f;
            i = i + (i >> 8);
            i = i + (i >> 16);
            return i & 0x3f;
        }


        public static bool IsPrime(int n)
        {
            if (n <= 1)
                return false;
            if (n <= 3)
                return true;

            if (n % 2 == 0 || n % 3 == 0)
                return false;

            for (int i = 5; i * i <= n; i += 6)
            {
                if (n % i == 0 || n % (i + 2) == 0)
                    return false;
            }

            return true;
        }
    }
}

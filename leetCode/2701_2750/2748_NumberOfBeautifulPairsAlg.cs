using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2701_2750
{
    public class _2748_NumberOfBeautifulPairsAlg
    {
        public int CountBeautifulPairs(int[] nums)
        {
            int ans = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int n1 = GetFirstNum(nums[i]);
                for (int j = i + 1; j < nums.Length; j++)
                {
                    int n2 = nums[j] % 10;
                    if (Gcd(n1, n2) == 1)
                    {
                        ans++;
                    }
                }
            }
            return ans;
        }
        public int CountBeautifulPairs1(int[] nums)
        {
            int ans = 0;
            int[] cnt = new int[10];
            foreach (int x in nums)
            {
                for (int i = 1; i < 10; i++)
                {
                    if (Gcd(x % 10, i) == 1)
                    {
                        ans += cnt[i];
                    }
                }
                int x2 = x;
                while (x2 >= 10)
                {
                    x2 /= 10;
                }
                cnt[x2]++;
            }
            return ans;
        }

        private int GetFirstNum(int num)
        {
            if (num < 10)
                return num;

            while (num >= 10)
            {
                num /= 10;
            }
            return num;
        }
        public int Gcd(int x, int y)
        {
            return x == 0 ? y : Gcd(y % x, x);
        }
    }
}

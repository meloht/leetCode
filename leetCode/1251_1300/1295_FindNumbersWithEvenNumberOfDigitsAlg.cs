using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1251_1300
{
    public class _1295_FindNumbersWithEvenNumberOfDigitsAlg
    {
        public int FindNumbers(int[] nums)
        {
            int ans = 0;
            foreach (var item in nums)
            {
                int n = item;
                int cnt = 0;
                while (n > 0)
                {
                    n /= 10;
                    cnt++;
                }
                if ((cnt & 1) == 0)
                {
                    ans++;
                }
            }

            return ans;
        }
    }
}

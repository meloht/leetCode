using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1351_1400
{
    public class _1390_FourDivisorsAlg
    {
        public int SumFourDivisors(int[] nums)
        {
            int ans = 0;
            foreach (int num in nums)
            {
                // factor_cnt: 因数的个数
                // factor_sum: 因数的和
                int factor_cnt = 0, factor_sum = 0;
                for (int i = 1; i * i <= num; ++i)
                {
                    if (num % i == 0)
                    {
                        ++factor_cnt;
                        factor_sum += i;
                        if (i * i != num)
                        {   // 判断 i 和 num/i 是否相等，若不相等才能将 num/i 看成新的因数
                            ++factor_cnt;
                            factor_sum += num / i;
                        }
                    }
                }
                if (factor_cnt == 4)
                {
                    ans += factor_sum;
                }
            }
            return ans;


        }
    }
}

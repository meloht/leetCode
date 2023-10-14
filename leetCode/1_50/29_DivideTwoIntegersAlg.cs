using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1_50
{
    internal class DivideTwoIntegersAlg
    {
        public int Divide(int dividend, int divisor)
        {
            bool sign = (dividend > 0) ^ (divisor > 0);
            int result = 0;
            if (dividend > 0)
            {
                dividend = -dividend;
            }
            if (divisor > 0) divisor = -divisor;
            while (dividend <= divisor)
            {
                int temp_result = -1;
                int temp_divisor = divisor;
                while (dividend <= (temp_divisor << 1))
                {
                    if (temp_divisor <= (int.MinValue >> 1)) break;
                    temp_result = temp_result << 1;
                    temp_divisor = temp_divisor << 1;
                }
                dividend = dividend - temp_divisor;
                result += temp_result;
            }
            if (!sign)
            {
                if (result <= int.MinValue) return int.MaxValue;
                result = -result;
            }
            return result;
        }
    }
}

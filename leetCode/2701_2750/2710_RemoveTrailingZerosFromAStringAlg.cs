using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2701_2750
{
    public class _2710_RemoveTrailingZerosFromAStringAlg
    {
        public string RemoveTrailingZeros(string num)
        {
            int count = 0;
            for (int i = num.Length - 1; i >= 0; i--)
            {
                if (num[i] == '0')
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            if (count == num.Length)
                return string.Empty;
            return num.Substring(0, num.Length - count);
        }
    }
}

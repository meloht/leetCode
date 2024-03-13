using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2851_2900
{
    public class _2864_MaximumOddBinaryNumberAlg
    {
        public string MaximumOddBinaryNumber(string s)
        {
            StringBuilder sb = new StringBuilder();
            int count = s.Count(p => p == '1');
            if (count > 1)
            {
                for (int i = 1; i < count; i++)
                {
                    sb.Append("1");
                }
            }
          
            int zero = s.Length - count;
            for (int i = 0; i < zero; i++)
            {
                sb.Append("0");
            }
            sb.Append("1");

            return sb.ToString();
        }
    }
}

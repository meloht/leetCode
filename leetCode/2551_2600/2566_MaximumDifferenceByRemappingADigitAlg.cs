using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2551_2600
{
    public class _2566_MaximumDifferenceByRemappingADigitAlg
    {
        public int MinMaxDifference(int num)
        {
            string s = num.ToString();
            int mx = num;
            var chs = s.ToCharArray();
            foreach (char c in chs)
            {
                if (c != '9')
                { // 第一个不等于 9 的字符
                    mx = int.Parse(s.Replace(c, '9')); // 替换成 9
                    break;
                }
            }
            // 第一个不等于 0 的字符，替换成 0
            int mn = int.Parse(s.Replace(s[0], '0'));
            return mx - mn;


        }
    }
}

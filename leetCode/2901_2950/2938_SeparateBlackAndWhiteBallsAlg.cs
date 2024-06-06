using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2901_2950
{
    public class _2938_SeparateBlackAndWhiteBallsAlg
    {
        public long MinimumSteps(string s)
        {
            int count = s.Count(p => p == '0');

            long ans = 0;
            List<int> ls1=new List<int>();
            List<int> ls0 = new List<int>();
            for (int i = 0; i < count; i++)
            {
                if (s[i] == '1')
                {
                    ls1.Add(i);
                }
            }
            for (int i = count; i < s.Length; i++)
            {
                if (s[i] == '0')
                {
                    ls0.Add(i);
                }
            }

            for (int i = ls0.Count-1 ; i >=0; i--)
            {
                ans += (ls0[i] - ls1[i]);
            }

            return ans;
        }
    }
}

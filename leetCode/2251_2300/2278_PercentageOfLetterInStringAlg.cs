using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2251_2300
{
    public class _2278_PercentageOfLetterInStringAlg
    {
        public int PercentageLetter(string s, char letter)
        {
            int ans = s.Count(p=>p==letter)*100/s.Length;

            return ans;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1001_1050
{
    public class _1003_CheckIfWordIsValidAfterSubstitutionsAlg
    {
        public bool IsValid(string s)
        {
           var ss=s.ToCharArray();

            int i = 0;
            foreach (char c in s) 
            {
                if (c > 'a' && (i == 0 || c - ss[--i] != 1))
                {
                    return false;
                }
                if (c < 'c')
                {
                    ss[i++] = c;
                }
            }

            return i==0;
        }
    }
}

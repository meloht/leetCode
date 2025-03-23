using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2101_2150
{
    public class _2116_CheckIfAParenthesesStringCanBeValidAlg
    {
        public bool CanBeValid(string s, string locked)
        {
            if (s.Length % 2 > 0)
            {
                return false;
            }
            int mn = 0;
            int mx = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (locked[i] == '1')
                {
                    int d = s[i] == '(' ? 1 : -1;
                    mx += d;
                    if (mx < 0)
                    {
                        return false;
                    }
                    mn += d;
                }
                else
                {
                    mx++;
                    mn--;
                }
                if (mn < 0)
                {
                    mn = 1;
                }
            }

            return mn == 0; 
        }
    }
}

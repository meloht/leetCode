using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1951_2000
{
    public class _1963_MinimumNumberOfSwapsToMakeTheStringBalancedAlg
    {
        public int MinSwaps(string s)
        {
            int c = 0;
            foreach (var item in s)
            {
                if (item == '[' || c == 0)
                {
                    c++;
                }
                else
                {
                    c--;
                }
            }

            return c/2;
        }
    }
}

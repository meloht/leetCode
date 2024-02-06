using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1651_1700
{
    public class _1672_RichestCustomerWealthAlg
    {
        public int MaximumWealth(int[][] accounts)
        {
            int max = accounts.Select(p => p.Sum()).Max();
            return max;
        }
    }
}

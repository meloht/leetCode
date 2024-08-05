using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0451_0500
{
    public class _473_MatchsticksToSquareAlg
    {
        public bool Makesquare(int[] matchsticks)
        {
            long sum = 0L;
            foreach (var item in matchsticks)
            {
                sum+= item;
            }
            if (sum % 4 > 0)
                return false;


            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2701_2750
{
    public class _2739_TotalDistanceTraveledAlg
    {
        public int DistanceTraveled(int mainTank, int additionalTank)
        {
            int ans = 0;
            int i = mainTank;
           
            while (i >= 5) 
            {
                i -= 5;
                ans += 50;
                if (additionalTank > 0)
                {
                    i++;
                    additionalTank--;
                }
            }
          
            if (i > 0)
            {
                ans += i * 10;
            }
            return ans;
        }
    }
}

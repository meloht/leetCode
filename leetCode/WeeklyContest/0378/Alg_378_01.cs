using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode.WeeklyContest._0378
{
    public class Alg_378_01
    {
        public bool HasTrailingZeros(int[] nums)
        {
            int count = 0;
            foreach (int i in nums)
            {
                if (i % 2 == 0)
                {
                    count++;
                }
            }
            if(count>=2)
                return true;
            return false;
        }
    }
}

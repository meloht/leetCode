using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1101_1150
{
    public class _1103_DistributeCandiesToPeopleAlg
    {
        public int[] DistributeCandies(int candies, int num_people)
        {
            int[] ans = new int[num_people];
            int num = 1;
            int i = 0;
            while (candies > 0)
            {
                if (candies > num)
                {
                    ans[i] += num;
                    candies -= num;
                }
                else
                {
                    ans[i] += candies;
                    candies = 0;
                }
                i++;
                if (i % num_people == 0)
                {
                    i = 0;
                }
                num++;
            }
            return ans;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode.WeeklyContest._400
{
    public class Alg_400_01
    {
        public int MinimumChairs(string s)
        {
            int ans = 0;
            int num = 0;
            foreach (char item in s)
            {
                if (item == 'E')
                {
                    if (num > 0)
                    {
                        num--;
                    }
                    else
                    {
                        ans++;
                    }
                  
                }
                else
                {
                    num++;
                }
            }
            return ans;
        }
    }
}

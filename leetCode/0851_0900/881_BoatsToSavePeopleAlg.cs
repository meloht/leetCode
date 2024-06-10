using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0851_0900
{
    public class _881_BoatsToSavePeopleAlg
    {
        public int NumRescueBoats(int[] people, int limit)
        {
            Array.Sort(people);
            int ans = 0;
            for (int i = 0, j = people.Length - 1; i <= j; i++, j--)
            {
                if (i == j)
                {
                    ans++;
                }
                else
                {
                    if (people[i] + people[j] <= limit)
                    {
                        ans++;
                    }
                    else
                    {
                        while (j > i && people[i] + people[j] > limit)
                        {
                            j--;
                            ans++;
                        }
                        ans++;
                    }
                }


            }
            return ans;
        }

        public int NumRescueBoats1(int[] people, int limit)
        {
            int ans = 0;
            Array.Sort(people);
            int light = 0, heavy = people.Length - 1;
            while (light <= heavy)
            {
                if (people[light] + people[heavy] <= limit)
                {
                    ++light;
                }
                --heavy;
                ++ans;
            }
            return ans;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode.WeeklyContest._0401
{
    public class Alg_01
    {
        public int NumberOfChild(int n, int k)
        {

            int index = 0;
            bool bl = true;
            while (k > 0)
            {

                if (index == n - 1)
                {
                    bl = false;
                }
                if (index == 0)
                {
                    bl = true;
                }
                if (bl)
                {
                    index++;

                }
                else
                {
                    index--;
                }
                k--;
            }

            return index;
        }

        public int NumberOfChild1(int n, int k)
        {
            int t = k % (n - 1);
            return k / (n - 1) % 2 > 0 ? n - t - 1 : t;
        }
    }
}

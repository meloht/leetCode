using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0351_0400
{
    public class _390_EliminationGameAlg
    {
        public int LastRemaining(int n)
        {
            int first = 1;
            int last = n;
            if (first == last)
                return last;
            int step = 2;
            if (n % 2 > 0)
            {
                last--;
            }
            first++;
            bool isLeft = false;
            int count = n / 2;
            while (first < last)
            {
                if (isLeft)
                {
                    if (count % 2 > 0)
                    {
                        last -= step;
                    }
                    first += step;
                    isLeft = false;

                }
                else
                {
                    if (count % 2 > 0)
                    {
                        first += step;
                    }
                    last -= step;
                    isLeft = true;
                }
                count /= 2;
                if (count == 1)
                {
                    return last;
                }
                step += step;
               
            }

            return first;
        }
    }
}

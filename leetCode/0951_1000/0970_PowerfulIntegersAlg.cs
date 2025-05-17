using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0951_1000
{
    public class _0970_PowerfulIntegersAlg
    {
        public IList<int> PowerfulIntegers(int x, int y, int bound)
        {
            HashSet<int> set = new HashSet<int>();
            int val1 = 1;
            for (int i = 0; i < 21; i++)
            {
                int val2 = 1;

                for (int j = 0; j < 21; j++)
                {
                    int num = val1 + val2;
                    if (num <= bound)
                    {
                        set.Add(num);
                    }
                    else
                    {
                        break;
                    }
                    val2 *= y;
                }
                if (val1 > bound)
                    break;
                val1 *= x;
            }

            return set.ToList();
        }
    }
}

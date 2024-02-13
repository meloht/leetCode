using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0851_0900
{
    public class _860_LemonadeChangeAlg
    {
        public bool LemonadeChange(int[] bills)
        {
            int num5 = 0;
            int num10 = 0;
            for (int i = 0; i < bills.Length; i++)
            {
                if (bills[i] == 5)
                {
                    num5++;
                }
                else if (bills[i] == 10)
                {
                    if (num5 == 0)
                    {
                        return false;
                    }
                    else
                    {
                        num5--;
                    }
                    num10++;
                }
                else if (bills[i] == 20)
                {
                    if (num10 > 0)
                    {
                        num10--;
                        if (num5 < 1)
                        {
                            return false;
                        }
                        else
                        {
                            num5--;
                        }
                    }
                    else
                    {
                        if (num5 < 3)
                        {
                            return false;
                        }
                        num5 -= 3;
                    }
                }
            }

            return true;
        }
    }
}

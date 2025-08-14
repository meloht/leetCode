using leetCode._1_50;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1751_1800
{
    public class _1780_CheckIfNumberIsASumOfPowersOfThreeAlg
    {
        public bool CheckPowersOfThree(int n)
        {
            while (n > 0)
            {
                int num = n % 3;
                if (num == 0 || num == 1)
                {
                    n /= 3;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}

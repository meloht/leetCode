using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3201_3250
{
    public class _3232_FindIfDigitGameCanBeWonAlg
    {
        public bool CanAliceWin(int[] nums)
        {
            int total = nums.Sum();
            int num1 = nums.Where(p => p < 10).Sum();
            int num2 = nums.Where(p => p >= 10&&p<100).Sum();
            if (num1 > total - num1 || num2 > total - num2)
            {
                return true;
            }
            return false;
        }
    }
}

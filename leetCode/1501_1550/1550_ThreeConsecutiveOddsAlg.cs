using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1501_1550
{
    public class _1550_ThreeConsecutiveOddsAlg
    {
        public bool ThreeConsecutiveOdds(int[] arr)
        {
            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i - 1] % 2 == 1 && arr[i] % 2 == 1 && arr[i + 1] % 2 == 1)
                {
                    return true;
                }
            }

            return false;
        }
    }
}

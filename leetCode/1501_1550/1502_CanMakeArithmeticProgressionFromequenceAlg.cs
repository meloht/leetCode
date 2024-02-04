using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1501_1550
{
    public class _1502_CanMakeArithmeticProgressionFromequenceAlg
    {
        public bool CanMakeArithmeticProgression(int[] arr)
        {
            Array.Sort(arr);
            int diff = arr[1] - arr[0];
            for (int i = 2; i < arr.Length; i++)
            {
                int prev = arr[i - 1];
                int curr = arr[i];
                int df= curr - prev;
                if (df != diff)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

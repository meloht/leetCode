using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3051_3100
{
    public class _3074_AppleRedistributionIntoBoxesAlg
    {
        public int MinimumBoxes(int[] apple, int[] capacity)
        {
            Array.Sort(capacity, (a, b) => b - a);
            int sum = apple.Sum();
            int num = 0;

            for (int i = 0; i < capacity.Length; i++)
            {
                num += capacity[i];
                if (num >= sum)
                {
                    return i + 1;
                }
            }

            return 0;
        }
    }
}

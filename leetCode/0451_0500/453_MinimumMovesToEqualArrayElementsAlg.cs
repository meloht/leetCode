using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0451_0500
{
    public class _453_MinimumMovesToEqualArrayElementsAlg
    {
        public int MinMoves(int[] nums)
        {
            int min=nums.Min();
            int res = 0;
            foreach (var item in nums)
            {
                res += item - min;
            }

            return res;
        }
    }
}

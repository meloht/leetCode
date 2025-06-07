using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3151_3200
{
    public class _3192_MinimumOperationsToMakeBinaryArrayElementsEqualToOneIIAlg
    {
        public int MinOperations(int[] nums)
        {
            int operation = 0;
            foreach (int num in nums)
            {
                if (num == (operation % 2))
                {
                    operation++;
                }
            }
            return operation;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3151_3200
{
    public class _3151_SpecialArrayIAlg
    {
        public bool IsArraySpecial(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                int n1 = nums[i - 1];
                int n2 = nums[i];
                if (n1 % 2 == n2 % 2)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

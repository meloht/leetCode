using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1001_1050
{
    public class _1018_BinaryPrefixDivisibleBy5Alg
    {
        public IList<bool> PrefixesDivBy5(int[] nums)
        {
            List<bool> result = new List<bool>();
            int prefix = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                prefix = ((prefix << 1) + nums[i]) % 5;
                result.Add(prefix == 0);
            }

            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0651_0700
{
    public class _698_PartitionToKEqualSumSubsetsAlg
    {
        public bool CanPartitionKSubsets(int[] nums, int k)
        {
            long sum = 0;
            foreach (int i in nums) 
            {
                sum += i;
            }
            if (sum % k > 0) 
            {
                return false;
            }




            return false;
        }
    }
}

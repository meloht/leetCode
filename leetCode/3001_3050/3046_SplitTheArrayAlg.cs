using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3001_3050
{
    public class _3046_SplitTheArrayAlg
    {
        public bool IsPossibleToSplit(int[] nums)
        {
            int[] arr = new int[101];
            foreach (var item in nums)
            {
                arr[item]++;
                if (arr[item] > 2)
                {
                    return false;
                }
            }
           
            return true;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1451_1500
{
    public class _1470_ShuffleTheArrayAlg
    {
        public int[] Shuffle(int[] nums, int n)
        {
            List<int> list = new List<int>(2*n);
            for (int i = 0, j = n; i < n; i++, j++)
            {
                list.Add(nums[i]);
                list.Add(nums[j]);
               
            }

            return list.ToArray();
        }
    }
}

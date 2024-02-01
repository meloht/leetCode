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
            int[] arr = new int[2 * n];

            for (int i = 0, j = n, k = 0; i < n; i++, j++, k++)
            {
                arr[k] = nums[i];
                k++;
                arr[k] = nums[j];
            }

            return arr;
        }
    }
}

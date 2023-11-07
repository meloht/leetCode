using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1_50
{
    public class _41_FirstMissingPositiveAlg
    {
        public int FirstMissingPositive(int[] nums)
        {
            int numMin = int.MaxValue;
            int count = 0;
            foreach (int i in nums)
            {
                if (i > 0)
                {
                    count++;
                    if (i < numMin)
                    {
                        numMin = i;
                    }
                }
            }
            if (numMin > 1)
            {
                return 1;
            }
            int target = 0;
            int[] arr = new int[count];
            for (int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];
                if (num >= numMin)
                {
                    int index = num - numMin;
                    if (index < arr.Length)
                    {
                        arr[index] = num;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                int num = arr[i];
                if (i != arr.Length - 1)
                {
                    if (arr[i + 1] == 0)
                    {
                        target = num + 1;
                        break;
                    }
                }
                else
                {
                    target = num + 1;
                }
            }

            return target;
        }
    }
}

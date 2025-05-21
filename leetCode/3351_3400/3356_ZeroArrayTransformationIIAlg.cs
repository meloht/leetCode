using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3351_3400
{
    public class _3356_ZeroArrayTransformationIIAlg
    {
        public int MinZeroArray(int[] nums, int[][] queries)
        {
            int n = nums.Length;
            int[] deltaArray = new int[n + 1];
            int operations = 0;
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                int num = nums[i];
                operations += deltaArray[i];
                while (k < queries.Length && operations < num)
                {
                    int left = queries[k][0];
                    int right = queries[k][1];
                    int value = queries[k][2];
                    deltaArray[left] += value;
                    deltaArray[right + 1] -= value;
                    if (left <= i && i <= right)
                    {
                        operations += value;
                    }
                    k++;
                }
                if (operations < num)
                {
                    return -1;
                }
            }
            return k;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0151_0200
{
    public class _167_TwoSumIIInputArrayIsSortedAlg
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int len = numbers.Length - 1;
            for (int i = 0; i <= len; i++)
            {
                int num1 = target - numbers[i];
                int index = BinarySearch(i + 1, len, numbers, num1);
                if (index != -1)
                {
                    int[] arr = { i + 1, index + 1 };
                    return arr;
                }
            }
            return null;
        }

        private int BinarySearch(int left, int right, int[] numbers, int target)
        {

            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (numbers[mid] == target)
                {
                    return mid;
                }
                else if (numbers[mid] > target)
                {
                    right = mid - 1;
                   
                }
                else
                {
                    left = mid + 1;
                }
            }
            return -1;
        }
    }
}

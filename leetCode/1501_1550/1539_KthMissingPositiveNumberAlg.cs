using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1501_1550
{
    public class _1539_KthMissingPositiveNumberAlg
    {
        public int FindKthPositive1(int[] arr, int k)
        {
            HashSet<int> set = new HashSet<int>(arr);
            int max = arr.Max() + k;
            int count = 0;
            for (int i = 1; i <= max; i++)
            {
                if (set.Add(i))
                {
                    count++;
                }
                if (count == k)
                {
                    return i;
                }
            }
            return -1;
        }

        public int FindKthPositive2(int[] arr, int k)
        {
            int index = 0;
            int missNum = -1;
            int current = 1;
            for (int i = 0; i <k; current++)
            {
                if (current == arr[index])
                {
                    index = (index + 1 < arr.Length) ? index + 1 : index;
                }
                else
                {
                    i++;
                    missNum = current;
                }
               
            }
            return missNum;
        }

        public int FindKthPositive(int[] arr, int k)
        {
            if (arr[0] > k)
            {
                return k;
            }

            int l = 0, r = arr.Length;
            while (l < r)
            {
                int mid = (l + r) >> 1;
                int x = mid < arr.Length ? arr[mid] : int.MaxValue;
                if (x - mid - 1 >= k)
                {
                    r = mid;
                }
                else
                {
                    l = mid + 1;
                }
            }

            return k - (arr[l - 1] - (l - 1) - 1) + arr[l - 1];
        }

    }
}

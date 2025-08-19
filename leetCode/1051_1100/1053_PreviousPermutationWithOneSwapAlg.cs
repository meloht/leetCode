using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1051_1100
{
    public class _1053_PreviousPermutationWithOneSwapAlg
    {
        public int[] PrevPermOpt1(int[] arr)
        {

            int n = arr.Length;
            for (int i = n - 2; i >= 0; i--)
            {
                if (arr[i] > arr[i + 1])
                {
                    int j = n - 1;
                    while (arr[j] >= arr[i] || arr[j] == arr[j - 1])
                    {
                        j--;
                    }
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    break;
                }
            }
            return arr;

        }
    }
}

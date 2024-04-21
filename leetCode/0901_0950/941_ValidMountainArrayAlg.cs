using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0901_0950
{

    public class _941_ValidMountainArrayAlg
    {
        public bool ValidMountainArray(int[] arr)
        {
            if (arr.Length < 3)
                return false;

            int mid = 0;
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    mid = i;
                }
            }
            if (mid == 0 || mid == arr.Length-1)
                return false;
            for (int i = 1; i < mid; i++)
            {
                if (arr[i - 1] >= arr[i])
                    return false;
            }
            for (int i = mid + 1; i < arr.Length; i++)
            {
                if (arr[i - 1] <= arr[i])
                    return false;
            }
            return true;
        }
    }
}

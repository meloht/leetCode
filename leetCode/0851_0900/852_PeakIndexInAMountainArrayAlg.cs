using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0851_0900
{
    public class _852_PeakIndexInAMountainArrayAlg
    {
        public int PeakIndexInMountainArray1(int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;
            while (left <= right)
            {
                int mid = (right - left) / 2 + left;
                if (arr[mid] > arr[mid - 1] && arr[mid] > arr[mid + 1])
                {
                    return mid;
                }
                else if (arr[mid] < arr[mid + 1])
                {
                    left = mid;
                }
                else if (arr[mid] < arr[mid - 1])
                {
                    right = mid;
                }
            }
            return -1;
        }

        public int PeakIndexInMountainArray2(int[] arr)
        {
            int left = 1;
            int right = arr.Length - 1;
            while (left < right)
            {
                int mid = (right - left + 1) / 2 + left;
                if (arr[mid] > arr[mid - 1])
                {
                    left = mid;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return right;
        }

        public int PeakIndexInMountainArray(int[] arr)
        {
            int n = arr.Length;
            int left = 1, right = n - 2, ans = 0;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (arr[mid] > arr[mid + 1])
                {
                    ans = mid;
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return ans;
        }

    }
}

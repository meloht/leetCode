using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1_50
{
    internal class FindMedianSortedArraysAlg
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            List<int> arr1 = new List<int>();
            if (nums1 != null && nums1.Length > 0)
            {
                arr1.AddRange(nums1);
            }
            List<int> arr2 = new List<int>();
            if (nums2 != null && nums2.Length > 0)
            {
                arr2.AddRange(nums2);
            }
            List<int> list = new List<int>();

            int len = nums1.Length + nums2.Length;

            for (int i = 0; i < len; i++)
            {
                int? n1 = GetMin(arr1);
                int? n2 = GetMin(arr2);
                if (n1 != null && n2 != null)
                {
                    if (n1 > n2)
                    {
                        list.Add(n2.Value);
                        arr2.RemoveAt(0);
                    }
                    else
                    {
                        list.Add(n1.Value);
                        arr1.RemoveAt(0);
                    }

                }
                else
                {
                    if (n1 != null)
                    {
                        list.Add(n1.Value);
                        arr1.RemoveAt(0);
                    }
                    if (n2 != null)
                    {
                        list.Add(n2.Value);
                        arr2.RemoveAt(0);
                    }
                }
            }
            if (list.Count % 2 == 0)
            {
                int nn = list.Count / 2;
                int mm = nn - 1;

                float b = list[nn];
                float a = list[mm];
                float num = (a + b) / 2;
                return num;
            }
            else
            {
                int mid = (list.Count - 1) / 2;
                return list[mid];
            }
        }
        private static int? GetMin(List<int> arr)
        {
            if (arr.Count > 0)
            {
                int num = arr[0];

                return num;
            }
            return null;

        }
    }
}

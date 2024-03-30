using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0451_0500
{
    public class _496_NextGreaterElementIAlg
    {
        public int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums2.Length; i++)
            {
                dict.Add(nums2[i], i);
            }

            int[] right = new int[nums2.Length];
            right[nums2.Length - 1] = nums2[nums2.Length - 1];
            Stack<int> stack = new Stack<int>();
            for (int i = nums2.Length - 1; i >= 0; i--)
            {
                while (stack.Count > 0 && stack.Peek() < nums2[i])
                {
                    stack.Pop();
                }

                if (stack.Count >0)
                {
                    right[i] = stack.Peek();
                   
                }
                else
                {
                    right[i] = -1;
                }
                stack.Push(nums2[i]);
              
            }

            int[] arr = new int[nums1.Length];
            for (int i = 0; i < nums1.Length; i++)
            {
                if (dict.ContainsKey(nums1[i]))
                {
                    int index = dict[nums1[i]];
                    arr[i] = right[index];
                }
            }

            return arr;
        }
    }
}

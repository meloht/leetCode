using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0201_0250
{
    public class _215_KthLargestElementInAnArrayAlg
    {
        public int FindKthLargest1(int[] nums, int k)
        {
            PriorityQueue<int, int> queue = new PriorityQueue<int, int>();
            foreach (int i in nums)
            {
                queue.Enqueue(i, i);
            }

            int len = nums.Length - k;
            for (int i = 1; i <= len; i++)
            {
                queue.Dequeue();

            }
            return queue.Peek();
        }

        public int FindKthLargest2(int[] nums, int k)
        {
            Array.Sort(nums);
            return nums[nums.Length - k];
        }


        //用改进的快速排序，根据快拍后的子数组长度确定目标数在哪个数组中，再对哪个数组进行快速排序
        public int FindKthLargest(int[] nums, int k)
        {
            int len = nums.Length;
            return TopK(nums, 0, len - 1, len - k + 1);
        }
        public int TopK(int[] nums, int low, int high, int k)
        {
            int mid = QuickSort_Random(nums, low, high);
            if (mid == k - 1) return nums[mid];
            else if (mid < k - 1) return TopK(nums, mid + 1, high, k);
            else return TopK(nums, low, mid - 1, k);
        }
        public static int QuickSort_Random(int[] array, int low, int high)
        {
            Random rd = new Random();
            int i = low;
            int j = high;

            if (low < high)
            {
                int rdIdx = rd.Next(low, high);
                int temp1 = array[i];
                array[i] = array[rdIdx];
                array[rdIdx] = temp1;

                int temp = array[i];
                while (i < j)
                {
                    while (j > i && array[j] > temp) j--;
                    if (j > i)
                    {
                        array[i] = array[j];
                        i++;
                    }
                    while (i < j && array[i] < temp) i++;
                    if (i < j)
                    {
                        array[j] = array[i];
                        j--;
                    }
                }
                array[i] = temp;
                return i;
            }
            return low;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0651_0700
{
    public class _658_FindKClosestElementsAlg
    {
        public IList<int> FindClosestElements1(int[] arr, int k, int x)
        {
            PriorityQueue<int, Tuple<int, int>> queue = new PriorityQueue<int, Tuple<int, int>>(new myComaraer());

            foreach (var item in arr)
            {
                queue.Enqueue(item, new Tuple<int, int>(item, x));

            }
            List<int> result = new List<int>();
            for (int i = 0; i < k; i++)
            {
                if (queue.Count > 0)
                {
                    result.Add(queue.Dequeue());
                }
            }
            result.Sort();
            return result;
        }

        private class myComaraer : IComparer<Tuple<int, int>>
        {
            public int Compare(Tuple<int, int>? x, Tuple<int, int>? y)
            {
                if (x == null && y == null)
                    return 0;
                if (x == null || y == null)
                    return 1;

                int num1 = Math.Abs(x.Item1 - x.Item2);
                int num2 = Math.Abs(y.Item1 - y.Item2);
                if (num1 == num2)
                {
                    return x.Item1.CompareTo(y.Item1);
                }
                return num1.CompareTo(num2);


            }
        }

        public IList<int> FindClosestElements(int[] arr, int k, int x)
        {
            int right = BinarySearch(arr, x);
            int left = right - 1;
            while (k-- > 0)
            {
                if (left < 0)
                {
                    right++;
                }
                else if (right >= arr.Length)
                {
                    left--;
                }
                else if (x - arr[left] <= arr[right] - x)
                {
                    left--;
                }
                else
                {
                    right++;
                }
            }
            IList<int> ans = new List<int>();
            for (int i = left + 1; i < right; i++)
            {
                ans.Add(arr[i]);
            }
            return ans;
        }

        public int BinarySearch(int[] arr, int x)
        {
            int low = 0, high = arr.Length - 1;
            while (low < high)
            {
                int mid = low + (high - low) / 2;
                if (arr[mid] >= x)
                {
                    high = mid;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return low;
        }
    }



}

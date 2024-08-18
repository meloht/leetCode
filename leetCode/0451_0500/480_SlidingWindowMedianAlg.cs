using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0451_0500
{
    public class _480_SlidingWindowMedianAlg
    {
        public double[] MedianSlidingWindow(int[] nums, int k)
        {
            double[] result = new double[nums.Length - k + 1];

            SortedList<int, int> sortList = new SortedList<int, int>();

            int idx = 0;
            int left = k / 2;
            int right = k - left;
            for (int i = 0, j = 0; i < nums.Length; i++)
            {
                sortList.Add(nums[i], nums[i]);

                if (sortList.Count > k)
                {
                    sortList.Remove(nums[j++]);
                }
                if (sortList.Count == k)
                {
                    if (left == right)
                    {
                        double ans = ((double)sortList[left - 1] + (double)sortList[left]) / 2;
                        result[idx++] = ans;
                    }
                    else
                    {
                        result[idx++] = (double)sortList.GetKeyAtIndex(left);
                    }
                }
            }

            return result;
        }

        PriorityQueue<int, int> queueLeft = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));

        PriorityQueue<int, int> queueRight = new PriorityQueue<int, int>();
        Dictionary<int, int> dict = new Dictionary<int, int>();
        private int leftCount;
        private int rightCount;

        public double[] MedianSlidingWindow2(int[] nums, int k)
        {
            double[] result = new double[nums.Length - k + 1];

            int idx = 0;
            for (int i = 0; i < k; i++)
            {
                Insert(nums[i]);
            }
            result[idx++] = GetMid(k);
            for (int i = k; i < nums.Length; i++)
            {
                Insert(nums[i]);
                Delete(nums[i - k]);
                result[idx++] = GetMid(k);
            }

            return result;
        }

        private void Insert(int num)
        {
            if (queueLeft.Count == 0 || num < queueLeft.Peek())
            {
                queueLeft.Enqueue(num, num);
                leftCount++;


            }
            else
            {
                queueRight.Enqueue(num, num);
                rightCount++;
               
            }
            Balance();

        }
        private double GetMid(int k)
        {
            if ((k & 1) == 1)
            {
                return queueLeft.Peek();
              
            }
            double ans = ((double)queueLeft.Peek() + (double)queueRight.Peek()) / 2;
            return ans;
        }
        private void Delete(int num)
        {
            if (dict.ContainsKey(num))
            {
                dict[num]++;
            }
            else
            {
                dict.Add(num, 1);
            }
            if (num <= queueLeft.Peek())
            {
                leftCount--;
                if (num == queueLeft.Peek())
                {
                    DeleteQueue(queueLeft);
                }
               
            }
            else
            {
                rightCount--;
                if (num == queueRight.Peek())
                {
                    DeleteQueue(queueRight);
                }
               
            }
            Balance();
        }

        private void Balance()
        {
            if (leftCount > rightCount + 1)
            {
                var item = queueLeft.Dequeue();
            
                queueRight.Enqueue(item, item);
                leftCount--;
                rightCount++;
                DeleteQueue(queueLeft);
            }
            else if (leftCount < rightCount)
            {
                var item = queueRight.Dequeue();
                queueLeft.Enqueue(item, item);
                leftCount++;
                rightCount--;
                DeleteQueue(queueRight);
            }

        }

        private void DeleteQueue(PriorityQueue<int, int> queue) 
        {
            while (queue.Count > 0 && dict.ContainsKey(queue.Peek()) && dict[queue.Peek()] > 0)
            {
               var num= queue.Dequeue();
                dict[num]--;
                if (dict[num] == 0)
                {
                    dict.Remove(num);
                }
            }
        }


    }
}

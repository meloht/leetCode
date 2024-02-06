using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0351_0400
{
    public class _373_FindKPairsWithSmallestSumsAlg
    {
        public IList<IList<int>> KSmallestPairs1(int[] nums1, int[] nums2, int k)
        {
            PriorityQueue<int[], int> queue = new PriorityQueue<int[], int>(Comparer<int>.Create((x, y) => -x.CompareTo(y)));
            int max = 0;
            for (int i = 0; i < nums1.Length && i < k; i++)
            {
                if (queue.Count >= k)
                {
                    int num1 = nums1[i] + nums2[0];
                    if (max <= num1)
                    {
                        break;
                    }
                }

                for (int j = 0; j < nums2.Length && j < k; j++)
                {
                    int num = nums1[i] + nums2[j];
                    if (queue.Count >= k)
                    {
                        if (max <= num)
                        {
                            break;
                        }
                    }

                    queue.Enqueue(new int[] { nums1[i], nums2[j] }, num);
                    ResetQueue(queue, k);
                    if (queue.Count >= k)
                    {
                        var arr = queue.Peek();
                        max = arr[0] + arr[1];
                    }

                }

            }
            IList<IList<int>> res = new List<IList<int>>();

            int n = 0;
            while (n < k && queue.Count > 0)
            {
                res.Add(queue.Dequeue());
                n++;
            }
            return res;
        }

        private void ResetQueue(PriorityQueue<int[], int> queue, int k)
        {
            while (queue.Count > k)
            {
                queue.Dequeue();
            }
        }

        public IList<IList<int>> KSmallestPairs(int[] nums1, int[] nums2, int k)
        {
            var queue = new PriorityQueue<(int, int), int>();
            int len = Math.Min(k, nums1.Length);
            for (var i = 0; i < len; i++)
            {
                queue.Enqueue((i, 0), nums1[i] + nums2[0]);
            }
            var list = new List<IList<int>>();
            for (var i = 0; i < k && queue.Count > 0; i++)
            {
                var pair = queue.Dequeue();
                list.Add(new int[] { nums1[pair.Item1], nums2[pair.Item2] });
                if (pair.Item2 < nums2.Length - 1)
                {
                    queue.Enqueue((pair.Item1, pair.Item2 + 1), nums1[pair.Item1] + nums2[pair.Item2 + 1]);
                }
            }
            return list;
        }
    }
}

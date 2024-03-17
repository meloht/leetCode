using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0351_0400
{
    public class _354_RussianDollEnvelopesAlg
    {
        public int MaxEnvelopes(int[][] envelopes)
        {
            Array.Sort(envelopes, MyCompare);

            List<int> list = new List<int>();
            list.Add(envelopes[0][1]);
            for (int i = 1; i < envelopes.Length; i++)
            {
                int num = envelopes[i][1];
                if (num > list[list.Count - 1])
                {
                    list.Add(num);
                }
                else
                {
                    int index = BinarySearch(list, num);
                    list[index] = num;
                }
            }
            return list.Count;
        }

        private int BinarySearch(List<int> list, int t)
        {
            int left = 0;
            int right = list.Count - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (list[mid] < t)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return left;
        }
        private int MyCompare(int[] x, int[] y)
        {
            if (x[0] != y[0])
            {
                return x[0].CompareTo(y[0]);
            }
            else
            {
                return y[1].CompareTo(x[1]);
            }

        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2051_2100
{
    public class _2080_RangeFrequencyQueriesAlg
    {
        public class RangeFreqQuery
        {
            Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
            public RangeFreqQuery(int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (dict.ContainsKey(arr[i]))
                    {
                        dict[arr[i]].Add(i);
                    }
                    else
                    {
                        dict.Add(arr[i], [i]);
                    }
                }

                foreach (var item in dict)
                {
                    item.Value.Sort();
                }
            }

            public int Query(int left, int right, int value)
            {
                if (dict.ContainsKey(value))
                {
                    var list = dict[value];
                    int leftIndex = LowerBound(list, left);
                    int rightIndex = UpperBound(list, right);
                    return rightIndex - leftIndex ;
                }
                else
                {
                    return 0;
                }
            }
            private int LowerBound(List<int> pos, int target)
            {
                int low = 0, high = pos.Count - 1;
                while (low <= high)
                {
                    int mid = low + (high - low) / 2;
                    if (pos[mid] < target)
                    {
                        low = mid + 1;
                    }
                    else
                    {
                        high = mid - 1;
                    }
                }
                return low;
            }

            private int UpperBound(List<int> pos, int target)
            {
                int low = 0, high = pos.Count - 1;
                while (low <= high)
                {
                    int mid = low + (high - low) / 2;
                    if (pos[mid] <= target)
                    {
                        low = mid + 1;
                    }
                    else
                    {
                        high = mid - 1;
                    }
                }
                return low;
            }


        }
    }
}

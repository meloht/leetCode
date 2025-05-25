using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0951_1000
{
    public class _0969_PancakeSortingAlg
    {
        public IList<int> PancakeSort(int[] arr)
        {
            List<int> list = new List<int>();

            int last = arr.Length - 1;
            int max = arr.Length;
            while (last > 0)
            {
                if (arr[last] != max)
                {
                    int idx = Array.IndexOf(arr, max);

                    if (idx > 0)
                    {
                        list.Add(idx + 1);
                        Array.Reverse(arr, 0, idx + 1);
                    }

                    Array.Reverse(arr, 0, last + 1);
                    list.Add(last + 1);
                }

                last--;
                max--;

            }

            return list;
        }



    }
}

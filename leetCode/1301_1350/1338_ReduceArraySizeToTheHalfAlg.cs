using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1301_1350
{
    public class _1338_ReduceArraySizeToTheHalfAlg
    {
        public int MinSetSize(int[] arr)
        {
            int t = arr.Length / 2;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (var item in arr)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item]++;
                }
                else
                {
                    dict.Add(item, 1);
                }
            }

            int[] numCnt = dict.Values.ToArray();
            

            Array.Sort(numCnt, (x, y) => y.CompareTo(x));

            int ans = 0;

            for (int i = 0; i < numCnt.Length; i++)
            {
                ans += numCnt[i];

                if (ans >= t)
                {
                    return i + 1;
                }
            }


            return numCnt.Length;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0251_0300
{
    public class _274_HIndexAlg
    {
        public int HIndex1(int[] citations)
        {
            int count = citations.Length;
            Array.Sort(citations);
            int max = 0;
            for (int i = 0; i < citations.Length; i++)
            {
                int n = count - i;
                if (n < max)
                    return max;
                int num = Math.Min(n, citations[i]);
                max = Math.Max(max, num);

            }
            return max;
        }

        public int HIndex(int[] citations)
        {
            int count = citations.Length;
            int[] countArr = new int[count + 1];
            for (int i = 0; i < count; i++)
            {
                if (citations[i] >= count)
                {
                    countArr[count]++;
                }
                else
                {
                    countArr[citations[i]]++;
                }
            }
            int num = 0;
            for (int i = count; i >= 0; i--)
            {
                num += countArr[i];
                if (num >= i)
                    return i;
            }

            return 0;
        }
    }
}

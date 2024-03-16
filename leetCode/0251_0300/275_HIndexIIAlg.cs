using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0251_0300
{
    public class _275_HIndexIIAlg
    {
        public int HIndex(int[] citations)
        {
            if (citations.Length == 0)
                return 0;
            if (citations.Length == 1)
                return Math.Min(1, citations[0]);
            if (citations[0] >= citations.Length)
                return citations.Length;
            int left = 0;
            int right = citations.Length - 1;

            int ans = 0;
            while (left <= right)
            {
                int mid = (right - left) / 2 + left;
                int midVal = citations[mid];
                int count = citations.Length - mid;

                if (midVal < count)
                {
                    left = mid + 1;
                }
                else
                {
                    ans = count;
                    right = mid - 1;
                }

            }
            return ans;
        }
    }
}

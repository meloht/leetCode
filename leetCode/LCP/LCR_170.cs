using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode.LCP
{
    public class LCR_170
    {
        int res = 0;
        public int ReversePairs(int[] record)
        {
            int[] b = new int[record.Length];

            Merge(0, record.Length - 1, record, b);
            return res;
        }

        private void Merge(int left, int right, int[] a, int[] b)
        {
            if (left >= right)
                return;
            int mid = left + (right - left) / 2;
            Merge(left, mid, a, b);
            Merge(mid + 1, right, a, b);

            int i = left;
            int j = mid + 1;
            int k = left;
            while (i <= mid && j <= right)
            {
                if (a[i] <= a[j])
                {
                    b[k++] = a[i++];
                }
                else
                {
                    b[k++] = a[j++];
                    res += mid - i + 1;
                }
            }
            while (i <= mid)
            {
                b[k++] = a[i++];
            }
            while (j <= right)
            {
                b[k++] = a[j++];
            }

            for (i = left; i <= right; i++)
            {
                a[i] = b[i];
            }
        }
    }
}

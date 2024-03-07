using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0351_0400
{
    public class _374_GuessNumberHigherOrLowerAlg
    {
        public int Pick { get; set; }
        public int GuessNumber(int n)
        {
            int left = 1;
            int right = n;
            while (left <= right) 
            {
                int mid = left + (right - left) / 2;
                int res = guess(mid);
                if (res == -1)
                {
                    right = mid - 1;
                }
                else if (res == 1)
                {
                    left = mid + 1;
                }
                else
                {
                    return mid;
                }
            }
            return 0;
        }

        private int guess(int num)
        {
            return Pick.CompareTo(num);
        }
    }
}

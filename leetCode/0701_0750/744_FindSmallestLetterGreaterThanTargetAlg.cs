using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0701_0750
{
    public class _744_FindSmallestLetterGreaterThanTargetAlg
    {
        public char NextGreatestLetter(char[] letters, char target)
        {
            if (target >= letters[letters.Length - 1])
                return letters[0];

            if (target < letters[0])
                return letters[0];
            int left = 0;
            int right = letters.Length - 1;

            while (left < right)
            {
                int mid = (right - left) / 2 + left;
                char c = letters[mid];
                if (c <= target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }

            return letters[left];
        }
    }
}

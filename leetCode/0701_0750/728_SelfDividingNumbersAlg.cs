using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0701_0750
{
    public class _728_SelfDividingNumbersAlg
    {
        public IList<int> SelfDividingNumbers(int left, int right)
        {
            List<int> numbers = new List<int>();
            for (int i = left; i <= right; i++)
            {
                bool bl = GetNum(i);
                if (bl)
                {
                    numbers.Add(i);
                }
            }
            return numbers;
        }

        private bool GetNum(int num)
        {
            if (num == 0)
            {
                return false;
            }
            int n = num;
            while (n > 0)
            {
                int nn = n % 10;
                if (nn == 0 || num % nn != 0)
                    return false;
                n = n / 10;
            }

            return true;
        }
    }
}

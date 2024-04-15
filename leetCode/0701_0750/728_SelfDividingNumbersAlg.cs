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
                var list = GetNum(i);
                bool bl = true;
                foreach (var item in list)
                {
                    if (item==0||i % item != 0)
                    {
                        bl = false;
                        break;
                    }
                }
                if (bl)
                {
                    numbers.Add(i);
                }
            }
            return numbers;
        }

        private List<int> GetNum(int num)
        {
            List<int> list = new List<int>();
            if (num == 0)
            {
                list.Add(0);
                return list;
            }
            int n = num;
            while (n > 0)
            {
                list.Add(n % 10);
                n = n / 10;
            }
           
            return list;
        }
    }
}

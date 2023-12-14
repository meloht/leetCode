using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._51_100
{
    public class _89_GrayCodeAlg
    {
        public IList<int> GrayCode(int n)
        {

            if (n == 1)
            {
                return new List<int> { 0, 1 };
            }
            else
            {
                IList<int> prevList = GrayCode(n - 1);
                List<int> resultList = new List<int>(prevList);

                int numToAdd = 1 << (n - 1);

                for (int i = prevList.Count - 1; i >= 0; i--)
                {
                    resultList.Add(numToAdd + prevList[i]);
                }

                return resultList;
            }
        }
    }
}

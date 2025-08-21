using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1051_1100
{
    public class _1054_DistantBarcodesAlg
    {
        public int[] RearrangeBarcodes(int[] barcodes)
        {
            int n = barcodes.Length;
            if (n < 2)
            {
                return barcodes;
            }


            int[] ans = new int[n];

            Dictionary<int, int> dict = new Dictionary<int, int>();
        
            foreach (int item in barcodes)
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

            int evenIdx = 0;
            int oddIdx = 1;
            int half = n / 2;
            foreach (var item in dict)
            {
                int x = item.Key;
                int count = item.Value;
                while (count > 0 && count <= half && oddIdx < n)
                {
                    ans[oddIdx] = x;
                    count--;
                    oddIdx += 2;
                }
                while (count > 0) 
                {
                    ans[evenIdx] = x;
                    count--;
                    evenIdx += 2;
                }
            }

            return ans;
        }
    }
}

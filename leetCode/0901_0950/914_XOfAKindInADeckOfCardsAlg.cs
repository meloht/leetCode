using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0901_0950
{
    public class _914_XOfAKindInADeckOfCardsAlg
    {
        public bool HasGroupsSizeX(int[] deck)
        {

            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (var item in deck)
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


            int num = dict.Values.Min();
            if (num < 2)
            {
                return false;
            }
            HashSet<int> set = new HashSet<int>();

            foreach (var item in dict.Values)
            {
                if (item < 2)
                {
                    return false;
                }
                set.Add(item);

            }
            if (set.Count == 1)
                return true;
            var arr = set.ToArray();
            int ans = GCD(arr[0], arr[1]);
            if (ans < 2)
                return false;
            for (int i = 2; i < arr.Length; i++)
            {
                ans = GCD(ans, arr[i]);
                if (ans < 2)
                    return false;
            }

            return true;
        }
        public static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int tmp = a % b;
                a = b;
                b = tmp;
            }
            return a;
        }




    }
}

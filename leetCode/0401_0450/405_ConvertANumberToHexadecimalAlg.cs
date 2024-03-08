using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0401_0450
{
    public class _405_ConvertANumberToHexadecimalAlg
    {
        public string ToHex(int num)
        {
            if (num == 0)
                return "0";
            char[] map = ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f'];
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for (int i = 0; i < map.Length; i++)
            {
                dict.Add(map[i], i);
            }
            List<char> list = new List<char>();
            long n = Math.Abs((long)num);
            while (n > 0)
            {
                long nn = n % 16;
                list.Add(map[nn]);
                n = n / 16;
            }
            if (num < 0)
            {
                List<char> ls = new List<char>();
                foreach (var item in list)
                {
                    int nn = dict[item];
                    char f = map[15 - nn];
                    ls.Add(f);
                }
                for (int i = ls.Count; i < 8; i++)
                {
                    ls.Add('f');
                }

                int index = 0;
                while (true)
                {
                    if (index > ls.Count)
                    {
                        break;
                    }

                    int nn = dict[ls[index]] + 1;
                    if (nn < 16)
                    {
                        ls[index] = map[nn];
                        break;
                    }
                    else
                    {
                        ls[index] = '0';
                    }
                    index++;
                }

                list = ls;
            }
            list.Reverse();
            return new string(list.ToArray());
        }
    }
}

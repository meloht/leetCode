using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2751_2800
{
    public class _2785_SortVowelsInAStringAlg
    {
        public string SortVowels(string s)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in s)
            {
                char c = char.ToLower(item);
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    sb.Append(item);
                }


            }
            char[] arr = sb.ToString().ToCharArray();
            Array.Sort(arr);
            char[] res = s.ToCharArray();
            for (int i = 0, j = 0; i < s.Length; i++)
            {
                char c = char.ToLower(s[i]);
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    res[i] = arr[j++];
                }
            }
            return new string(s);
        }
        public string SortVowels1(string s)
        {
            char[] arr = new char[10];

            foreach (var item in s)
            {
                if (item == 'A')
                {
                    arr[0]++;
                }
                else if (item == 'E')
                {
                    arr[1]++;
                }
                else if (item == 'I')
                {
                    arr[2]++;
                }
                else if (item == 'O')
                {
                    arr[3]++;
                }
                else if (item == 'U')
                {
                    arr[4]++;
                }
                else if (item == 'a')
                {
                    arr[5]++;
                }
                else if (item == 'e')
                {
                    arr[6]++;
                }
                else if (item == 'i')
                {
                    arr[7]++;
                }
                else if (item == 'o')
                {
                    arr[8]++;
                }
                else if (item == 'u')
                {
                    arr[9]++;
                }
            }

            char[] res = s.ToCharArray();
            for (int i = 0, j = 0; i < s.Length; i++)
            {
                if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u'
                    || s[i] == 'A' || s[i] == 'E' || s[i] == 'I' || s[i] == 'O' || s[i] == 'U')
                {
                    while (j < 10 && arr[j] <= 0)
                    {
                        j++;
                    }
                    arr[j]--;
                    if (j == 0)
                    {
                        res[i] = 'A';
                    }
                    else if (j == 1)
                    {
                        res[i] = 'E';
                    }
                    else if (j == 2)
                    {
                        res[i] = 'I';
                    }
                    else if (j == 3)
                    {
                        res[i] = 'O';
                    }
                    else if (j == 4)
                    {
                        res[i] = 'U';
                    }
                    else if (j == 5)
                    {
                        res[i] = 'a';
                    }
                    else if (j == 6)
                    {
                        res[i] = 'e';
                    }
                    else if (j == 7)
                    {
                        res[i] = 'i';
                    }
                    else if (j == 8)
                    {
                        res[i] = 'o';
                    }
                    else if (j == 9)
                    {
                        res[i] = 'u';
                    }
                }
            }
            return new string(res);
        }
    }
}

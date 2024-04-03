using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0451_0500
{
    public class _500_KeyboardRowAlg
    {
        public string[] FindWords(string[] words)
        {
            string s1 = "qwertyuiop";
            string s2 = "asdfghjkl";
            string s3 = "zxcvbnm";
            int[] arr1 = GetArr(s1);
            int[] arr2 = GetArr(s2);
            int[] arr3 = GetArr(s3);

            List<string> list = new List<string>();
            foreach (var item in words)
            {
                int[] arr = null;
                int a = char.ToLower(item[0]) - 'a';
                if (arr1[a] == 1)
                {
                    arr = arr1;
                }
                else if (arr2[a] == 1)
                {
                    arr = arr2;
                }
                else if (arr3[a] == 1)
                {
                    arr = arr3;
                }
                if (arr == null)
                {
                    continue;
                }
                bool bl = true;
                for (int i = 0; i < item.Length; i++)
                {
                    int b = char.ToLower(item[i]) - 'a';
                    if (arr[b] == 0)
                    {
                        bl = false;
                        break;
                    }
                }
                if (bl)
                {
                    list.Add(item);
                }
            }

            return list.ToArray();
        }
        private int[] GetArr(string s)
        {
            int[] arr = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                int a = s[i] - 'a';
                arr[a] = 1;
            }
            return arr;
        }
    }
}

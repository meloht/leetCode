using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0551_0600
{
    public class _557_ReverseWordsInAStringIIIAlg
    {
        public string ReverseWords1(string s)
        {
            s = " " + s;
            char[] arr = s.ToCharArray();
            int i = 0;
            int j = 0;
            while (i < s.Length)
            {
                if (arr[i] == ' ')
                {
                    j = i + 1;
                    while (j < s.Length)
                    {
                        if (arr[j] == ' ')
                            break;

                        j++;
                    }
                   
                    Reverse(arr, i + 1, j - 1);
                    i = j;
                    continue;
                }
                i++;
            }
            return new string(arr).Trim();
        }
        public void Reverse(char[] arr, int left, int right)
        {
            while (left < right)
            {
                char temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
                left++;
                right--;
            }
        }

        public string ReverseWords(string s)
        {
            StringBuilder ret = new StringBuilder();
            int length = s.Length;
            int i = 0;
            while (i < length)
            {
                int start = i;
                while (i < length && s[i] != ' ')
                {
                    i++;
                }
                for (int p = start; p < i; p++)
                {
                    ret.Append(s[start + i - 1 - p]);
                }
                while (i < length && s[i] == ' ')
                {
                    i++;
                    ret.Append(' ');
                }
            }
            return ret.ToString();
        }

    }
}

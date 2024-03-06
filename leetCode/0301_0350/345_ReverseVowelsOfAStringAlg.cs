using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0301_0350
{
    public class _345_ReverseVowelsOfAStringAlg
    {

        public string ReverseVowels(string s)
        {
            char[] arr = s.ToCharArray();

            int i = 0;
            int j = s.Length - 1;
            while (i <= j)
            {

                while (i <= j && arr[i] != 'a' && arr[i] != 'A'
                       && arr[i] != 'e' && arr[i] != 'E'
                        && arr[i] != 'i' && arr[i] != 'I'
                         && arr[i] != 'o' && arr[i] != 'O'
                         && arr[i] != 'u' && arr[i] != 'U')
                {
                    i++;
                }

                while (i <= j && arr[j] != 'a' && arr[j] != 'A'
                       && arr[j] != 'e' && arr[j] != 'E'
                        && arr[j] != 'i' && arr[j] != 'I'
                         && arr[j] != 'o' && arr[j] != 'O'
                         && arr[j] != 'u' && arr[j] != 'U')
                {
                    j--;
                }
                if (i > j)
                {
                    break;
                }
                Swap(arr, i, j);
                i++;
                j--;
            }
            return new string(arr);
        }
        private void Swap(char[] arr, int i, int j)
        {
            var temp = arr[j];
            arr[j] = arr[i];
            arr[i] = temp;
        }
    }
}

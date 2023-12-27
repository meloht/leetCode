using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0151_0200
{
    public class _168_ExcelSheetColumnTitleAlg
    {
        public string ConvertToTitle(int columnNumber)
        {
            if (columnNumber == 26)
                return "Z";
            char a = 'A';
            string[] arr = new string[26];
            for (int i = 0; i < 26; i++)
            {
                char ch = (char)(a + i);
                if (i == 25)
                {
                    arr[0] = ch.ToString();
                }
                else
                {
                    arr[i + 1] = ch.ToString();
                }

            }
            List<string> list = new List<string>();

            if (columnNumber < 26)
            {
                return arr[columnNumber];
            }
            int rem = 0;
            int n = columnNumber;
            while (n >= 26)
            {
                rem = n % 26;
                n = n / 26;
                if (rem == 0)
                {
                    n--;
                }
                list.Add(arr[rem]);

            }
            if (n > 0)
            {
                list.Add(arr[n]);
            }
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = list.Count - 1; i >= 0; i--)
            {
                stringBuilder.Append(list[i]);
            }

            return stringBuilder.ToString();
        }
    }
}

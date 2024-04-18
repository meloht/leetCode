using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0801_0850
{
    public class _824_GoatLatinAlg
    {
        public string ToGoatLatin(string sentence)
        {
            string[] arr = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i][0] == 'a' || arr[i][0] == 'A'
                    || arr[i][0] == 'e' || arr[i][0] == 'E'
                    || arr[i][0] == 'i' || arr[i][0] == 'I'
                    || arr[i][0] == 'o' || arr[i][0] == 'O'
                     || arr[i][0] == 'u' || arr[i][0] == 'U')
                {
                    sb.Append(arr[i]).Append("ma");
                }
                else
                {
                    sb.Append(arr[i].Substring(1)).Append(arr[i][0]).Append("ma");
                }
                for (int j = 0; j < i + 1; j++)
                {
                    sb.Append("a");
                }
                sb.Append(" ");
            }
            return sb.ToString().Trim();
        }
    }
}

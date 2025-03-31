using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0801_0850
{
    public class _848_ShiftingLettersAlg
    {
        public string ShiftingLetters(string s, int[] shifts)
        {
            char[] chars = s.ToCharArray();

            int[] arr = new int[chars.Length];
            arr[shifts.Length - 1] = shifts[shifts.Length - 1];
            for (int i = shifts.Length - 2; i >= 0; i--)
            {
                arr[i] = (shifts[i] + arr[i + 1]) % 26;
            }

            for (int i = 0; i < s.Length; i++)
            {

                chars[i] = (char)((chars[i] - 'a' + arr[i]) % 26 + 'a');
            }

            return new string(chars);
        }
    }
}

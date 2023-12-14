using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1_50
{
    internal class _17_LetterCombinationsOfPhoneNumberAlg
    {
        Dictionary<string, string> dict = new Dictionary<string, string>();
        List<string> list = new List<string>();
        public IList<string> LetterCombinations(string digits)
        {
            if (string.IsNullOrEmpty(digits))
                return new List<string>();

            dict.Clear();
            list.Clear();


            dict.Add("0", "");
            dict.Add("1", " ");
            dict.Add("2", "abc");
            dict.Add("3", "def");
            dict.Add("4", "ghi");
            dict.Add("5", "jkl");

            dict.Add("6", "mno");
            dict.Add("7", "pqrs");
            dict.Add("8", "tuv");
            dict.Add("9", "wxyz");




            Combinations("", digits);

            return list;
        }
        private void Combinations(string combination, string nextDigits)
        {
            if (nextDigits.Length == 0)
            {
                list.Add(combination);
            }
            else
            {
                string dig = nextDigits.Substring(0, 1);
                string letters = dict[dig];

                for (int i = 0; i < letters.Length; i++)
                {
                    string letter = letters[i].ToString();

                    Combinations(combination + letter, nextDigits.Substring(1));
                }

            }


        }
    }
}

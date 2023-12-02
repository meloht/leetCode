using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._51_100
{
    public class _87_ScrambleStringAlg
    {
        public bool IsScramble(string s1, string s2)
        {

            bool bl = Recursion(s1, s2);

            return bl;
        }

        private bool Begin(string s1, string s2, int i)
        {
            var char1 = s1.Substring(0, i);
            var char2 = s2.Substring(0, i);

            var char11 = s1.Substring(i, s1.Length - i);
            var char22 = s2.Substring(i, s1.Length - i);

            if (IsSame(char1, char2) && IsSame(char11, char22))
            {
                bool bl = Recursion(char1, char2);
                bool bl2 = Recursion(char11, char22);
                return bl && bl2;
            }

            return false;
        }
        private bool End(string s1, string s2, int i)
        {
            var char1 = s1.Substring(0, i);
            var char2 = s2.Substring(s1.Length - i, i);

            var char11 = s1.Substring(i, s1.Length - i);
            var char22 = s2.Substring(0, s1.Length - i);

            if (IsSame(char1, char2) && IsSame(char11, char22))
            {
                bool bl = Recursion(char1, char2);
                bool bl2 = Recursion(char11, char22);
                return bl && bl2;
            }
            return false;
        }

        private bool Recursion(string s1, string s2)
        {
            if (s1 == s2)
                return true;

            if (s1.Length == 1)
            {
                return s1 == s2;
            }
            if (s1.Length == 2)
            {
                return IsSame(s1, s2);
            }

            for (int i = 1; i < s1.Length; i++)
            {
                if (Begin(s1, s2, i))
                {
                    return true;
                }
                if (End(s1, s2, i))
                {
                    return true;
                }

            }
            return false;
        }

        private bool IsSame(string arr1, string arr2)
        {
            if (arr1 == arr2)
                return true;

            char[] s1 = arr1.ToCharArray();
            char[] s2 = arr2.ToCharArray();
            Array.Sort(s1);
            Array.Sort(s2);

            if (s1.SequenceEqual(s2))
                return true;
            return false;
        }
    }
}

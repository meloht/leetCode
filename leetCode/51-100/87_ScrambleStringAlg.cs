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
            if (s1.Length == 1)
            {
                return s1 == s2;
            }
            if (s1.Length == 2)
            {
                var ss1 = s1.ToCharArray();
                Array.Sort(ss1);
                var s = new string(ss1);

                var ss2 = s2.ToCharArray();
                Array.Sort(ss2);
                var ss = new string(ss2);
                return s == ss;
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

        private bool Begin(string s1, string s2, int i)
        {
            var char1 = s1.Substring(0, i).ToCharArray();
            Array.Sort(char1);
            string ss1 = new string(char1);

            var char2 = s2.Substring(0, i).ToCharArray();
            Array.Sort(char2);
            string ss2 = new string(char2);

            var char11 = s1.Substring(i, s1.Length - i).ToCharArray();
            Array.Sort(char11);
            string ss11 = new string(char11);


            var char22 = s2.Substring(i, s1.Length - i).ToCharArray();
            Array.Sort(char22);
            string ss22 = new string(char22);
            if (ss1 == ss2 && ss11 == ss22)
            {
                return true;
            }
            return false;
        }
        private bool End(string s1, string s2, int i)
        {
            var char1 = s1.Substring(0, i).ToCharArray();
            Array.Sort(char1);
            string ss1 = new string(char1);

            var char2 = s2.Substring(s1.Length - i, i).ToCharArray();
            Array.Sort(char2);
            string ss2 = new string(char2);

            var char11 = s1.Substring(i, s1.Length - i).ToCharArray();
            Array.Sort(char11);
            string ss11 = new string(char11);


            var char22 = s2.Substring(0, s1.Length - i).ToCharArray();
            Array.Sort(char22);
            string ss22 = new string(char22);
            if (ss1 == ss2 && ss11 == ss22)
            {
                return true;
            }
            return false;
        }
    }
}

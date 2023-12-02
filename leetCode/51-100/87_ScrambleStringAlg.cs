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

            bool bl = AddAllList(s1, s2);

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
            bool bl = IsSame(s1, s2);
            if (bl == false)
                return false;

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


        private HashSet<string> GetAllList(string s1)
        {
            Dictionary<int, HashSet<string>> dict = new Dictionary<int, HashSet<string>>();
            dict.Add(0, new HashSet<string>());
            dict[0].Add(s1.Substring(0, 1));

            for (int i = 1; i < s1.Length; i++)
            {
                dict.Add(i, new HashSet<string>());
                var list = dict[i - 1];
                foreach (string c in list)
                {
                    string s = s1[i].ToString(); ;
                    dict[i].Add($"{c}{s}");
                    dict[i].Add($"{s}{c}");
                }
                dict.Remove(i - 1);
            }
            return dict[s1.Length - 1];
        }

        private bool AddAllList(string s1, string target)
        {
            if (s1 == target)
                return true;

            for (int i = 1; i < s1.Length; i++)
            {
                var sourceLeft = s1.Substring(0, i);
                var sourceRight = s1.Substring(i, s1.Length - i);
                var targetLeft = target.Substring(0, i);
                var targetRight = target.Substring(i, s1.Length - i);

                if (IsSame(sourceLeft, targetLeft) && IsSame(sourceRight, targetRight))
                {
                    bool bl = IsSameString(sourceLeft, sourceRight, targetLeft, targetRight);
                    if (bl)
                        return true;
                }

                var targetLeft2 = target.Substring(s1.Length - i, i);
                var targetRight2 = target.Substring(0, s1.Length - i);
                if (IsSame(sourceLeft, targetLeft2) && IsSame(sourceRight, targetRight2))
                {
                    bool bl = IsSameString(sourceLeft, sourceRight, targetLeft2, targetRight2);
                    if (bl)
                        return true;
                }
            }

            return false;
        }
        private bool IsSameString(string char1, string char11, string targetLeft, string targetRight)
        {
            var set1 = AllList(char1);
            var set2 = AllList(char11);
            if (set1.Contains(targetLeft) && set2.Contains(targetRight))
                return true;

            return false;
        }

        private HashSet<string> AllList(string s1)
        {
            HashSet<string> list = new HashSet<string>();
            list.Add(s1);

            for (int i = 1; i < s1.Length; i++)
            {

                var set1 = AllList(s1.Substring(0, i));

                var set2 = AllList(s1.Substring(i, s1.Length - i));

                foreach (var item in set1)
                {
                    foreach (var item2 in set2)
                    {
                        string ss = $"{item}{item2}";

                        if (!list.Contains(ss))
                        {
                            list.Add(ss);
                        }
                        string ss2 = $"{item2}{item}";

                        if (!list.Contains(ss2))
                        {
                            list.Add(ss2);
                        }
                    }
                }
            }
            return list;
        }
    }
}

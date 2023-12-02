using System;
using System.Collections.Generic;
using System.Diagnostics;
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



        private bool AddAllList(string s1, string target)
        {
            if (s1 == target)
                return true;
            if (s1.Length == 2)
            {
                return IsSame(s1, target);
            }
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
        private bool IsSameString(string sourceLeft, string sourceRight, string targetLeft, string targetRight)
        {
            var set1 = AllList(sourceLeft, targetLeft);
            var set2 = AllList(sourceRight, targetRight);

            if (set1 && set2)
                return true;

            return false;
        }

        private bool AllList(string s1, string target)
        {
            if (target == s1)
                return true;
            if (s1.Length == 2)
            {
                return IsSame(s1, target);
            }
            for (int i = 1; i < s1.Length; i++)
            {

                var left1 = s1.Substring(0, i);
                var right1 = s1.Substring(i, s1.Length - i);

                var left2 = target.Substring(0, i);
                var right2 = target.Substring(i, s1.Length - i);

                var left3 = target.Substring(s1.Length - i, i);
                var right3 = target.Substring(0, s1.Length - i);


                if (IsSame(left1, left2) && IsSame(right1, right2))
                {
                    var set1 = AllList(left1, left2);

                    var set2 = AllList(right1, right2);

                    if (set1 && set2)
                        return true;
                }
                if (IsSame(left1, left3) && IsSame(right1, right3))
                {
                    var set1 = AllList(left1, left3);

                    var set2 = AllList(right1, right3);

                    if (set1 && set2)
                        return true;
                }

            }
            return false;
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


    }
}
